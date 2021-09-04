using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
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
        public static SerialRF serialRF = new SerialRF();
        public static NewMQTT mqttobj = new NewMQTT("vehicle_to_interface", "LYRADATA", MACROS.aesk_IP);
        string splitter = "aesk\n";
        List<string> lineList;
        ComproUI comproUIII;
        System.Timers.Timer loggTimer = new System.Timers.Timer(50);

        public Anasayfa()
        {
            InitializeComponent();
            TextBox[] textBoxs = {startTimeLabel, socLabel, batCurLabel, batConsLabel,
             setVelocityLabel, actVelocityLabel, errorsLabel, driveStatusLabel};
            UITools.Anasayfa.actVelocityLabel = actVelocityLabel;
            UITools.Anasayfa.batConsLabel = batConsLabel;
            UITools.Anasayfa.batCurLabel = batCurLabel;
            UITools.Anasayfa.errorsLabel = errorsLabel;
            UITools.Anasayfa.socLabel = socLabel;
            UITools.Anasayfa.startTimeLabel = startTimeLabel;
            UITools.Anasayfa.setVelocityLabel = setVelocityLabel;
            UITools.Anasayfa.driveStatusLabel = driveStatusLabel;
            UITools.Anasayfa.setTorqueBox = setTorqueBox;
            UITools.Anasayfa.tcuMinLabel = tcuMinLabel;
            UITools.Anasayfa.sdCardStaBox = sdCardStatBox;
            UITools.Anasayfa.mqttConnectBtn = mqttConnectBtn;
            UITools.Anasayfa.mqttDisconnectBtn = mqttDisconnectBtn;
            UITools.Anasayfa.startLogBtn = startLogBtn;
            UITools.Anasayfa.resetBoardBtn = resetBoardButton;
            UITools.Anasayfa.portConnectBtn = portConnectBtn;
            UITools.Anasayfa.lastLapConsBox = lastLapConsBox;
            UITools.Anasayfa.lapView = lapView;
            TimeOperations.avgLapBox = avgLapTimeBox;
            TimeOperations.currentLapBox = currentLapBox;
            TimeOperations.fastestLapBox = fastestLapBox;
            TimeOperations.lastLapBox = lastLapBox;
            comproUIII = new ComproUI(0x31, ComproUI.TELEMETRI, 24);
        }

        private void LoggTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            LogSystem.WriteStringLog();
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
            startLogBtn.Enabled = false;
            #region portWatcher
            var watcher = new ManagementEventWatcher();
            var watcher2 = new ManagementEventWatcher();
            var query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            var query2 = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            watcher2.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
            watcher.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
            watcher.Query = query;
            watcher2.Query = query2;
            watcher.Start();
            watcher2.Start();
            #endregion
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
            SetDoubleBuffered(resetBoardButton);
            SetDoubleBuffered(openSDLogBtn);
            SetDoubleBuffered(portConnectBtn);
            SetDoubleBuffered(portDisconnectBtn);
            SetDoubleBuffered(startBtn);
            SetDoubleBuffered(startLogBtn);
            SetDoubleBuffered(stopLogBtn);
            SetDoubleBuffered(tableLayoutPanel15);
            SetDoubleBuffered(tableLayoutPanel16);
            SetDoubleBuffered(tableLayoutPanel17);
            SetDoubleBuffered(tableLayoutPanel18);
            SetDoubleBuffered(tableLayoutPanel19);
            SetDoubleBuffered(tableLayoutPanel20);
            SetDoubleBuffered(tableLayoutPanel21);
            SetDoubleBuffered(tableLayoutPanel22);
            SetDoubleBuffered(tableLayoutPanel23);
            SetDoubleBuffered(label1);
            SetDoubleBuffered(label2);
            SetDoubleBuffered(label3);
            SetDoubleBuffered(label4);
            SetDoubleBuffered(label5);
            SetDoubleBuffered(label6);
            SetDoubleBuffered(label7);
            SetDoubleBuffered(label8);
            SetDoubleBuffered(label9);
            SetDoubleBuffered(label10);
            SetDoubleBuffered(label11);
            SetDoubleBuffered(label12);
            SetDoubleBuffered(label13);
            SetDoubleBuffered(label14);
            SetDoubleBuffered(label15);
            SetDoubleBuffered(label16);
            SetDoubleBuffered(label17);
            SetDoubleBuffered(lastLapConsBox);
            SetDoubleBuffered(lastLapBox);
            SetDoubleBuffered(lastLapAvgSpeedBox);
            SetDoubleBuffered(lastLapConsBox);
            SetDoubleBuffered(setTorqueBox);
            SetDoubleBuffered(currentLapBox);
            SetDoubleBuffered(sdCardStatBox);
            SetDoubleBuffered(lapView);
            #endregion

        }


        private void portsListBox_Click(object sender, EventArgs e)
        {

        }

        private void mqttConnectBtn_Click(object sender, EventArgs e)
        {
            mqttWorker.RunWorkerAsync();
        }

        private void mqttDisconnectBtn_Click(object sender, EventArgs e)
        {
            mqttobj.Disconnect();
        }

        private void startLogBtn_Click(object sender, EventArgs e)
        {
            loggTimer.Elapsed += LoggTimer_Elapsed;
            if (LogSystem.StartLog(loggTimer) == true)
            {
                startLogBtn.Enabled = false;
                stopLogBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Uzantı seçilemedi.");
            }
        }

        private void stopLogBtn_Click(object sender, EventArgs e)
        {
            LogSystem.StopLog(loggTimer);
            loggTimer.Elapsed -= LoggTimer_Elapsed;
            startLogBtn.Enabled = true;
            stopLogBtn.Enabled = false;
        }

        private void openSDLogBtn_Click(object sender, EventArgs e)
        {
            lineList = LogSystem.ReadByteLog(splitter);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            UITools.Anasayfa.startTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            UITools.Telemetry2021.lapCount.Text = (DataVCU.lapCounter+1).ToString();
            UITools.Anasayfa.lapView.Items.Add(new ListViewItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].ForeColor = Color.White;
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].Font = new Font("Century Gothic", 14);

            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].Text = (DataVCU.lapCounter+1).ToString();
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems[1].Text = DateTime.Now.ToString("HH:mm:ss");
            startBtn.Enabled = false;
            finishBtn.Enabled = true;
            DataBMS.startFinishConBuffer = DataBMS.cons_u16;
            UITools.Telemetry2021.lapPlusButton.Enabled = true;
            TimeOperations.StartRace();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            finishBtn.Enabled = false;
            //DataBMS.startFinishCon = DataBMS.cons_u16 - DataBMS.startFinishConBuffer;
            TimeOperations.FinishRace();
            //MessageBox.Show($"Toplam tüketim: {DataBMS.startFinishCon} Wh");
        }

        private void mqttWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (mqttobj.ConnectSubscribe())
            {
                AFront.AccessFront += UITools.ChangeUI;
                mqttDisconnectBtn.Enabled = true;
                mqttConnectBtn.Enabled = false;
                startLogBtn.Enabled = true;
                resetBoardButton.Enabled = true;
            }
        }

        private void mqttWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(mqttobj.connected_flag == true)
            {
                UITools.PIDForm.logWriter.WriteLine("MQTT'ye bağlanıldı.");
                UITools.Telemetry2021.graphTimer.Start();
                UITools.Telemetry2021.activeChannelLabel.Text = "MQTT";
            }
        }

        private void mqttWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void resetBoardButton_Click(object sender, EventArgs e)
        {
            comproUIII.message = new byte[] { 0 };
            comproUIII.msg_size = 1;
            comproUIII.msg_index = 2;
            comproUIII.source_msg_id = (byte)ComproUI.MSG_ID.RESET_TELEMETRY;
            comproUIII.CreateBuffer();
            mqttobj.client.Publish("interface_to_vehicle", comproUIII.buffer);
        }

        private void portsListBox_DoubleClick(object sender, EventArgs e)
        {
            portsListBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            portsListBox.Items.AddRange(ports);
        }

        private void portsListBox_MouseHover(object sender, EventArgs e)
        {
            portConnectTip.SetToolTip(portsListBox, "Portları yenilemek için çift tıklayın");
        }

        private void watcher_EventArrived(object sender, EventArgs e)
        {
            portsListBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            portsListBox.Items.AddRange(ports);
        }

        private void portConnectBtn_Click_1(object sender, EventArgs e)
        {
            //LogSystem.ExtractSDLog(lineList); //TAŞINACAK
            serialRF.SyncChar = 0xAB;
            if (portsListBox.SelectedItem != null)
            {
                if(serialRF.Connect(portsListBox.SelectedItem.ToString(), 9600) == true)
                {
                    portConnectBtn.Enabled = false;
                    portDisconnectBtn.Enabled = true;
                    AFront.AccessFront += UITools.ChangeUI;
                    UITools.Telemetry2021.activeChannelLabel.Text = "RF";
                }
            }
            else
            {
                MessageBox.Show("Portu seçiniz.");
            }
        }

        private void portDisconnectBtn_Click(object sender, EventArgs e)
        {
            serialRF.Disconnect();
            portConnectBtn.Enabled = true;
            portDisconnectBtn.Enabled = false;
            UITools.Telemetry2021.activeChannelLabel.Text = "None";
            AFront.AccessFront -= UITools.ChangeUI;
        }
    }
}
    