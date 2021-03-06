﻿using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Windows.Forms;
namespace telemetry_hydro.Variables
{
    public delegate void LogDelegate();
    public class MQTT : SerialPortCOMRF
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
            dataConvertMQTT(e.Message);
            error_counter += find_error(mqtt_counter_old, MQTT_counter_int32);
            MQTT_Efficiency = 1 - (Convert.ToDouble(error_counter) / Convert.ToDouble(mqtt_total_counter));
            mqtt_refresh_time = (double)totalTime / mqtt_total_counter;
            old_time = current_time;
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

            VCU.wake_up_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            VCU.set_velocity_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);

            Driver.phase_a_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.phase_b_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.dc_bus_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.dc_bus_voltage_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            Driver.id_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.iq_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.phase_a_rms_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.torque_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
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
            VCU.can_error_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            MQTT_counter_int32 = EncodePackMethods.DataConverterS32(receiveBuffer, ref startIndex);
            BMS.bms_temp[0] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.bms_temp[1] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.bms_temp[2] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.bms_temp[3] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.bms_temp[4] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.bms_temp[5] = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.bms_temp[6] = receiveBuffer[startIndex];
            LogEvent();
        }
    }
}
