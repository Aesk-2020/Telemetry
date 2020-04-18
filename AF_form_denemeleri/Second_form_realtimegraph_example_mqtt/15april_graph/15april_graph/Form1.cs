using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace _15april_graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        MqttClient Client = new MqttClient("157.230.29.63");


        private void connect_mqtt_Click(object sender, EventArgs e)
        {
            byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");
            Client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;


            if (code == 0x00)
            {
                richTextBox1.Text += "Connected\n";
            }
            else
            {
                richTextBox1.Text += "Connection Refused\n";
            }

            try
            {
                Client.Subscribe(new string[] { "/home/sensor" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            }

            catch (Exception ex)
            {
                richTextBox1.Text += ex.Message + "\n";

            }

        }

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            byte[] incoming = e.Message;

            

           int gelen = BitConverter.ToInt32(incoming, 0);
            
            richTextBox1.Text += gelen.ToString()+"\n";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            open_graph.Enabled = false;
            graph_form graph = new graph_form();
            graph.Show();
        }
    }
}
