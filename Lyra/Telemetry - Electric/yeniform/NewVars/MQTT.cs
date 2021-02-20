using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Windows.Forms;


namespace Telemetri.NewVars
{

    public static class MQTT
    {

        public static int mqtt_total_counter = 0;
        public static double MQTT_Efficiency;
        public static DateTime old_time;


        public static int MQTT_counter_int32;
        public static int error_counter = 0;
        public static double mqtt_refresh_time;

        private static int mqtt_counter_old = 0;
        private static double totalTime;

        private static MqttClient _client;
        public static byte StartMqtt()
        {
            _client = new MqttClient(MACROS.MQTT_broker_ip);
            byte code = _client.Connect(Guid.NewGuid().ToString(), MACROS.MQTT_username, MACROS.MQTT_password);
            _client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            old_time = DateTime.Now;
            return code;
        }
        public static void SubscribeTopic(string Topic)
        {
            try
            {
                _client.Subscribe(new string[] { Topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UnSubscribeTopic(string Topic)
        {
            try
            {
                _client.Unsubscribe(new string[] { Topic });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void disConnectMQTT()
        {
            _client.Disconnect();
            _client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
        }

        private static int find_error(int old_d, int new_d)
        {
            int x = new_d - old_d;
            if (old_d == 0)
            {
                return 0;
            }
            return Math.Abs(x - 1);
        }

        private static void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //yeni senaryo espden okurken uarttan yanlis gelirse size tutmuyor kontrolu
            if (e.Message.Length == MACROS.MQTT_packet_size)
            {
                DataFlow.Mqtt_Packet_Decomposer(e.Message);
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
                //Loglama
            }
        }
    }
}
