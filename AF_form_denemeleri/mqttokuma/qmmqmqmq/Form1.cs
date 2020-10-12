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




namespace qmmqmqmq
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

        DateTime a;
        MqttClient Client = new MqttClient("157.230.29.63");
        private void button1_Click(object sender, EventArgs e)
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

            a = DateTime.Now;

        }

        UInt32 toplam_gelen = 0;
        UInt32 error_counter = 0;

        UInt32 rast = 0;
        byte[] incoming_old = { 0, 0, 0, 0 };
        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            toplam_gelen++;
            byte[] incoming = e.Message;
            foreach (byte c in incoming)
            {
                richTextBox1.Text+=(Convert.ToString(c, 2).PadLeft(8, '0') + " ");
            }
            richTextBox1.Text +="\n";


            /*
            error_counter += return_error(incoming_old, incoming);
            DateTime b = DateTime.Now;
            double total_ms = (b - a).TotalMilliseconds;

            //double x=BitConverter.ToDouble(e.Message,8);

            richTextBox1.Text += incoming[0].ToString() + "\n";


            label1.Text = toplam_gelen.ToString();
            label2.Text = error_counter.ToString();


            double c = Convert.ToDouble(error_counter) / Convert.ToDouble(toplam_gelen);
            label3.Text = Convert.ToString(c);
            incoming_old = incoming;*/

            //a = b;
        }

        UInt32 return_error(byte[] old_byte, byte[] new_byte)
        {
            UInt32 old_d = (UInt32)BitConverter.ToUInt32(old_byte, 0);
            UInt32 new_d = (UInt32)BitConverter.ToUInt32(new_byte, 0);

            UInt32 x = new_d - old_d;
            //hata olup olmadigini anlamak icin en az 2 veri gelmeli
            //biz old_d yi basta 0 set ettik
            //yani ilk veri 24 gelince 24 hatamiz olmamali
            if (old_d == 0)
            {
                return 0;
            }
            // 0-1 = 499999 dondurmesin diye
            if (x == 0)
            {
                return 1;
            }

            return (x - 1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
        }
    }
}

   





