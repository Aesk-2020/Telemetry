using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri.NewVars
{
    public struct MACROS
    {
        public const double C_RADIUS_EARTH_KM = 6371100;
        public const string MQTT_broker_ip = "broker.mqttdashboard.com";
        public const string MQTT_username = "digital";
        public const string MQTT_password = "aesk";
        public const string MQTT_topic = "LYRADATA";
        public const int MQTT_packet_size = 96;

        public const double centerLat = 40.743778;
        public const double centerLong = 29.783807;

        public const double startLineLat = 40.744392;
        public const double startLineLong = 29.786054;
    }
}
