using System;
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
        public static char seperator = '.';

        public static System.Timers.Timer logPlayTimer = new System.Timers.Timer();

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
                        "IDC_L" + "\t" +
                        "VDC_L" + "\t" +
                        "Act Speed_L" + "\t" +
                        "Motor Temp_L" + "\t" +
                        "Errors_L" + "\t" +
                        "Battery Voltage" + "\t" +
                        "Battery Current" + "\t" +
                        "Battery Consumption" + "\t" +
                        "SoC" + "\t" +
                        "BMS Error" + "\t" +
                        "DC Bus State" + "\t" +
                        "Worst Cell Voltage" + "\t" +
                        "Worst Cell Address" + "\t" +
                        "Battery Temp" + "\t" +
                        "Lattitude" + "\t" +
                        "Longtitude" + "\t" +
                        "GPS Velocity" + "\t" +
                        "Sattelites" + "\t" +
                        "Lap Count" + "\t"
                        );

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

        public static bool ReadStringLog()
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
                        return true;
                    }
                }
            }

            else
            {
                MessageBox.Show("Dosya seçilemedi");
                return false;
            }
        }

        public static void WriteStringLog()
        {
            _sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + DataVCU.log_data + DataMCU.log_data + DataBMS.log_data + DataGPS.log_gps_data);
            _sw.Flush();
        }

        public static void ParseStringLog(int indeks)
        {
            string[] rawData = lineList[indeks].Split('\t');

            int dataIndex = 0;
            TimeOperations.logTime              = TimeSpan.Parse(rawData[dataIndex++].Replace(seperator, ','));
            
            DataVCU.drive_commands_u8           = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataVCU.speed_set_rpm_s16           = short.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataVCU.speed_set_rpm_s16           = (short)(DataVCU.speed_set_rpm_s16 * 0.105183);
            DataVCU.torque_set_s16              = short.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataVCU.torque_set_2_s16            = short.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataVCU.torque_limit_u8             = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            
            DataMCU.set_id_current_s16          = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.act_id_current_s16          = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.set_iq_current_s16          = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.act_iq_current_s16          = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.vd_s16                      = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.vq_s16                      = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.v_dc_s16                    = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.i_dc_s16                    = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.act_speed_s16               = DataMCU.act_speed_s16 = (short)(0.105183 * float.Parse(rawData[dataIndex++].Replace(seperator, ',')));
            DataMCU.set_torque_s16              = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.act_torque_s8               = sbyte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.temperature_u8              = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            
            DataMCU.set_id_current_s16_mcu2     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.act_id_current_s16_mcu2     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.set_iq_current_s16_mcu2     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.act_iq_current_s16_mcu2     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.vd_s16_mcu2                 = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.vq_s16_mcu2                 = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.v_dc_s16_mcu2               = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.i_dc_s16_mcu2               = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.act_speed_s16_mcu2          = DataMCU.act_speed_s16_mcu2 = (short)(0.105183 * float.Parse(rawData[dataIndex++].Replace(seperator, ',')));
            DataMCU.set_torque_s16_mcu2         = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.act_torque_s8_mcu2          = sbyte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataMCU.temperature_u8_mcu2         = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            
            DataBMS.volt_u16                    = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataBMS.cur_s16                     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataBMS.cons_u16                    = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataBMS.soc_u16                     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataBMS.error_u8                    = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataBMS.dc_bus_state_u8             = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataBMS.worst_cell_volt_u16         = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataBMS.worst_cell_address_u8       = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataBMS.temperature_u8              = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));

            EMS.bat_volt_f32                    = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.bat_cur_f32                     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.bat_cons_f32                    = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.out_cons_f32                    = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.out_cur_f32                     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.fc_volt_f32                     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.fc_cur_f32                      = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.fc_cons_f32                     = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.fc_lt_cons_f32                  = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.penalty_s8                      = sbyte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.temperature_u8                  = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));
            EMS.error_u8                        = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));

            DataGPS.latitude_f32                = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataGPS.longtitude_f32              = float.Parse(rawData[dataIndex++].Replace(seperator, ','));
            DataGPS.speed_u8                    = byte.Parse(rawData[dataIndex++].Replace(seperator, ','));

            MACROS.newDataCome = true;
        }

        public static void StopLog(System.Timers.Timer timer)
        {
            timer.Stop();
            if (_sw!=null)
            _sw.Close();
        }

    }
}
