using System.Diagnostics;

namespace telemetry_hydro.Variables
{
    public struct SectorAndTourDatas
    {
        /*
        public static Stopwatch sector1_sure = new Stopwatch();
        public static Stopwatch sector2_sure = new Stopwatch();
        public static Stopwatch sector3_sure = new Stopwatch();
        public static Stopwatch sector4_sure = new Stopwatch();

        public static string sector_name;

        public static uint gidilen_yol_gps_sector_1_u32;
        public static uint gidilen_yol_gps_sector_2_u32;
        public static uint gidilen_yol_gps_sector_3_u32;
        public static uint gidilen_yol_gps_sector_4_u32;
        public static uint gidilen_yol_gps_sector_T_u32;

        public static uint sector_1_ortalama_hiz_gps => (uint)((double)(gidilen_yol_gps_sector_1_u32 / sector1_sure.Elapsed.TotalSeconds) * MACROS.mstokmh);
        public static uint sector_3_ortalama_hiz_gps => (uint)((double)(gidilen_yol_gps_sector_3_u32 / sector3_sure.Elapsed.TotalSeconds) * MACROS.mstokmh);
        public static uint sector_2_ortalama_hiz_gps => (uint)((double)(gidilen_yol_gps_sector_2_u32 / sector2_sure.Elapsed.TotalSeconds) * MACROS.mstokmh);
        public static uint sector_4_ortalama_hiz_gps => (uint)((double)(gidilen_yol_gps_sector_4_u32 / sector4_sure.Elapsed.TotalSeconds) * MACROS.mstokmh);
        public static uint sector_T_ortalama_hiz_gps => (uint)((double)(gidilen_yol_gps_sector_T_u32 / Timers.Anlik_tur_süresi.Elapsed.TotalSeconds) * MACROS.mstokmh);

        public static uint gidilen_yol_vcu_sector_1_u32;
        public static uint gidilen_yol_vcu_sector_2_u32;
        public static uint gidilen_yol_vcu_sector_3_u32;
        public static uint gidilen_yol_vcu_sector_4_u32;
        public static uint gidilen_yol_vcu_sector_T_u32;

        public static float consumption_sector_1_f32;
        public static float consumption_sector_2_f32;
        public static float consumption_sector_3_f32;
        public static float consumption_sector_4_f32;
        public static float consumption_sector_T_f32;

        public static float consumption_out_sector_1_f32;
        public static float consumption_out_sector_2_f32;
        public static float consumption_out_sector_3_f32;
        public static float consumption_out_sector_4_f32;
        public static float consumption_out_sector_T_f32;

        public static uint sector_1_ortalama_hiz_vcu => (uint)((double)(gidilen_yol_vcu_sector_1_u32 / sector1_sure.Elapsed.TotalSeconds) * MACROS.mstokmh);
        public static uint sector_2_ortalama_hiz_vcu => (uint)((double)(gidilen_yol_vcu_sector_2_u32 / sector2_sure.Elapsed.TotalSeconds) * MACROS.mstokmh);
        public static uint sector_3_ortalama_hiz_vcu => (uint)((double)(gidilen_yol_vcu_sector_3_u32 / sector3_sure.Elapsed.TotalSeconds) * MACROS.mstokmh);
        public static uint sector_4_ortalama_hiz_vcu => (uint)((double)(gidilen_yol_vcu_sector_4_u32 / sector4_sure.Elapsed.TotalSeconds) * MACROS.mstokmh);
        public static uint sector_T_ortalama_hiz_vcu => (uint)((double)(gidilen_yol_vcu_sector_T_u32 / Timers.Anlik_tur_süresi.Elapsed.TotalSeconds) * MACROS.mstokmh);

        public static object[] turAtDatas => new object[9] {Timers.currentTour, sector_name, Timers.Anlik_tur_süresi.Elapsed.ToString(MACROS.TimeStringFormat), SectorAndTourDatas.gidilen_yol_vcu_sector_T_u32,
                                   SectorAndTourDatas.gidilen_yol_gps_sector_T_u32, SectorAndTourDatas.sector_T_ortalama_hiz_vcu, SectorAndTourDatas.sector_T_ortalama_hiz_gps, consumption_out_sector_T_f32, consumption_sector_T_f32};
        public static object[] sector1Datas => new object[9] {Timers.currentTour, sector_name, SectorAndTourDatas.sector1_sure.Elapsed.ToString(MACROS.TimeStringFormat),
                                           SectorAndTourDatas.gidilen_yol_vcu_sector_1_u32, SectorAndTourDatas.gidilen_yol_gps_sector_1_u32,
                                           SectorAndTourDatas.sector_1_ortalama_hiz_vcu, SectorAndTourDatas.sector_1_ortalama_hiz_gps, consumption_out_sector_1_f32, consumption_sector_1_f32};
        public static object[] sector2Datas => new object[9] {Timers.currentTour, sector_name, SectorAndTourDatas.sector2_sure.Elapsed.ToString(MACROS.TimeStringFormat),
                                           SectorAndTourDatas.gidilen_yol_vcu_sector_2_u32, SectorAndTourDatas.gidilen_yol_gps_sector_2_u32,
                                           SectorAndTourDatas.sector_2_ortalama_hiz_vcu, SectorAndTourDatas.sector_2_ortalama_hiz_gps, consumption_out_sector_2_f32, consumption_sector_2_f32};
        public static object[] sector3Datas => new object[9] {Timers.currentTour, sector_name, SectorAndTourDatas.sector3_sure.Elapsed.ToString(MACROS.TimeStringFormat),
                                           SectorAndTourDatas.gidilen_yol_vcu_sector_3_u32, SectorAndTourDatas.gidilen_yol_gps_sector_3_u32,
                                           SectorAndTourDatas.sector_3_ortalama_hiz_vcu, SectorAndTourDatas.sector_3_ortalama_hiz_gps, consumption_out_sector_3_f32, consumption_sector_3_f32};

        public static object[] sector4Datas => new object[9] {Timers.currentTour, sector_name, SectorAndTourDatas.sector4_sure.Elapsed.ToString(MACROS.TimeStringFormat),
                                           SectorAndTourDatas.gidilen_yol_vcu_sector_4_u32, SectorAndTourDatas.gidilen_yol_gps_sector_4_u32,
                                           SectorAndTourDatas.sector_4_ortalama_hiz_vcu, SectorAndTourDatas.sector_4_ortalama_hiz_gps, consumption_out_sector_4_f32, consumption_sector_4_f32};
    */
     }
};
            
            
          

