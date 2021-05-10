using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Telemetri.Variables
{
    public class NewMQTT
    {
        private string _username = "aesk";
        private string _password = "1234";
        private int _dataLength; //sadece mesaj
        private int _dataCounter = 0;
        public string topic;
        public string broker;
        public MqttClient client;
        bool connected_flag = false;
        private enum step
        {
            CatchSync1 = 0,
            CatchSync2 = 1,
            CatchLength = 2,
            AddBuffer = 3
        }
        private step steppo = step.CatchSync1;

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
            byte[] recieve_data = e.Message; //rahat çalışmak ve okunailirlik için
            byte[] worked_data = new byte[255];

            for (int i = 0; i < recieve_data.Length; i++)
            {
                switch (steppo)
                {
                    case step.CatchSync1:
                        if (recieve_data[i] == MACROS.SYNC1)
                        {
                            steppo = step.CatchSync2; //else ekle hatalı paket yakalasın bunlar CRC dahil
                            worked_data[_dataCounter++] = recieve_data[i];
                        }
                        break;
                    case step.CatchSync2:
                        if (recieve_data[i] == MACROS.SYNC2)
                        {
                            steppo = step.CatchLength; //bu da aynı şekil
                            worked_data[_dataCounter++] = recieve_data[i];
                        }
                        else
                        {
                            steppo = step.CatchSync1;
                        }
                        break;
                    case step.CatchLength:
                        _dataLength = recieve_data[i];
                        worked_data[_dataCounter++] = recieve_data[i];
                        steppo = step.AddBuffer;
                        break;
                    case step.AddBuffer:
                        worked_data[_dataCounter++] = recieve_data[i];
                        if (_dataCounter == _dataLength + 2)
                        {
                            byte CRC_L = recieve_data[i + 1];
                            byte CRC_H = recieve_data[i + 2];
                            ushort incomingCRC = BitConverter.ToUInt16(new byte[] { CRC_L, CRC_H }, 0);
                            ushort calculatedCRC = MACROS.AeskCRCCalculate(worked_data, (uint)worked_data.Length);
                            if (incomingCRC == calculatedCRC)
                            {
                                dataConvertMQTT(worked_data);
                                //çözülen++;
                                //indeks kontrol;
                            }
                            steppo = step.CatchSync1;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        void dataConvertMQTT(byte[] receiveBuffer) //ESKİ KOD
        {
            int startIndex = 0;
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
