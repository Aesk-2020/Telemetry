using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.Variables;

namespace Telemetri.NewForms
{
    public partial class Anasayfa : Form
    {
        MQTT mqttObj = new MQTT("LYRADATA"); //LYRADATA topic'ine bağlanacak MQTT nesnesini oluştur.
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portsListBox.Items.AddRange(ports);
        }/*
        private void portsListBox_Click(object sender, EventArgs e)
        {
            
        }
        private void mqttConnectBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void mqttDisconnectBtn_Click(object sender, EventArgs e)
        {
            
        }*/
        private void portConnectBtn_Click(object sender, EventArgs e)
        {

        }

        private void portsListBox_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portsListBox.Items.AddRange(ports);
        }

        private void mqttConnectBtn_Click(object sender, EventArgs e)
        {
            mqttObj.ConnectSubscribe();
            mqttDisconnectBtn.Enabled = true;
            mqttConnectBtn.Enabled = false;
        }

        private void mqttDisconnectBtn_Click(object sender, EventArgs e)
        {
            mqttObj.Disconnect();
            mqttConnectBtn.Enabled = true;
            mqttDisconnectBtn.Enabled = false;
        }
    }
}
