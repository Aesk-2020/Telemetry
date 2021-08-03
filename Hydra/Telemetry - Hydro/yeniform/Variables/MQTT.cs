using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Windows.Forms;
using Telemetri.Variables;

namespace telemetry_hydro.Variables
{
    public delegate void LogDelegate();
    public class MQTT
    {
        public event LogDelegate LogEvent;
        public int mqtt_total_counter = 0;
        public double MQTT_Efficiency;
        public DateTime old_time;
        double totalTime = 0;
        public int MQTT_counter_int32;
        public int error_counter = 0;
        public double mqtt_refresh_time;
        int mqtt_counter_old = 0;
        string _username;
        string _password;
        string _topic;
        private MqttClient _client;
        bool isFirst = true;
        public MQTT(string username, string password, string topic)
        {

            _username = username;
            _password = password;
            _topic = topic;
        }

        public MQTT()
        {

        }

        public void MQTTInit(MqttClient Client)
        {
            _client = Client;
        }

        public byte ConnectRequestMQTT()
        {
            byte code = _client.Connect(Guid.NewGuid().ToString(), _username, _password);
            _client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;

            //SERVERDEN YANIT BAGLANDI BAGLANILAMADI
   
            //SERVER BIZI KABUL ETTI MI
            try
            {
                _client.Subscribe(new string[] { _topic, "vehicle_to_interface_2" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
            }

            catch (Exception ex)
            {
                //Subscribe error
                MessageBox.Show(ex.Message);
            }

            old_time = DateTime.Now;
            return code;        
        }

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            mqtt_counter_old = MQTT_counter_int32;
            if (mqtt_total_counter == 0)
            {
                old_time = DateTime.Now;
            }

            mqtt_total_counter++;
            DateTime current_time = DateTime.Now;
            totalTime += (current_time - old_time).TotalMilliseconds;
            error_counter += find_error(mqtt_counter_old, MQTT_counter_int32);
            MQTT_Efficiency = 1 - (Convert.ToDouble(error_counter) / Convert.ToDouble(mqtt_total_counter));
            mqtt_refresh_time = (double)totalTime / mqtt_total_counter;
            old_time = current_time;
            if (e.Topic == "HYDRADATA")
            {
                dataConvertMQTT(e.Message);
            }
            else if(e.Topic == "vehicle_to_interface_2")
            {
                ComproUI pack = new ComproUI();
                pack.ComproUnpack(e.Message);
                LogEvent();
            }
        }

        public void disConnectMQTT()
        {
            _client.Disconnect();
            _client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
        }

        int find_error(int old_d, int new_d)
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

        void dataConvertMQTT(byte[] receiveBuffer)
        {
            int startIndex = 0;
            DataVCU.drive_commands_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataVCU.speed_set_rpm_s16 = (short)Math.Round(BitConverter.ToInt16(receiveBuffer, startIndex) * 0.105183); startIndex += 2; //0.105183 rpm to kmh rate
            DataVCU.torque_set_s16 = BitConverter.ToInt16(receiveBuffer, startIndex); startIndex += 2;
            DataVCU.torque_set_2_s16 = BitConverter.ToUInt16(receiveBuffer, startIndex); startIndex += 2;
            DataVCU.torque_limit_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            //MCU
            DataMCU.act_id_current_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.act_iq_current_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.vd_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.vq_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.set_id_current_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.set_iq_current_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.set_torque_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.i_dc_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.v_dc_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.act_speed_s16 = (short)Math.Round(BitConverter.ToInt16(receiveBuffer, startIndex) * 0.105183 / 10); startIndex += 2;
            DataMCU.temperature_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataMCU.error_status_u16 = BitConverter.ToUInt16(receiveBuffer, startIndex); startIndex += 2;
            DataMCU.act_torque_s8 = (sbyte)receiveBuffer[startIndex++]; DataMCU.act_torque_s8 -= 100;

            //BMS
            DataBMS.volt_u16 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataBMS.cur_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataBMS.cons_u16 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 10; startIndex += 2;
            DataBMS.soc_u16 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataBMS.worst_cell_volt_u16 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 10; startIndex += 2;
            DataBMS.error_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataBMS.dc_bus_state_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataBMS.worst_cell_address_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataBMS.temperature_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            //GPS
            DataGPS.latitude_f32 = BitConverter.ToUInt32(receiveBuffer, startIndex) / MACROS.GPS_DIVIDER; startIndex += 4;
            DataGPS.longtitude_f32 = BitConverter.ToUInt32(receiveBuffer, startIndex) / MACROS.GPS_DIVIDER; startIndex += 4;
            DataGPS.speed_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataGPS.sattelite_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataGPS.efficiency_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            if(isFirst == true)
            {
                DataGPS.point1 = new GMap.NET.PointLatLng(DataGPS.latitude_f32, DataGPS.longtitude_f32);
                isFirst = false;
            }
            else
            {
                DataGPS.point2 = DataGPS.point1;
                DataGPS.point2 = new GMap.NET.PointLatLng(DataGPS.latitude_f32, DataGPS.longtitude_f32);
                long distance = DataGPS.CalculateDistance(DataGPS.point1, DataGPS.point2);
                DataGPS.odometer += distance;
                DataGPS.LapControl(DataGPS.lapPoint1, DataGPS.lapPoint2, DataGPS.lapPoint3, new GMap.NET.PointLatLng(DataGPS.latitude_f32, DataGPS.longtitude_f32));
            }

            //CAN Error
            DataVCU.can_error_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            //SD result
            DataVCU.SD_result_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            //TCU minute
            DataVCU.TCU_minute_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            for (int i = 0; i < DataBMS.cells.Count; i++)
            {
                DataBMS.cells[i].voltage_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                DataBMS.cells[i].actVoltage = DataBMS.cells[i].voltage_u8 + DataBMS.worst_cell_volt_u16;
            }

            EMS.bat_cons_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex)/MACROS.FLOAT_CONVERTER_1;
            EMS.fc_cons_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            EMS.fc_lt_cons_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            EMS.out_cons_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;

            EMS.bat_cur_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            EMS.fc_cur_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            EMS.out_cur_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;

            EMS.bat_volt_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            EMS.fc_volt_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            EMS.out_volt_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;

            EMS.penalty_s8 = (SByte)EncodePackMethods.DataConverterS8(receiveBuffer, ref startIndex);
            EMS.bat_soc_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_3;
            EMS.temperature_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            EMS.error_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            int counterr = 0;
            for (int i = 0; i < DataBMS.cells.Count / 4; i++)
            {
                byte temperatureBuffer = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                for (int j = 0; j < 4; j++)
                {
                    DataBMS.cells[counterr++].temperature_u8 = temperatureBuffer;
                }
            }
            // 0 1 2 3
            // 4 5 6 7
            // 8 9 10 11
            // 12 13 14 15
            // 14 15 16 17
            // 18 19 20 21
            // 21 22 23 24
            // 25 26 27 28

            /*for (int i = 0; i < DataBMS.cells.Count; i++)
            {
                DataBMS.cells[0].soc_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            }*/
            LogEvent();
        }
    }
}
