using System;

namespace MqttPublissssh.Variables
{
    public class GPS
    {

        public static double angle_f64 { get; set; }
        public static double gps_latitude_f64 { get; set; }
        public static double gps_longtitude_f64 { get; set; }
        public static byte gps_velocity_u8 { get; set; }
        public static byte gps_sattelite_number_u8 { get; set; }
        public static byte gps_efficiency_u8 { get; set; }

    }
}
