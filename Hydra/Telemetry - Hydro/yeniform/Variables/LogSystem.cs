﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.Variables;

namespace telemetry_hydro.Variables
{
    public static class LogSystem
    {
        public static string writePath { get; set; }

        private static SaveFileDialog _savefile;
        private static StreamWriter _sw;

        public static List<string> lineList = new List<string>();
        public static bool isFirst { get; set; }
        public static bool isLogSolved = false;

        public static Timer logPlayTimer = new Timer();

        public static bool StartLog(System.Timers.Timer logTimer)
        {
            _savefile = new SaveFileDialog();

            if (isFirst)
            {
                _savefile.FileName = DateTime.Now.ToString("HH-mm-ss-dd-MM-yyyy") + ".txt";
                if (_savefile.ShowDialog() == DialogResult.OK)
                {

                    writePath = Path.GetDirectoryName(_savefile.FileName);
                    _sw = new StreamWriter(@_savefile.FileName, append: false);
                    _sw.WriteLine(
                        "Time" + "\t" +
                        "Drive Commands" + "\t" +
                        "Speed Set kmh" + "\t" +
                        "Torque Set_L" + "\t" +
                        "Torque Set_R" + "\t" +
                        "Speed Limit" + "\t" +
                        "Torque Limit" + "\t" +
                        "Lap Count" + "\t" +
                        "Kp" + "\t" +
                        "Ki" + "\t" +
                        "Kd" + "\t" +
                        "ID_L" + "\t" +
                        "IQ_L" + "\t" +
                        "VD_L" + "\t" +
                        "VQ_L" + "\t" +
                        "Set ID_L" + "\t" +
                        "Set IQ_L" + "\t" +
                        "Set Torque_L" + "\t" +
                        "IDC_L" + "\t" +
                        "VDC_L" + "\t" +
                        "Act Speed_L" + "\t" +
                        "Motor Temp_L" + "\t" +
                        "Errors_L" + "\t" +
                        "ID_R" + "\t" +
                        "IQ_R" + "\t" +
                        "VD_R" + "\t" +
                        "VQ_R" + "\t" +
                        "Set ID_R" + "\t" +
                        "Set IQ_R" + "\t" +
                        "Set Torque_R" + "\t" +
                        "IDC_R" + "\t" +
                        "VDC_R" + "\t" +
                        "Act Speed_R" + "\t" +
                        "Motor Temp_R" + "\t" +
                        "Errors_R" + "\t" +
                        "Battery Voltage" + "\t" +
                        "Battery Current" + "\t" +
                        "Battery Consumption" + "\t" +
                        "SoC" + "\t" +
                        "BMS Error" + "\t" +
                        "DC Bus State" + "\t" +
                        "Worst Cell Voltage" + "\t" +
                        "Worst Cell Address" + "\t" +
                        "Battery temp" + "\t" +
                        "Lattitude" + "\t" +
                        "Longtitude" + "\t" +
                        "GPS Velocity" + "\t" +
                        "Sattelites");

                    logTimer.Start();
                    isFirst = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {

                _savefile.FileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";
                string temp = writePath + "\\" + _savefile.FileName;
                _sw = new StreamWriter(@temp, append: false);
                _sw.WriteLine("Tarih");

                logTimer.Start();
                return true;
            }

        }

        //Kullanıcının seçtiği dosyayı okuyup her bir satırı string olarak list tipindeki değişkene atar.
        //Okuma işlemi tamamlanınca bu listeyi döndürür.
        public static List<string> ReadStringLog()
        {
            List<string> readData = new List<string>();
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string readPath = file.FileName.ToString();

            if (readPath != "")
            {
                FileStream fs = new FileStream(readPath, FileMode.Open, FileAccess.Read);
                StreamReader okunan_dosya = new StreamReader(fs);
                string okunanlar;
                while (true)
                {
                    okunanlar = okunan_dosya.ReadLine();
                    readData.Add(okunanlar);
                    if (okunanlar == null)
                    {
                        lineList = readData;
                        return readData;
                    }
                }
            }

            else
            {
                MessageBox.Show("Dosya seçilemedi");
                return readData;
            }
        }

        public static void WriteStringLog()
        {
            _sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + DataVCU.log_data + DataMCU.log_data + DataBMS.log_data + DataGPS.log_gps_data);
            _sw.Flush();
        }

        public static void ParseStringLog()
        {
            string[] rawData = lineList[2].Split('\t');

            int dataIndex = 0;
            TimeOperations.logTime              = TimeSpan.Parse(rawData[dataIndex++]);
            
            DataVCU.drive_commands_u8           = byte.Parse(rawData[dataIndex++]);
            DataVCU.speed_set_rpm_s16           = short.Parse(rawData[dataIndex++]); DataVCU.speed_set_rpm_s16 = (short)(DataVCU.speed_set_rpm_s16 * 0.105183);
            DataVCU.torque_set_s16              = short.Parse(rawData[dataIndex++]);
            DataVCU.torque_set_2_s16            = short.Parse(rawData[dataIndex++]);
            DataVCU.torque_limit_u8             = byte.Parse(rawData[dataIndex++]);
            
            DataMCU.set_id_current_s16          = float.Parse(rawData[dataIndex++]);
            DataMCU.act_id_current_s16          = float.Parse(rawData[dataIndex++]);
            DataMCU.set_iq_current_s16          = float.Parse(rawData[dataIndex++]);
            DataMCU.act_iq_current_s16          = float.Parse(rawData[dataIndex++]);
            DataMCU.vd_s16                      = float.Parse(rawData[dataIndex++]);
            DataMCU.vq_s16                      = float.Parse(rawData[dataIndex++]);
            DataMCU.v_dc_s16                    = float.Parse(rawData[dataIndex++]);
            DataMCU.i_dc_s16                    = float.Parse(rawData[dataIndex++]);
            DataMCU.act_speed_s16               = DataMCU.act_speed_s16 = (short)(0.0105183 * float.Parse(rawData[dataIndex++]));
            DataMCU.set_torque_s16              = float.Parse(rawData[dataIndex++]);
            DataMCU.act_torque_s8               = sbyte.Parse(rawData[dataIndex++]);
            DataMCU.temperature_u8              = byte.Parse(rawData[dataIndex++]);
            
            DataMCU.set_id_current_s16_mcu2     = float.Parse(rawData[dataIndex++]);
            DataMCU.act_id_current_s16_mcu2     = float.Parse(rawData[dataIndex++]);
            DataMCU.set_iq_current_s16_mcu2     = float.Parse(rawData[dataIndex++]);
            DataMCU.act_iq_current_s16_mcu2     = float.Parse(rawData[dataIndex++]);
            DataMCU.vd_s16_mcu2                 = float.Parse(rawData[dataIndex++]);
            DataMCU.vq_s16_mcu2                 = float.Parse(rawData[dataIndex++]);
            DataMCU.v_dc_s16_mcu2               = float.Parse(rawData[dataIndex++]);
            DataMCU.i_dc_s16_mcu2               = float.Parse(rawData[dataIndex++]);
            DataMCU.act_speed_s16_mcu2          = DataMCU.act_speed_s16_mcu2 = (short)(0.0105183 * float.Parse(rawData[dataIndex++]));
            DataMCU.set_torque_s16_mcu2         = float.Parse(rawData[dataIndex++]);
            DataMCU.act_torque_s8_mcu2          = sbyte.Parse(rawData[dataIndex++]);
            DataMCU.temperature_u8_mcu2         = byte.Parse(rawData[dataIndex++]);
            
            DataBMS.volt_u16                    = float.Parse(rawData[dataIndex++]);
            DataBMS.cur_s16                     = float.Parse(rawData[dataIndex++]);
            DataBMS.cons_u16                    = float.Parse(rawData[dataIndex++]);
            DataBMS.soc_u16                     = float.Parse(rawData[dataIndex++]);
            DataBMS.error_u8                    = byte.Parse(rawData[dataIndex++]);
            DataBMS.dc_bus_state_u8             = byte.Parse(rawData[dataIndex++]);
            DataBMS.worst_cell_volt_u16         = float.Parse(rawData[dataIndex++]);
            DataBMS.worst_cell_address_u8       = byte.Parse(rawData[dataIndex++]);
            DataBMS.temperature_u8              = byte.Parse(rawData[dataIndex++]);

            EMS.bat_volt_f32                    = float.Parse(rawData[dataIndex++]);
            EMS.bat_cur_f32                     = float.Parse(rawData[dataIndex++]);
            EMS.bat_cons_f32                    = float.Parse(rawData[dataIndex++]);
            EMS.out_cons_f32                    = float.Parse(rawData[dataIndex++]);
            EMS.out_cur_f32                     = float.Parse(rawData[dataIndex++]);
            EMS.fc_volt_f32                     = float.Parse(rawData[dataIndex++]);
            EMS.fc_cur_f32                      = float.Parse(rawData[dataIndex++]);
            EMS.fc_cons_f32                     = float.Parse(rawData[dataIndex++]);
            EMS.fc_lt_cons_f32                  = float.Parse(rawData[dataIndex++]);
            EMS.penalty_s8                      = sbyte.Parse(rawData[dataIndex++]);
            EMS.temperature_u8                  = byte.Parse(rawData[dataIndex++]);
            EMS.error_u8                        = byte.Parse(rawData[dataIndex++]);

            DataGPS.latitude_f32                = float.Parse(rawData[dataIndex++]);
            DataGPS.longtitude_f32              = float.Parse(rawData[dataIndex++]);
            DataGPS.speed_u8                    = byte.Parse(rawData[dataIndex++]);
        }

        public static void StopLog(System.Timers.Timer timer)
        {
            timer.Stop();
            _sw.Close();
        }

    }
}
