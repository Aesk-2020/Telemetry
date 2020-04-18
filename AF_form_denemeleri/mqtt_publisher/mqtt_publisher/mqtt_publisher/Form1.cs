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

namespace mqtt_publisher
{
    public partial class Form_af : Form
    {
        public Form_af()
        {
            InitializeComponent();
        }

        private void Form_af_Load(object sender, EventArgs e)
        {

        }

        byte[] counter = new byte[1];
        
        

        MqttClient Client = new MqttClient("157.230.29.63");
        private void button1_Click(object sender, EventArgs e)
        {
            counter[0] = 0;
            byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");
            
            if (code == 0x00)
            {
                richTextBox1.Text += "Connected\n";
            }
            else
            {
                richTextBox1.Text += "Connection Refused\n";
            }

    
            timer1.Enabled = true;
        }
        int send = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            send++;
            //counter[0]++;
            Client.Publish("/home/sensor", BitConverter.GetBytes(send));
            //richTextBox1.Text += counter[0].ToString()+"\n";
            richTextBox1.Text += send.ToString() + "\n";
        }

        int errorr = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            errorr++;
            label2.Text = errorr.ToString();
            //Client.Publish("/home/sensor", counter);
            Client.Publish("/home/sensor", BitConverter.GetBytes(send));
            richTextBox1.Text +="An Error has been sent\n";
        }
    }
}
