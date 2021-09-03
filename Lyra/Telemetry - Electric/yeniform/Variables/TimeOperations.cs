using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;

namespace Telemetri.Variables
{
    public static class TimeOperations
    {
        public static System.Timers.Timer raceTimer = new System.Timers.Timer(1);
        public static Stopwatch currentLapTime = new Stopwatch();
        public static TimeSpan lastLapTime = new TimeSpan();
        public static TimeSpan fastestLapTime = new TimeSpan(0, 0, 59, 59, 59);
        public static TimeSpan avgLapTime = new TimeSpan();
        public static List<TimeSpan> laps = new List<TimeSpan>();
        
        // MUTLAKA IMPLEMENTATION YAPIN !!
        public static TextBox currentLapBox;
        public static TextBox lastLapBox;
        public static TextBox fastestLapBox;
        public static TextBox avgLapBox;
        // MUTLAKA IMPLEMENTATION YAPIN !!

        public static void StartRace()
        {
            raceTimer.Elapsed += RaceTimer_Elapsed;
            raceTimer.Start();
            currentLapTime.Start();
        }

        private static void RaceTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems[2].Text = currentLapTime.Elapsed.ToString("mm\\:ss\\.ff");
        }
        public static void LapFinish()
        {
            currentLapTime.Stop();
            UITools.Anasayfa.lapView.Items.Add(new ListViewItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].ForeColor = Color.White;
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].Font = new Font("Century Gothic", 14);

            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].Text = (DataVCU.lapCounter + 1).ToString();
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems.Add(new ListViewItem.ListViewSubItem());
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter].SubItems[1].Text = DateTime.Now.ToString("HH:mm:ss");
            fastestLapTime = currentLapTime.Elapsed < fastestLapTime ? currentLapTime.Elapsed : fastestLapTime;
            lastLapTime = currentLapTime.Elapsed;
            laps.Add(lastLapTime);
            lastLapBox.Text = lastLapTime.ToString("mm\\:ss\\.ff");
            fastestLapBox.Text = fastestLapTime.ToString("mm\\:ss\\.ff");
            avgLapTime = new TimeSpan(Convert.ToInt64(laps.Average(t => t.Ticks)));
            UITools.Anasayfa.lapView.Items[(int)DataVCU.lapCounter-1].SubItems[3].Text = (MACROS.KORFEZ_UZUNLUK_METRE / TimeOperations.currentLapTime.Elapsed.TotalSeconds * 3.6).ToString("00.0") + " km/h";
            avgLapBox.Text = avgLapTime.ToString("mm\\:ss\\.ff");

            currentLapTime.Restart();
        }
        public static void FinishRace()
        {
            currentLapTime.Reset();
            currentLapBox.Text = "00:00:00";
            raceTimer.Stop();
        }
    }
}
