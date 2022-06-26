using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using Telemetri.Variables;

namespace telemetry_hydro.Variables
{
    public static class TimeOperations
    {
        public static System.Timers.Timer raceTimer = new System.Timers.Timer(1);
        public static System.Timers.Timer countdownTimer = new System.Timers.Timer(1000);
        public static Stopwatch currentLapTime = new Stopwatch();
        public static Stopwatch elapsedTime = new Stopwatch();
        public static TimeSpan lastLapTime = new TimeSpan();
        public static TimeSpan fastestLapTime = new TimeSpan(0, 0, 59, 59, 59);
        public static TimeSpan avgLapTime = new TimeSpan();
        public static TimeSpan logTime = new TimeSpan();
        public static List<TimeSpan> laps = new List<TimeSpan>();
        public static List<int> avgSpeedBuffer = new List<int>();
        public static int countdownHours =   01;
        public static int countdownMinutes = 05;
        public static int countdownSeconds = 00;
        public static int maxSpeed = 0;
        
        // MUTLAKA IMPLEMENTATION YAPIN !!
        public static TextBox currentLapBox;
        public static TextBox lastLapBox;
        public static TextBox fastestLapBox;
        public static TextBox avgLapBox;
        public static TextBox avgSpeedBox;
        public static TextBox timeLeftBox;
        public static TextBox elapsedTimeBox;
        // MUTLAKA IMPLEMENTATION YAPIN !!

        public static void StartRace()
        {
            currentLapBox.Text = DateTime.Now.ToString("T");
            raceTimer.Elapsed += RaceTimer_Elapsed;
            countdownTimer.Elapsed += CountdownTimer_Elapsed;
            countdownTimer.Start();
            raceTimer.Start();
            currentLapTime.Start();
            elapsedTime.Start();
        }

        private static void CountdownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (countdownSeconds == 0)
            {
                countdownSeconds = 59;
                if (countdownMinutes == 0)
                {
                    countdownMinutes = 59;
                    if (countdownHours == 0)
                    {
                        //RACE FINISHED
                    }
                    else
                    {
                        countdownHours--;
                    }
                }
                else
                {
                    countdownMinutes--;
                }
            }
            else
            {
                countdownSeconds--;
            }
            avgSpeedBuffer.Add(DataVCU.speed_set_rpm_s16);
            avgSpeedBox.Text = avgSpeedBuffer.Average().ToString("00.0") + " km/h";
            timeLeftBox.Text = countdownHours.ToString("00") + ":" + countdownMinutes.ToString("00") + ":" + countdownSeconds.ToString("00");
            elapsedTimeBox.Text = elapsedTime.Elapsed.ToString("hh\\:mm\\:ss");
        }

        private static void RaceTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            currentLapBox.Text = currentLapTime.Elapsed.ToString("mm\\:ss\\.ff");
        }
        public static void LapFinish()
        {
            DataGPS.lapCounter++;
            currentLapTime.Stop();
            fastestLapTime = currentLapTime.Elapsed < fastestLapTime ? currentLapTime.Elapsed : fastestLapTime;
            lastLapTime = currentLapTime.Elapsed;
            laps.Add(lastLapTime);
            lastLapBox.Text = lastLapTime.ToString("mm\\:ss\\.ff");
            fastestLapBox.Text = fastestLapTime.ToString("mm\\:ss\\.ff");
            avgLapTime = new TimeSpan(Convert.ToInt64(laps.Average(t => t.Ticks)));
            avgLapBox.Text = avgLapTime.ToString("mm\\:ss\\.ff");

            currentLapTime.Restart();
        }
        public static void FinishRace()
        {
            currentLapTime.Reset();
            currentLapBox.Text = "00:00:00";
            countdownTimer.Elapsed -= CountdownTimer_Elapsed;
            raceTimer.Stop();
        }
    }
}
