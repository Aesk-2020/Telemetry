using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telemetry_hydro.Variables;

namespace telemetry_hydro
{
    public partial class LogBar : Form
    {
        private bool playPause = false;

        public LogBar()
        {
            InitializeComponent();
        }

        private void LogBar_Load(object sender, EventArgs e)
        {
            LogSystem.logPlayTimer.Interval = 20;
            LogSystem.logPlayTimer.Elapsed += LogPlayTimer_Elapsed;
        }

        private void LogPlayTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            logPlayerStick.Value++;
        }

        private void logPlayBtn_Click(object sender, EventArgs e)
        {
            if (playPause == false)
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

        private void log10secRewBtn_Click(object sender, EventArgs e)
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

        private void log10secForwBtn_Click(object sender, EventArgs e)
        {
            if (logPlayerStick.Value + 10 > logPlayerStick.Maximum)
            {
                logPlayerStick.Value = logPlayerStick.Maximum;
            }
            else
            {
                logPlayerStick.Value += 10;
            }
        }

        private void logSpeedDownBtn_Click(object sender, EventArgs e)
        {
            if (LogSystem.logPlayTimer.Interval < 1000)
            {
                LogSystem.logPlayTimer.Interval += 10;
            }
        }

        private void logSpeedUpBtn_Click(object sender, EventArgs e)
        {
            if (LogSystem.logPlayTimer.Interval > 10)
            {
                LogSystem.logPlayTimer.Interval -= 10;
            }
        }

        private void logPlayerStick_ValueChanged(object sender, decimal value)
        {
            logPlayerStick.Maximum = LogSystem.lineList.Count - 1;
            int indeks = Convert.ToInt32(logPlayerStick.Value);
            LogSystem.ParseStringLog(indeks);
        }
    }
}
