using System;
using System.Runtime.CompilerServices;

namespace MqttPublissssh.Variables
{
    public delegate void ConsoleFrontDel();
    public class Macros
    {
      
        public const string aesk_IP = "46.102.106.183";
        public const string MQTT_username = "digital";
        public const string MQTT_password = "aesk";
        public const string MQTT_topic = "HYDRADATA";

        public static int MQttCounter;
        
        public static ConsoleFrontDel consoleFront;

        public static byte[] array_of_x = new byte[97];


    }
}
