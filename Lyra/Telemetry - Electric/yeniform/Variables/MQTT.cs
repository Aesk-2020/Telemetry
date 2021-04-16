using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Windows.Forms;
namespace Telemetri.Variables
{
    public delegate void LogDelegate();
    public class MQTT : SerialPortCOMRF
    {
        public event LogDelegate LogEvent;
        public int mqtt_total_counter = 0;
        public double MQTT_Efficiency;
        public DateTime old_time;
        double totalTime = 0;
        bool connected_flag = false;
        public int MQTT_counter_int32;
        public int error_counter = 0;
        public double mqtt_refresh_time;
        int mqtt_counter_old = 0;
        string _username = "aesk";
        string _password = "1234";
        string _topic;
        private MqttClient _client;
        private MqttClient _client1;
        public MQTT(string username, string password, string topic)
        {

            _username = username;
            _password = password;
            _topic = topic;
        }

        public MQTT(string topic)
        {
            _topic = topic;
        }

        public MQTT()
        {

        }

        public void MQTTInit(MqttClient Client)
        {
            _client = Client;
        }

        public void Init()
        {
            
        }

        public bool ConnectSubscribe()
        {
            if(connected_flag == false)
            {
                _client1 = new MqttClient("broker.mqttdashboard.com");
                byte code = _client1.Connect(Guid.NewGuid().ToString(), _username, _password);
                if (code == 0x00)
                {
                    try
                    {
                        _client1.Subscribe(new string[] { _topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                        _client1.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
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
                    //MessageBox.Show("Sunucuya bağlanılamadı. Hata kodu: {0}", code.ToString("X"));
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
            if(connected_flag == true)
            {
                _client1.Disconnect();
                _client1.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
                connected_flag = false;
            }
            else
            {
                MessageBox.Show("Zaten bağlı değilsiniz");
            }
        }

        public byte MQTTsubscribe() //ESKİ KOD
        {
             byte code = _client.Connect(Guid.NewGuid().ToString(), _username, _password);
            _client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            try
            {
                _client.Subscribe(new string[] { _topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
            }

            catch (Exception ex)
            {
                //Subscribe error
                MessageBox.Show(ex.Message);
            }

            old_time = DateTime.Now;
            return code; 
        }

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) //ESKİ KOD
        {
            mqtt_counter_old = MQTT_counter_int32;
            if (mqtt_total_counter == 0)
            {
                old_time = DateTime.Now;
            }

            mqtt_total_counter++;
            DateTime current_time = DateTime.Now;
            totalTime += (current_time - old_time).TotalMilliseconds;
            dataConvertMQTT(e.Message);
            error_counter += find_error(mqtt_counter_old, MQTT_counter_int32);
            MQTT_Efficiency = 1 - (Convert.ToDouble(error_counter) / Convert.ToDouble(mqtt_total_counter));
            mqtt_refresh_time = (double)totalTime / mqtt_total_counter;
            old_time = current_time;
        }

        public void disConnectMQTT() //ESKİ KOD
        {
            _client.Disconnect();
            _client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
        }

        int find_error(int old_d, int new_d) //ESKİ KOD
        {

            int x = new_d - old_d;
            //hata olup olmadigini anlamak icin en az 2 veri gelmeli
            //biz old_d yi basta 0 set ettik
            //yani ilk veri 24 gelince 24 hatamiz olmamali
            if (old_d == 0)
            {
                return 0;
            }

            return Math.Abs(x - 1);

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
            MQTT_counter_int32 = EncodePackMethods.DataConverterS32(receiveBuffer, ref startIndex);
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
            BMS.bms_soc[25] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) /  MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[26] = ((float)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex) /  MACROS.SOC_CONVERTER) + BMS.soc_f32;
            BMS.bms_soc[27] = ((float)receiveBuffer[startIndex]) / MACROS.SOC_CONVERTER + BMS.soc_f32;
            LogEvent();
        }
    }
}
