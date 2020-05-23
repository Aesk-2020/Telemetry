using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace yeniform.Variables
{
    public class Logs
    {
        public int history_shower;
        public int hold_history_shower;
        public string anlik_tur_sure;
        public string sector_1_sure;
        public string sector_2_sure;
        public string sector_3_sure;
        public string sector_4_sure;

        public uint sector_1_ortalama_hiz_vcu => (uint)((double)(SectorAndTourDatas.gidilen_yol_vcu_sector_1_u32 / TimeSpan.Parse(sector_1_sure).TotalSeconds) * MACROS.mstokmh);
        public uint sector_2_ortalama_hiz_vcu => (uint)((double)(SectorAndTourDatas.gidilen_yol_vcu_sector_2_u32 / TimeSpan.Parse(sector_2_sure).TotalSeconds) * MACROS.mstokmh);
        public uint sector_3_ortalama_hiz_vcu => (uint)((double)(SectorAndTourDatas.gidilen_yol_vcu_sector_3_u32 / TimeSpan.Parse(sector_3_sure).TotalSeconds) * MACROS.mstokmh);
        public uint sector_4_ortalama_hiz_vcu => (uint)((double)(SectorAndTourDatas.gidilen_yol_vcu_sector_4_u32 / TimeSpan.Parse(sector_4_sure).TotalSeconds) * MACROS.mstokmh);
        public uint sector_T_ortalama_hiz_vcu => (uint)((double)(SectorAndTourDatas.gidilen_yol_vcu_sector_T_u32 / TimeSpan.Parse(anlik_tur_sure).TotalSeconds) * MACROS.mstokmh);

        public uint sector_1_ortalama_hiz_gps => (uint)((double)(SectorAndTourDatas.gidilen_yol_gps_sector_1_u32 /  TimeSpan.Parse(sector_1_sure).TotalSeconds) * MACROS.mstokmh);
        public uint sector_2_ortalama_hiz_gps => (uint)((double)(SectorAndTourDatas.gidilen_yol_gps_sector_2_u32 /  TimeSpan.Parse(sector_2_sure).TotalSeconds) * MACROS.mstokmh);
        public uint sector_3_ortalama_hiz_gps => (uint)((double)(SectorAndTourDatas.gidilen_yol_gps_sector_3_u32 / TimeSpan.Parse(sector_3_sure).TotalSeconds) * MACROS.mstokmh);
        public uint sector_4_ortalama_hiz_gps => (uint)((double)(SectorAndTourDatas.gidilen_yol_gps_sector_4_u32 / TimeSpan.Parse(sector_4_sure).TotalSeconds) * MACROS.mstokmh);
        public uint sector_T_ortalama_hiz_gps => (uint)((double)(SectorAndTourDatas.gidilen_yol_gps_sector_T_u32 / TimeSpan.Parse(anlik_tur_sure).TotalSeconds) * MACROS.mstokmh);
        public string en_hizli_tur_sure;                         
        public string ortalama_tur_sure;
        public string onceki_tur_sure;

        public object[] HturAtDatas => new object[8] {Timers.currentTour, "ST", anlik_tur_sure, SectorAndTourDatas.gidilen_yol_vcu_sector_T_u32, 
                                   SectorAndTourDatas.gidilen_yol_gps_sector_T_u32, sector_T_ortalama_hiz_vcu, sector_T_ortalama_hiz_gps, SectorAndTourDatas.consumption_sector_T_f32};

        public object[] Hsector1Datas => new object[8] {Timers.currentTour, "S1", sector_1_sure,
                                           SectorAndTourDatas.gidilen_yol_vcu_sector_1_u32, SectorAndTourDatas.gidilen_yol_gps_sector_1_u32,
                                           sector_1_ortalama_hiz_vcu, sector_1_ortalama_hiz_gps, SectorAndTourDatas.consumption_sector_1_f32};

        public object[] Hsector2Datas => new object[8] {Timers.currentTour, "S2", sector_2_sure,
                                           SectorAndTourDatas.gidilen_yol_vcu_sector_2_u32, SectorAndTourDatas.gidilen_yol_gps_sector_2_u32,
                                           sector_2_ortalama_hiz_vcu, sector_2_ortalama_hiz_gps, SectorAndTourDatas.consumption_sector_2_f32};

        public object[] Hsector3Datas => new object[8] {Timers.currentTour, "S3", sector_3_sure,
                                           SectorAndTourDatas.gidilen_yol_vcu_sector_3_u32, SectorAndTourDatas.gidilen_yol_gps_sector_3_u32,
                                           sector_3_ortalama_hiz_vcu, sector_3_ortalama_hiz_gps, SectorAndTourDatas.consumption_sector_3_f32};

        public object[] Hsector4Datas => new object[8] {Timers.currentTour, "S4", sector_4_sure,
                                           SectorAndTourDatas.gidilen_yol_vcu_sector_4_u32, SectorAndTourDatas.gidilen_yol_gps_sector_4_u32,
                                           sector_4_ortalama_hiz_vcu, sector_4_ortalama_hiz_gps, SectorAndTourDatas.consumption_sector_4_f32};

        public static bool _IsLog;
        public int dataCounter = 0;
        public int history_counter = 1;
        private string pathfile = @"Logs/";
        private string filename;
        private StreamWriter streamWriter;
        public Dictionary<int,string> read_string = new Dictionary<int, string>();
        public Logs(bool IsLog)
        {
           if(!IsLog)
           {
             
                filename = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";
                streamWriter = new StreamWriter(pathfile + filename);
           }
            _IsLog = IsLog;
        }

        public void Writer()
        {
            streamWriter.WriteLine(Timers.log_datas_time + VCU.log_datas + Driver.log_datas_driver + BMS.log_datas_bms + GpsTracker.log_gps_datas);
        }

        public void Reader()
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.ShowDialog();
            string path = dosya.FileName.ToString();

            if (path != "")
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader okunan_dosya = new StreamReader(fs);
                string okunanlar;
                while (true)
                {
                    okunanlar = okunan_dosya.ReadLine();
                    read_string.Add(dataCounter, okunanlar);
                    dataCounter++;
                    if (okunanlar == null)
                    {
                        break;
                    }
                }
            }

            else
            {
                MessageBox.Show("Text Dosyası Secilmedi");
            }
        }

        public void ReadArayüz(string []old_datass)
        {
            int count = 2;
            Timers.Gecen_süre = TimeSpan.Parse(old_datass[count++]);
            Timers.Kalan_süre = TimeSpan.Parse(old_datass[count++]);
            anlik_tur_sure = old_datass[count++];
            en_hizli_tur_sure = old_datass[count++];
            ortalama_tur_sure = old_datass[count++];
            onceki_tur_sure = old_datass[count++];
            sector_1_sure = old_datass[count++];
            sector_2_sure = old_datass[count++];
            sector_3_sure = old_datass[count++];
            sector_4_sure = old_datass[count++];
            VCU.wake_up_u8 = Byte.Parse(old_datass[count++]);
            VCU.drive_commands_u8 = Byte.Parse(old_datass[count++]);
            VCU.set_velocity_u8 = Byte.Parse(old_datass[count++]);
            Driver.phase_a_current_f32 = float.Parse(old_datass[count++]);
            Driver.phase_b_current_f32 = float.Parse(old_datass[count++]);
            Driver.dc_bus_current_f32 = float.Parse(old_datass[count++]);
            Driver.dc_bus_voltage_f32 = float.Parse(old_datass[count++]);
            Driver.id_f32 = float.Parse(old_datass[count++]);
            Driver.iq_f32 = float.Parse(old_datass[count++]);
            Driver.vd_f32 = float.Parse(old_datass[count++]);
            Driver.vq_f32 = float.Parse(old_datass[count++]);
            Driver.drive_status_u8 = byte.Parse(old_datass[count++]);
            Driver.driver_error_u8 = byte.Parse(old_datass[count++]);
            Driver.odometer_u32 = UInt32.Parse(old_datass[count++]);
            Driver.motor_temperature_u8 = byte.Parse(old_datass[count++]);
            Driver.actual_velocity_u8 = byte.Parse(old_datass[count++]);
            BMS.bat_volt_f32 = float.Parse(old_datass[count++]);
            BMS.bat_current_f32 = float.Parse(old_datass[count++]);
            BMS.bat_cons_f32 = float.Parse(old_datass[count++]);
            BMS.soc_f32 = float.Parse(old_datass[count++]);
            BMS.bms_error_u8 = byte.Parse(old_datass[count++]);
            BMS.dc_bus_state_u8 = byte.Parse(old_datass[count++]);
            BMS.worst_cell_voltage_f32 = float.Parse(old_datass[count++]);
            BMS.worst_cell_address_u8 = byte.Parse(old_datass[count++]);
            BMS.temp_u8 = byte.Parse(old_datass[count++]);
            GpsTracker.gps_latitude_f64 = float.Parse(old_datass[count++]);
            GpsTracker.gps_longtitude_f64 = float.Parse(old_datass[count++]);
            GpsTracker.gps_velocity_u8 = byte.Parse(old_datass[count++]);
            GpsTracker.gps_sattelite_number_u8 = byte.Parse(old_datass[count++]);
            GpsTracker.gps_efficiency_u8 = byte.Parse(old_datass[count++]);
        }

        public void readSdCard(string[] old_datass)
        {
            int count = 0;
            Timers.Gecen_süre = TimeSpan.Parse(old_datass[count++]);
            VCU.wake_up_u8 = Byte.Parse(old_datass[count++]);
            VCU.drive_commands_u8 = Byte.Parse(old_datass[count++]);
            VCU.set_velocity_u8 = Byte.Parse(old_datass[count++]);
            Driver.phase_a_current_f32 = float.Parse(old_datass[count++]);
            Driver.phase_b_current_f32 = float.Parse(old_datass[count++]);
            Driver.dc_bus_current_f32 = float.Parse(old_datass[count++]);
            Driver.dc_bus_voltage_f32 = float.Parse(old_datass[count++]);
            Driver.id_f32 = float.Parse(old_datass[count++]);
            Driver.iq_f32 = float.Parse(old_datass[count++]);
            Driver.vd_f32 = float.Parse(old_datass[count++]);
            Driver.vq_f32 = float.Parse(old_datass[count++]);
            Driver.drive_status_u8 = byte.Parse(old_datass[count++]);
            Driver.driver_error_u8 = byte.Parse(old_datass[count++]);
            Driver.odometer_u32 = UInt32.Parse(old_datass[count++]);
            Driver.motor_temperature_u8 = byte.Parse(old_datass[count++]);
            Driver.actual_velocity_u8 = byte.Parse(old_datass[count++]);
            BMS.bat_volt_f32 = float.Parse(old_datass[count++]);
            BMS.bat_current_f32 = float.Parse(old_datass[count++]);
            BMS.bat_cons_f32 = float.Parse(old_datass[count++]);
            BMS.soc_f32 = float.Parse(old_datass[count++]);
            BMS.bms_error_u8 = byte.Parse(old_datass[count++]);
            BMS.dc_bus_state_u8 = byte.Parse(old_datass[count++]);
            BMS.worst_cell_voltage_f32 = float.Parse(old_datass[count++]);
            BMS.worst_cell_address_u8 = byte.Parse(old_datass[count++]);
            BMS.temp_u8 = byte.Parse(old_datass[count++]);
            GpsTracker.gps_latitude_f64 = float.Parse(old_datass[count++]);
            GpsTracker.gps_longtitude_f64 = float.Parse(old_datass[count++]);
            GpsTracker.gps_velocity_u8 = byte.Parse(old_datass[count++]);
            GpsTracker.gps_sattelite_number_u8 = byte.Parse(old_datass[count++]);
            GpsTracker.gps_efficiency_u8 = byte.Parse(old_datass[count++]);
        }
    }
}
