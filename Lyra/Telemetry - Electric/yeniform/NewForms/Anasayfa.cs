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
        public delegate void TriggerFront();
        MQTT mqttObj = new MQTT(MACROS.newSubTopic); //LYRADATA topic'ine bağlanacak MQTT nesnesini oluştur.
        public static SerialPortCOMRF serialPortCOMRF = new SerialPortCOMRF();// NRF'e veri gönderecek seri port nesnesini oluştur.
        public static NewMQTT mqttobj = new NewMQTT("vehicle_to_interface", MACROS.aesk_IP);
        string splitter = "aesk\n";
        List<string> lineList;
        SerialPort serialPort = new SerialPort();
        public Anasayfa()
        {
            InitializeComponent();

            TextBox[] textBoxs = {startTimeLabel, socLabel, batCurLabel, batConsLabel,
             setVelocityLabel, actVelocityLabel, errorsLabel, driveStatusLabel};

        }
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion

        #region .. code for Flucuring ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
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
            #region doubleBuffer
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(tableLayoutPanel2);
            SetDoubleBuffered(tableLayoutPanel3);
            SetDoubleBuffered(tableLayoutPanel4);
            SetDoubleBuffered(tableLayoutPanel5);
            SetDoubleBuffered(tableLayoutPanel6);
            SetDoubleBuffered(tableLayoutPanel7);
            SetDoubleBuffered(tableLayoutPanel8);
            SetDoubleBuffered(tableLayoutPanel9);
            SetDoubleBuffered(tableLayoutPanel10);
            SetDoubleBuffered(tableLayoutPanel11);
            SetDoubleBuffered(tableLayoutPanel12);
            SetDoubleBuffered(tableLayoutPanel13);
            SetDoubleBuffered(tableLayoutPanel14);
            SetDoubleBuffered(finishBtn);
            SetDoubleBuffered(mqttConnectBtn);
            SetDoubleBuffered(mqttDisconnectBtn);
            SetDoubleBuffered(openGUILogBtn);
            SetDoubleBuffered(openSDLogBtn);
            SetDoubleBuffered(portConnectBtn);
            SetDoubleBuffered(portDisconnectBtn);
            SetDoubleBuffered(startBtn);
            SetDoubleBuffered(startLogBtn);
            SetDoubleBuffered(stopLogBtn);
            #endregion

        }
        private void portConnectBtn_Click(object sender, EventArgs e)
        {
            //LogSystem.ExtractSDLog(lineList); //TAŞINACAK
            serialPortCOMRF.SerialPortInit(serialPort);
            serialPortCOMRF.ConnectSerialPort(portsListBox.SelectedItem.ToString());
        }

        private void portsListBox_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portsListBox.Items.AddRange(ports);
        }

        private void mqttConnectBtn_Click(object sender, EventArgs e)
        {

            AFront.AccessFront += UITools.ChangeUI;
            mqttWorker.RunWorkerAsync();
        }

        private void mqttDisconnectBtn_Click(object sender, EventArgs e)
        {
            mqttobj.Disconnect();
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

        private void mqttWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (mqttobj.ConnectSubscribe())
            {
                MessageBox.Show("Bağlanıldı!");
                mqttDisconnectBtn.Enabled = true;
                mqttConnectBtn.Enabled = false;
                startLogBtn.Enabled = true;
                portConnectBtn.Enabled = false;
            }
        }
    }
}
