using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.NewForms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Telemetri.Variables
{
    public class NewMQTT
    {
        private string _username = "aesk";
        private string _password = "1234";
        private int _dataLength = 54; //sadece mesaj
        private int _dataCounter = 0;
        public string topic;
        public string broker;
        public MqttClient client;
        public bool connected_flag = false;
        int msg_index = 0;
        public static ComproUI compro = new ComproUI();
        private enum step
        {
            CatchHeader1 = 0,
            CatchHeader2 = 1,
            CatchVehicleId = 3,
            CatchTargetId = 4,
            CatchSourceId = 5,
            CatchSourceMsgId = 6,
            CatchMsgSize = 7,
            CatchMsg = 8,
            CatchMsgIndexL = 9,
            CatchMsgIndexH = 10,
            CatchCrcL = 11,
            CatchCrcH = 12,

        }
        private step steppo = step.CatchHeader1;

        public NewMQTT(string _topic, string _broker)
        {
            topic = _topic;
            broker = _broker;
        }

        public NewMQTT()
        {

        }
        public bool ConnectSubscribe()
        {
            if (connected_flag == false)
            {
                this.client = new MqttClient(this.broker);
                byte code = this.client.Connect(Guid.NewGuid().ToString(), _username, _password);
                if (code == 0x00)
                {
                    try
                    {
                        this.client.Subscribe(new string[] { this.topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                        this.client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                        connected_flag = true;
                        UITools.PIDForm.queryButton.Enabled = true;
                        UITools.PIDForm.sendButton.Enabled = true;
                        UITools.TestForms.mqttBox.BackColor = Color.LimeGreen;
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
            if (connected_flag == true)
            {
                this.client.Disconnect();
                this.client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
                connected_flag = false;
            }
            else
            {
                MessageBox.Show("Zaten bağlı değilsiniz");
            }
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            compro.ComproUnpack(e.Message);
        }
        
    }
}
