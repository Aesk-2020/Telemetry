using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Telemetri.Variables;

namespace Telemetri.Variables
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

        public static List<string> ReadByteLog(string splitter)
        {
            logPlayTimer.Interval = 20; //log periyodu 20 ms
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string path = file.FileName.ToString();
            int linecounter = 0;
            int splitLength = splitter.Length;
            int indexOfSplitter = 0;
            int indexOfNextSplitter;
            bool firstLineIndicator = true;

            if (path != "")
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader readFile = new StreamReader(fs, Encoding.GetEncoding("iso-8859-1"));
                string readData = readFile.ReadToEnd();

                var totalMatch = Regex.Matches(readData, splitter).Count;
                if (totalMatch != 0)
                {
                    lineList.Clear();
                    for (int i = 0; i < totalMatch; i++)
                    {
                        indexOfNextSplitter = readData.IndexOf(splitter, linecounter);
                        if(firstLineIndicator == true)
                        {
                            indexOfSplitter = indexOfNextSplitter;
                            firstLineIndicator = false;
                        }
                        lineList.Add(readData.Substring(linecounter, indexOfSplitter));
                        linecounter = indexOfSplitter + splitLength;
                    }
                    isLogSolved = true;
                    MessageBox.Show("Log başarıyla açıldı!");
                    linecounter = 0;
                }
                else
                {
                    MessageBox.Show("Log çözümlenemedi. Yanlış ayracı seçmiş olabilirsiniz");
                }

            }
            return lineList;
        }

        private static int myindex = 0;
        public static void ParseStringData(string hamlog)
        {
            myindex = 2;
            byte[] logBytes1 = Encoding.UTF8.GetBytes(hamlog);
            byte[] logBytes2 = Encoding.Unicode.GetBytes(hamlog);

            byte[] logBytes = ReshapeArray(logBytes2);

            //VCU
            DataVCU.drive_commands_u8   = logBytes[myindex++];
            DataVCU.speed_set_rpm_s16   = BitConverter.ToInt16(logBytes, myindex); myindex += 2; //0.105183
            DataVCU.torque_set_s16      = BitConverter.ToInt16(logBytes, myindex); myindex+=2;
            DataVCU.speed_limit_u16     = BitConverter.ToUInt16(logBytes, myindex); myindex += 2;
            DataVCU.torque_limit_u8     = logBytes[myindex++];

            //MCU
            DataMCU.act_id_current_s16  = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.act_iq_current_s16  = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.vd_s16              = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.vq_s16              = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.set_id_current_s16  = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.set_iq_current_s16  = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.set_torque_s16      = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.i_dc_s16            = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.v_dc_s16            = (float)BitConverter.ToInt16(logBytes, myindex) / 100; myindex += 2;
            DataMCU.act_speed_s16       = (short)(BitConverter.ToInt16(logBytes, myindex) / 10); myindex += 2;
            DataMCU.temperature_u8      = (byte)BitConverter.ToChar(logBytes, myindex); myindex++;
            DataMCU.error_status_u16    = BitConverter.ToUInt16(logBytes, myindex); myindex += 2;
            DataMCU.act_torque_s8       = (sbyte)logBytes[myindex++]; DataMCU.act_torque_s8 -= 100;

            //BMS
            BMS.bat_volt_f32                            = (float)BitConverter.ToUInt16(logBytes, myindex) / MACROS.FLOAT_CONVERTER_2; myindex += 2;
            BMS.bat_current_f32                         = (float)BitConverter.ToInt16(logBytes, myindex) / MACROS.FLOAT_CONVERTER_2; myindex += 2;
            BMS.bat_cons_f32                            = (float)BitConverter.ToUInt16(logBytes, myindex) / MACROS.FLOAT_CONVERTER_1; myindex += 2;
            BMS.soc_f32 = BitConverter.ToUInt16(logBytes, myindex);
            BMS.soc_f32 = BMS.soc_f32 / 100;
            BMS.worst_cell_voltage_f32                  = (float)BitConverter.ToUInt16(logBytes, myindex) / MACROS.FLOAT_CONVERTER_1; myindex += 2;
            BMS.bms_error_u8                            = logBytes[myindex++];
            BMS.dc_bus_state_u8                         = logBytes[myindex++];
            BMS.worst_cell_address_u8                   = logBytes[myindex++];
            BMS.temp_u8                                 = logBytes[myindex++];

            //GPS
            GpsTracker.gps_latitude_f64                 = (double)BitConverter.ToUInt32(logBytes, myindex) / MACROS.GPS_DIVIDER; myindex += 4;
            GpsTracker.gps_longtitude_f64               = (double)BitConverter.ToUInt32(logBytes, myindex) / MACROS.GPS_DIVIDER; myindex += 4;
            GpsTracker.gps_velocity_u8                  = logBytes[myindex++];
            GpsTracker.gps_sattelite_number_u8          = logBytes[myindex++];
            GpsTracker.gps_efficiency_u8                = logBytes[myindex++];

        }

        private static byte[] ReshapeArray(byte[] inputArray)
        {
            byte[] output = new byte[inputArray.Length];
            int j = 0;
            for (int i = 0; i < inputArray.Length; i += 2)
            {
                output[j] = inputArray[i];
                j++;
            }

            return output;
        }

        public static void ExtractSDLog(List<string> list)
        {
            string _extractPath;
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                _extractPath = Path.GetDirectoryName(sf.FileName);
                StreamWriter extrWriter = new StreamWriter(@sf.FileName, append: false);
                extrWriter.WriteLine(MACROS.LOGHEADER);
                foreach (var item in list)
                {
                    ParseStringData(item);
                    extrWriter.WriteLine(VCU.log_data + Driver.log_data_driver + BMS.log_data_bms + GpsTracker.log_gps_data);
                }
                MessageBox.Show("Başarıyla çıkartıldı!");
                extrWriter.Close();
            }
        }

        public static void WriteStringLog()
        {
            _sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + DataVCU.log_data + DataMCU.log_data + DataBMS.log_data + GpsTracker.log_gps_data);
            _sw.Flush();
        }
        public static bool StartLog(System.Timers.Timer logTimer)
        {
            _savefile = new SaveFileDialog();
            
            if(isFirst)
            {
                _savefile.FileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";
                if (_savefile.ShowDialog() == DialogResult.OK)
                {
                    
                    writePath = Path.GetDirectoryName(_savefile.FileName);
                    _sw = new StreamWriter(@_savefile.FileName, append: false);
                    _sw.WriteLine("Time" + "\t" + "Drive Commands" + "\t" + "Speed Set kmh" + "\t" + "Torque Set" + "\t" + "Speed Limit" + "\t" + "Torque Limit" + "\t" + "Kp" + "\t" + "Ki" + "\t" + "Kd" + "\t" + "ID" + "\t" + "IQ" + "\t" + "VD" + "\t" + "VQ" + "\t" + "Set ID" + "\t" + "Set IQ" + "\t" + "Set Torque" + "\t" + "IDC" + "\t" + "VDC" + "\t" + "Act Speed" + "\t" + "Motor Temp" + "\t" + "Errors" + "\t" + "Act Torque" + "\t" + "Battery Voltage" + "\t" + "Battery Current" + "\t" + "Battery Consumption" + "\t" + "SoC" + "\t" + "BMS Error" + "\t" + "DC Bus State" + "\t" + "Worst Cell Voltage" + "\t" + "Worst Cell Address" + "\t" + "Battery temp" + "\t" + "Lattitude" + "\t" + "Longtitude" + "\t" + "GPS Velocity" + "\t" + "Sattelites" + "\t" + "Efficiency");
                    
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

        public static void StopLog(System.Timers.Timer timer)
        {
            timer.Stop();
            _sw.Close();
        }

    }
}
