using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

using System.Net;


namespace qmmqmqmq
{
    public class Mqtt_aesk
    {
       
        public static MqttClient Client;
       
        public static void set_client_ip(string host)
        {
            Client = new MqttClient(host);

        }

        public static byte MQTTConnect_Subscribe(string username, string password, string topic)
        {

            byte code = Client.Connect(Guid.NewGuid().ToString(), username, password);
            Client.MqttMsgPublishReceived += Mqtt_aesk.AeskMqttMsgPublishReceived;


            //subscribe
            try
            {
                Client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            }

            catch (Exception ex)
            {
                //Subscribe error

            }

            // connected returns 0x00 
            // not connected returns somethingelse
            return code;
        }

        public static void MQTTDisconnect()
        {
            Client.Disconnect();
            Client.MqttMsgPublishReceived -= Mqtt_aesk.AeskMqttMsgPublishReceived;

        }

        //Which topic we want to publish in
        // byte arrays we want to publish , it publishs by order
        // we have a function that converts other data types to byte[] but in other class.cs      
        public static void Combine_Publish(string topic, params byte[][] arrays)
        {
            byte[] ret = new byte[arrays.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in arrays)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            Client.Publish(topic, ret);

        }

        private static void AeskMqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
        

        }
    }
}
