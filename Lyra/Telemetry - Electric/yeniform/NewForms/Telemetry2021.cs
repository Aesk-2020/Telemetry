using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Telemetri.Variables;
using Telemetri.NewForms;

namespace Telemetri.NewForms
{
    public partial class Telemetry2021 : Form
    {
        public Telemetry2021()
        {
            InitializeComponent();
            FormManagement.openChildForm(new Anasayfa(), panelChildForm);
            LogSystem.logPlayTimer.Tick += LogPlayTimer_Tick;
            Button[] buttons = { homeButton, mapButton, motordrButton, batteryButton, pidTuningBtn, settingsButton, mqttButton };
            TextBox[] textBoxs = { activeChannelLabel, mqttPingLabel };
            UITools.Telemetry2021.buttonList.AddRange(buttons);
            UITools.Telemetry2021.forms.Add("Anasayfa", new Anasayfa());
            UITools.Telemetry2021.forms.Add("BMS_Form", new BMS_Form());
            UITools.Telemetry2021.forms.Add("Driver_Form", new Driver_Form());
            UITools.Telemetry2021.forms.Add("Map", new Map());
            UITools.Telemetry2021.forms.Add("MQTTdeneme", new MQTTdeneme());
            UITools.Telemetry2021.forms.Add("PIDTuningForm", new PIDTuningForm());
            UITools.Telemetry2021.forms.Add("TestForm", new TestForm());
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
        private void Telemetry2021_Load(object sender, EventArgs e)
        {
            #region doubleBuffer
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(tableLayoutPanel2);
            SetDoubleBuffered(tableLayoutPanel3);
            SetDoubleBuffered(tableLayoutPanel4);
            SetDoubleBuffered(tableLayoutPanel5);
            #endregion
        }

        private void LogPlayTimer_Tick(object sender, EventArgs e)
        {
            logPlayerStick.Value++;
        }

        bool playPause = false; //oynatma durdurma butonu, false ise butona basıldığında oynatma kodu çalışır.

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(UITools.Telemetry2021.forms["Anasayfa"], panelChildForm);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(UITools.Telemetry2021.forms["Map"], panelChildForm);
        }

        private void btnBattery_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(UITools.Telemetry2021.forms["BMS_Form"], panelChildForm);
        }

        private void btnMotorDriver_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(UITools.Telemetry2021.forms["Driver_Form"], panelChildForm);
            pidTuningBtn.Visible = !pidTuningBtn.Visible;
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void mqttButton_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(UITools.Telemetry2021.forms["MQTTdeneme"], panelChildForm);
        }

        
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Telemetry2021.ActiveForm.Close();
        }

        private void lapPlusBtn_Click(object sender, EventArgs e)
        {
            lapCntLabel.Text = (Convert.ToDecimal(lapCntLabel.Text) + 1).ToString();
        }

        private void lapMinusBtn_Click(object sender, EventArgs e)
        {
            if(lapCntLabel.Text != "0") lapCntLabel.Text = (Convert.ToDecimal(lapCntLabel.Text) - 1).ToString();
        }

        private void LapResetBtn_Click(object sender, EventArgs e)
        {
            lapCntLabel.Text = "0";
        }

        private void logPlayBtn_Click(object sender, EventArgs e)
        {
            if(playPause == false)
            {
                logPlayBtn.Image = pauseResume.Images[0];         //buton görseli pause
                LogSystem.logPlayTimer.Start(); playPause = true; //play'e basıldı. flag'i değiştir
            }
            else
            {
                logPlayBtn.Image = pauseResume.Images[1];         //buton görseli play
                LogSystem.logPlayTimer.Stop(); playPause = false; //pause'a basıldı. flag'i değiştir
            }
        }

        private void logPlayerStick_ValueChanged(object sender, decimal value)
        {
            if (LogSystem.isLogSolved)
            {
                logPlayerStick.Maximum = LogSystem.lineList.Count - 1;
                int indexa = Convert.ToInt32(logPlayerStick.Value);
                LogSystem.ParseStringData(LogSystem.lineList[indexa]);
            }
        }

        private void log10secForwBtn_Click(object sender, EventArgs e)
        {
            if (LogSystem.isLogSolved)
            {
                if(logPlayerStick.Value + 10 > logPlayerStick.Maximum)
                {
                    logPlayerStick.Value = logPlayerStick.Maximum;
                }
                else
                {
                    logPlayerStick.Value += 10;
                }
            }
        }

        private void log10secRewBtn_Click(object sender, EventArgs e)
        {
            if (LogSystem.isLogSolved)
            {
                if (logPlayerStick.Value - 10 < logPlayerStick.Minimum)
                {
                    logPlayerStick.Value = logPlayerStick.Minimum;
                }
                else
                {
                    logPlayerStick.Value -= 10;
                }
            }
        }

        private void logSpeedUpBtn_Click(object sender, EventArgs e)
        {
            if(LogSystem.logPlayTimer.Interval > 10)
            {
                LogSystem.logPlayTimer.Interval -= 10;
            }
        }

        private void logSpeedDownBtn_Click(object sender, EventArgs e)
        {
            if (LogSystem.logPlayTimer.Interval < 1000)
            {
                LogSystem.logPlayTimer.Interval += 10;
            }
        }

        private void pidTuningBtn_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(UITools.Telemetry2021.forms["PIDTuningForm"], panelChildForm);
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(UITools.Telemetry2021.forms["TestForm"], panelChildForm);
        }

        private void Telemetry2021_FormClosing(object sender, FormClosingEventArgs e)
        {
            AFront.AccessFront -= UITools.ChangeUI;
        }
    }
}
