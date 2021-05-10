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
        MQTT mqttObj = new MQTT(MACROS.newSubTopic); //LYRADATA topic'ine bağlanacak MQTT nesnesini oluştur.
        string splitter = "aesk\n";
        List<string> lineList;
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portsListBox.Items.AddRange(ports);
            LogSystem.isFirst = true;
            UITools.Anasayfa.actVelocityLabel = actVelocityLabel;
            UITools.Anasayfa.batConsLabel = batConsLabel;
            UITools.Anasayfa.batCurLabel = batCurLabel;
            UITools.Anasayfa.errorsLabel = errorsLabel;
            UITools.Anasayfa.socLabel = socLabel;
            UITools.Anasayfa.startTimeLabel = startTimeLabel;
            UITools.Anasayfa.setVelocityLabel = setVelocityLabel;
            UITools.Anasayfa.driveStatusLabel = driveStatusLabel;
        }
        private void portConnectBtn_Click(object sender, EventArgs e)
        {
            LogSystem.ExtractSDLog(lineList); //TAŞINACAK
        }

        private void portsListBox_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portsListBox.Items.AddRange(ports);
        }

        private void mqttConnectBtn_Click(object sender, EventArgs e)
        {
            if(mqttObj.ConnectSubscribe())
            {
                mqttDisconnectBtn.Enabled = true;
                mqttConnectBtn.Enabled = false;
                startLogBtn.Enabled = true;
                portConnectBtn.Enabled = false;
            }
        }

        private void mqttDisconnectBtn_Click(object sender, EventArgs e)
        {
            mqttObj.Disconnect();
            mqttConnectBtn.Enabled = true;
            mqttDisconnectBtn.Enabled = false;
            startLogBtn.Enabled = false;
            portConnectBtn.Enabled = true;
        }

        private void startLogBtn_Click(object sender, EventArgs e)
        {
            if(LogSystem.StartLog(logTimer) == true)
            {
                startLogBtn.Enabled = false;
                stopLogBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Uzantı seçilemedi.");
            }
        }

        private void logTimer_Tick(object sender, EventArgs e)
        {
            LogSystem.WriteStringLog();
        }

        private void stopLogBtn_Click(object sender, EventArgs e)
        {
            LogSystem.StopLog(logTimer);
            startLogBtn.Enabled = true;
            stopLogBtn.Enabled = false;
        }

        private void openSDLogBtn_Click(object sender, EventArgs e)
        {
            lineList = LogSystem.ReadByteLog(splitter);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            startBtn.Enabled = false;
            finishBtn.Enabled = true;
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            startTimeLabel.Text = "NULL";
            startBtn.Enabled = true;
            finishBtn.Enabled = false;
        }
    }
}
