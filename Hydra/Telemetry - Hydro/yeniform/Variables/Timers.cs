using System;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace telemetry_hydro.Variables
{
    public class Timers
    {
        private static TimeSpan _kalan_sure;
        private static TimeSpan _gecen_sure;
        public static int currentTour = 1;
        public Timer myRaceTimer;
        private static DateTime race_start_time;
        private static DateTime race_stop_time;
        private DateTime tur_start_time;
        public static byte ort_hiz => (byte)((Driver.odometer_u32 / Timers.Gecen_süre.TotalSeconds) * MACROS.mstokmh);
        public static TimeSpan Kalan_süre
        {
            get
            {
                if (!Logs._IsLog)
                {
                    return (race_stop_time - DateTime.Now);
                }
                else
                {
                    return _kalan_sure;
                }
            }
            set
            {
                _kalan_sure = value;
            }
        }
            
        public static TimeSpan Gecen_süre
        {
            get
            {
                if (!Logs._IsLog)
                {
                    return (DateTime.Now - race_start_time);;
                }
                else
                {
                    return _gecen_sure;
                }
            }
            set
            {
                _gecen_sure = value;
            }
        }
        static public TimeSpan en_hizli_tur_suresi = new TimeSpan(1, 05, 00);
        public static Stopwatch Anlik_tur_süresi;
        public static Stopwatch önceki_tur_sure;
        public static TimeSpan Ortalama_tur_süresi => new TimeSpan(Gecen_süre.Ticks/ currentTour);
        public static bool IsFastestLaps => Anlik_tur_süresi.Elapsed.TotalSeconds < en_hizli_tur_suresi.TotalSeconds;

        public static string log_datas_time => Timers.currentTour.ToString() + '$' + SectorAndTourDatas.sector_name + '$' + Gecen_süre.ToString(MACROS.TimeStringFormat) + '$' + Kalan_süre.ToString(MACROS.TimeStringFormat) + '$' + 
                                               Anlik_tur_süresi.Elapsed.ToString(MACROS.TimeStringFormat) +  '$' + en_hizli_tur_suresi.ToString(MACROS.TimeStringFormat) + '$' + 
                                               Ortalama_tur_süresi.ToString(MACROS.TimeStringFormat) + '$' + önceki_tur_sure.Elapsed.ToString(MACROS.TimeStringFormat) + '$' + 
                                               SectorAndTourDatas.sector1_sure.Elapsed.ToString(MACROS.TimeStringFormat) + '$' + SectorAndTourDatas.sector2_sure.Elapsed.ToString(MACROS.TimeStringFormat) + '$' + 
                                               SectorAndTourDatas.sector3_sure.Elapsed.ToString(MACROS.TimeStringFormat) + '$' + SectorAndTourDatas.sector4_sure.Elapsed.ToString(MACROS.TimeStringFormat) + '$';



        public static byte hedef_hiz =>(byte)((kalan_yol/ Timers.Kalan_süre.TotalSeconds) * MACROS.mstokmh);
        public static uint kalan_yol => (MACROS.toplam_yol - Driver.odometer_u32);
     
        public  Timers()
        {
            önceki_tur_sure = new Stopwatch();
            Anlik_tur_süresi = new Stopwatch();
            race_start_time = DateTime.Now;
            race_stop_time = race_start_time.Add(new TimeSpan(1, 05, 01));
            tur_start_time = race_start_time;
            Anlik_tur_süresi.Start();
            currentTour = 1;
        }

        public void TurAt()
        {
            Anlik_tur_süresi.Restart();
            currentTour++;
        }
    }
}
