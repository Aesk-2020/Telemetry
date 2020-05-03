using System;
using System.Drawing;
using uPLibrary.Networking.M2Mqtt;

namespace yeniform.Variables
{
    public struct MACROS
    {
        public const double C_RADIUS_EARTH_KM = 6371100;
        public const string aesk_IP = "157.230.29.63";
        public const string MQTT_username = "digital";
        public const string MQTT_password = "aesk";
        public const string MQTT_topic = "/home/sensor";
        public const double centerLat = 40.743778;
        public const double centerLong = 29.783807;
        public const double startLineLat = 40.744392;
        public const double startLineLong = 29.786054;
        public const uint RFBufferLength = 55;
        public const byte RFBufferHeader = 0x69;
        public static Color AeskBlue = Color.FromArgb(47, 136, 202);
        public const int FLOAT_CONVERTER_1 = 10;
        public const int FLOAT_CONVERTER_2 = 100;
        public const int FLOAT_CONVERTER_3 = 1000;
        public const int GPS_DIVIDER = 1000000;
        public static bool race_start_flag;
        public static bool[] sector_flag = new bool[3] { false, false, false };
        public static readonly double mstokmh = 3.6;
        public static bool mouse_mod = false;
        public static byte[] gsm_reset_buffer = new byte[4] { 0x01, 0x02, 0x03, 0x04 };
        public static UInt32 toplam_yol = 58500;
        public static Color errorColor = Color.Red;
        public static MqttClient client = new MqttClient(aesk_IP);
        public static string TimeStringFormat = @"hh\:mm\:ss";
        public static double total_Tur = 30;
        public static int maks_set_hiz = 65;
        public static bool show_old_datas;
        public static bool hold_my_history;
        public static bool newDataCome = false;
    }
}
