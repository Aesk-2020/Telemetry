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
    public class LogSystem
    {
        public string writePath { get; set; }

        //Kullanıcının seçtiği dosyayı okuyup her bir satırı string olarak list tipindeki değişkene atar.
        //Okuma işlemi tamamlanınca bu listeyi döndürür.
        public List<string> ReadStringLog()
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

        public List<string> ReadByteLog(string splitter)
        {
            List<string> lineList = new List<string>();
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
        public void ParseStringData(List<string> dataList)
        {
            int count = 0;
            //BİR ŞEY PATLARSA BURAYA BAK
            VCU.wake_up_u8 = Byte.Parse(dataList[count++]);
            VCU.drive_commands_u8 = Byte.Parse(dataList[count++]);
            VCU.set_velocity_u8 = Byte.Parse(dataList[count++]);
            VCU.can_error_u8 = Byte.Parse(dataList[count++]);
            Driver.phase_a_current_f32 = float.Parse(dataList[count++]);
            Driver.phase_b_current_f32 = float.Parse(dataList[count++]);
            Driver.dc_bus_current_f32 = float.Parse(dataList[count++]);
            Driver.dc_bus_voltage_f32 = float.Parse(dataList[count++]);
            Driver.id_f32 = float.Parse(dataList[count++]);
            Driver.iq_f32 = float.Parse(dataList[count++]);
            Driver.IArms_f32 = float.Parse(dataList[count++]);
            Driver.Torque_f32 = float.Parse(dataList[count++]);
            Driver.drive_status_u8 = byte.Parse(dataList[count++]);
            Driver.driver_error_u8 = byte.Parse(dataList[count++]);
            Driver.odometer_u32 = UInt32.Parse(dataList[count++]);
            Driver.motor_temperature_u8 = byte.Parse(dataList[count++]);
            Driver.actual_velocity_u8 = byte.Parse(dataList[count++]);
            BMS.bat_volt_f32 = float.Parse(dataList[count++]);
            BMS.bat_current_f32 = float.Parse(dataList[count++]);
            BMS.bat_cons_f32 = float.Parse(dataList[count++]);
            BMS.soc_f32 = float.Parse(dataList[count++]);
            BMS.bms_error_u8 = byte.Parse(dataList[count++]);
            BMS.dc_bus_state_u8 = byte.Parse(dataList[count++]);
            BMS.worst_cell_voltage_f32 = float.Parse(dataList[count++]);
            BMS.worst_cell_address_u8 = byte.Parse(dataList[count++]);
            BMS.temp_u8 = byte.Parse(dataList[count++]);
            GpsTracker.gps_latitude_f64 = float.Parse(dataList[count++]);
            GpsTracker.gps_longtitude_f64 = float.Parse(dataList[count++]);
            GpsTracker.gps_velocity_u8 = byte.Parse(dataList[count++]);
            GpsTracker.gps_sattelite_number_u8 = byte.Parse(dataList[count++]);
            GpsTracker.gps_efficiency_u8 = byte.Parse(dataList[count++]);
        }

    }
}
