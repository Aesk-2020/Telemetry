using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace _15april_graph
{
    public partial class graph_form : Form
    {
        public graph_form()
        {
            InitializeComponent();
        }
        MqttClient Client = new MqttClient("157.230.29.63");
        private Thread cpuThread;

        private void graph_form_Load(object sender, EventArgs e)
        {
            
            byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");
            Client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;


           

            try
            {
                Client.Subscribe(new string[] { "/home/sensor" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            }

            catch (Exception ex)
            {
            }
        


        }

        DateTime start = DateTime.Now;
        int gelen;

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            byte[] incoming = e.Message;
            gelen = BitConverter.ToInt32(incoming, 0);

            geleni_bas();
     
        }
        private void geleni_bas()
        {
            cpuThread = new Thread(new ThreadStart(this.graph_draw));
            cpuThread.Start();
        }

        private void graph_draw()
        {

            this.Invoke((MethodInvoker)delegate { draw_funct(); });
            Thread.Sleep(400);

        }
        private void draw_funct()
        {
            double total_sec = (DateTime.Now - start).TotalSeconds;
            chart2.Series[0].Points.AddXY(total_sec, gelen);
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY("Gelen", gelen);
        }



    }
}
