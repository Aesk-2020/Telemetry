using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.NewForms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Telemetri.Variables
{
    public class NewMQTT
    {
        private string _username = "aesk";
        private string _password = "1234";
        private int _dataLength = 54; //sadece mesaj
        private int _dataCounter = 0;
        public string topic;
        public string broker;
        public MqttClient client;
        bool connected_flag = false;
        int msg_index = 0;
        public static ComproUI compro = new ComproUI();
        private enum step
        {
            CatchHeader1 = 0,
            CatchHeader2 = 1,
            CatchVehicleId = 3,
            CatchTargetId = 4,
            CatchSourceId = 5,
            CatchSourceMsgId = 6,
            CatchMsgSize = 7,
            CatchMsg = 8,
            CatchMsgIndexL = 9,
            CatchMsgIndexH = 10,
            CatchCrcL = 11,
            CatchCrcH = 12,

        }
        private step steppo = step.CatchHeader1;

        public NewMQTT(string _topic, string _broker)
        {
            topic = _topic;
            broker = _broker;
        }

        public NewMQTT()
        {

        }
        public bool ConnectSubscribe()
        {
            if (connected_flag == false)
            {
                this.client = new MqttClient(this.broker);
                byte code = this.client.Connect(Guid.NewGuid().ToString(), _username, _password);
                if (code == 0x00)
                {
                    try
                    {
                        this.client.Subscribe(new string[] { this.topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                        this.client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                        connected_flag = true;
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show(exce.Message);
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show($"Sunucuya bağlanılamadı. Hata kodu: {code}");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Zaten bağlısınız");
                return true;
            }
        }
        public void Disconnect()
        {
            if (connected_flag == true)
            {
                this.client.Disconnect();
                this.client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
                connected_flag = false;
            }
            else
            {
                MessageBox.Show("Zaten bağlı değilsiniz");
            }
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            byte[] received_data = e.Message; //rahat çalışmak ve okunailirlik için
            
            List<byte> worked_data = new List<byte>();

            for (int i = 0; i < received_data.Length; i++)
            {
                switch (steppo)
                {
                    case step.CatchHeader1:
                        {
                            if (received_data[i] == compro.HEADER1)
                            {
                                worked_data.Add(received_data[i]);
                                _dataCounter++;
                                steppo = step.CatchHeader2;
                            }
                            else
                            {
                                _dataCounter = 0;
                                steppo = step.CatchHeader1;
                            }
                        }
                        break;
                    case step.CatchHeader2:
                        {
                            if (received_data[i] == compro.HEADER2)
                            {
                                worked_data.Add(received_data[i]);
                                _dataCounter++;
                                steppo = step.CatchVehicleId;
                            }
                            else
                            {
                                _dataCounter = 0;
                                steppo = step.CatchHeader1;
                            }
                        }
                        break;
                    case step.CatchVehicleId:
                        {
                            if(received_data[i] == compro.vehicle_id)
                            {
                                worked_data.Add(received_data[i]);
                                _dataCounter++;
                                steppo = step.CatchTargetId;
                            }
                            else
                            {
                                _dataCounter = 0;
                                steppo = step.CatchHeader1;
                            }
                        }
                        break;
                    case step.CatchTargetId:
                        {
                            compro.target_id = received_data[i];
                            worked_data.Add(received_data[i]);
                            _dataCounter++;
                            steppo = step.CatchSourceId;
                        }
                        break;
                    case step.CatchSourceId:
                        {
                            worked_data.Add(received_data[i]);
                            compro.source_id = received_data[i];
                            _dataCounter++;
                            steppo = step.CatchSourceMsgId;
                        }
                        break;
                    case step.CatchSourceMsgId:
                        {
                            worked_data.Add(received_data[i]);
                            compro.source_msg_id = received_data[i];
                            _dataCounter++;
                            steppo = step.CatchMsgSize;
                        }
                        break;
                    case step.CatchMsgSize:
                        {
                            worked_data.Add(received_data[i]);
                            compro.msg_size = received_data[i];
                            _dataCounter++;
                            steppo = step.CatchMsg;
                            compro.message = new byte[compro.msg_size];
                        }
                        break;
                    case step.CatchMsg:
                        {
                            worked_data.Add(received_data[i]);
                            compro.message[msg_index++] = received_data[i];
                            if(msg_index >= compro.msg_size)
                            {
                                steppo = step.CatchMsgIndexL;
                                msg_index = 0;
                            }
                        }
                        break;
                    case step.CatchMsgIndexL:
                        {
                            worked_data.Add(received_data[i]);
                            compro.msg_index = received_data[i];
                            steppo = step.CatchMsgIndexH;
                        }
                        break;
                    case step.CatchMsgIndexH:
                        {
                            worked_data.Add(received_data[i]);
                            compro.msg_index = (byte)(compro.msg_index | (received_data[i] << 8));
                            steppo = step.CatchCrcL;
                        }

                        break;
                    case step.CatchCrcL:
                        {
                            compro.crc = received_data[i];
                            steppo = step.CatchCrcH;
                        }
                        break;
                    case step.CatchCrcH:
                        {
                            compro.crc = (ushort)(compro.crc | (received_data[i] << 8));
                            UInt16 crc_calculated;
                            crc_calculated = MACROS.AeskCRCCalculate(worked_data.ToArray(), (uint)worked_data.Count-2);
                            if(crc_calculated == compro.crc)
                            {
                                dataConvertCompro(worked_data.ToArray());
                                
                            }
                            steppo = step.CatchHeader1;
                            _dataCounter = 0;

                        }
                        break;
                    default:
                        break;
                }
            }
        }
        void dataConvertCompro(byte[] receiveBuffer)
        {
            int startIndex = 7;
            float kp;
            float kd;
            float ki;
            kp = BitConverter.ToSingle(receiveBuffer, startIndex);startIndex += 4;
            kd = BitConverter.ToSingle(receiveBuffer, startIndex);startIndex += 4;
            ki = BitConverter.ToSingle(receiveBuffer, startIndex);startIndex += 4;
            MessageBox.Show("Kp: "+kp.ToString()+"\n" + "Kd: " + kd.ToString()+ "\n"+"Ki: " + ki.ToString()+"\n");
        }
        void dataConvertMQTT(byte[] receiveBuffer) //ESKİ KOD
        {
            int startIndex = 2;
            VCU.wake_up_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            VCU.set_velocity_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            Driver.phase_a_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.phase_b_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.dc_bus_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.dc_bus_voltage_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            Driver.id_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.iq_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.IArms_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.Torque_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.drive_status_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            Driver.driver_error_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            Driver.odometer_u32 = EncodePackMethods.DataConverterU32(receiveBuffer, ref startIndex);
            Driver.motor_temperature_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            Driver.actual_velocity_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.bat_volt_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            BMS.bat_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            BMS.bat_cons_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            BMS.soc_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            BMS.bms_error_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.dc_bus_state_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.worst_cell_voltage_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            BMS.worst_cell_address_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            if (!MACROS.mouse_mod)
            {
                GpsTracker.gps_latitude_f64 = (double)EncodePackMethods.DataConverterU32(receiveBuffer, ref startIndex) / MACROS.GPS_DIVIDER;
                GpsTracker.gps_longtitude_f64 = (double)EncodePackMethods.DataConverterU32(receiveBuffer, ref startIndex) / MACROS.GPS_DIVIDER;
                GpsTracker.gps_velocity_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
                GpsTracker.gps_sattelite_number_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
                GpsTracker.gps_efficiency_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            }
            else
            {
                startIndex += 11;
            }
            AFront.ChangeUI();
            /*
            BMS.bms_cells[0] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[1] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[2] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[3] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[4] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[5] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[6] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[7] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[8] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[9] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[10] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[11] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[12] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[13] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[14] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[15] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[16] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[17] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[18] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[19] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[20] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[21] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[22] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[23] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[24] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[25] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[26] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            BMS.bms_cells[27] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex) + BMS.worst_cell_voltage_f32;
            VCU.can_error_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp1_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp2_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp3_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp4_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp5_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp6_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp7_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);

            BMS.bms_soc[0] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[1] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[2] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[3] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[4] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[5] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[6] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[7] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[8] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[9] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[10] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[11] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[12] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[13] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[14] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[15] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[16] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[17] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[18] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[19] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[20] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[21] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[22] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[23] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[24] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[25] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[26] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) / MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[27] = ((float)receiveBuffer[startIndex]) / MACROS.SOC_CONVERTER + BMS.soc_f32;
            */
        }
    }
}
