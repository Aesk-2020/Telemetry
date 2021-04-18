using System;
using System.Drawing;
using uPLibrary.Networking.M2Mqtt;

namespace Telemetri.Variables
{
    public struct MACROS
    {
        public const double C_RADIUS_EARTH_KM = 6371100;
        public const string aesk_IP = "broker.mqttdashboard.com";
        public const string MQTT_username = "digital";
        public const string MQTT_password = "aesk";
        public const string MQTT_topic = "LYRADATA";
        //40.95767341297037, 29.410455013620723
        public const double centerLat = 40.957673;
        public const double centerLong = 29.410455;
        //40.95187517899788, 29.40317203853778
        public const double startLineLat = 40.951875;
        public const double startLineLong = 29.403172;
        public const uint RFBufferLength = 55;
        public const byte RFBufferHeader = 0x69;
        public static Color AeskBlue = Color.FromArgb(47, 136, 202);
        public const int FLOAT_CONVERTER_1 = 10;
        public const int FLOAT_CONVERTER_2 = 100;
        public const int FLOAT_CONVERTER_3 = 1000;
        public const int BMS_CELL_DIVIDER = 50;
        public const int GPS_DIVIDER = 1000000;
        public static bool race_start_flag;
        public static bool[] sector_flag = new bool[4] { false, false, false, false};
        public static bool sector_4to_1 = false;
        public static readonly double mstokmh = 3.6;
        public static bool mouse_mod = false;
        public static byte[] gsm_reset_buffer = new byte[4] {0x34, 0xFF, 0xAF, 0xBF};
        public static UInt32 toplam_yol = 58500;
        public static Color errorColor = Color.Red;
        public static MqttClient client = new MqttClient(aesk_IP);
        public static string TimeStringFormat = @"hh\:mm\:ss";
        public static double total_Tur = 30;
        public static int maks_set_hiz = 65;
        public static bool show_old_data;
        public static bool hold_my_history;
        public static bool newDataCome = false;
        public static bool IsSd = false;
        public static float ceza_puani = 0;
        public static float odul_puani = 0;
        public static float total_battery_capacity = 2000;
        public static float SOC_CONVERTER = 50.0F;

        public static double S1_Start => 341.4;
        public static double S1_Stop => 70.3;

        public static double S2_Start => 70.3;
        public static double S2_Stop => 179.3;

        public static double S3_Start => 179.3;
        public static double S3_Stop => 282.2;

        public static double S4_Start => 282.2;
        public static double S4_Stop => 341.4;

        public static double turAtStart => 350.0;
        public static double turAtStop => 20.0;

        public static string LOGHEADER = "Time	wake_up	set_velocity	can_error	Phase_A_Current	Phase_B_Current	Dc_Bus_Current	Dc_Bus_voltage	Id	Iq	IArms	Torque	drive_status	driver_error	Odometer	Motor_Temperature	actual_velocity	Bat_Voltage	Bat_Current	Bat_Cons	Soc	bms_error	dc_bus_state	Worst_Cell_Voltage	Worst_Cell_Address	Temperature	latitude	longtitude	speed_u8	satellite_number	gpsEfficiency	trueData	checksumError   validDataError";
    }
}
