using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
namespace Telemetry
{
    public partial class Form1 : Form
    {
        private const float CZoomScale = 4f;
        private int FZoomLevel = 0;
        ListBox gelenler = new ListBox();
        string data = "18.09.2019 08:11:47.11745 -> Veri -> &0,0$0,0$0,0$0,00$0$0$3,14$14$25$1250$15$0,00$0,00$0,00$0,00$0,00$25,55$0$53$0$0$0$15$1$0$0";
        string pathfile = @"Logs\";
        string filename = DateTime.Now.ToString("yyyy_MM_dd_HH_mm") + ".txt";
        string adres = "http://www.ytuaesk.com/log2.txt";
        string other_datas;
        string gps_datas = "41,025542$28,886377$0$0$1$56000$0$";
        #region xbee_kontrol
        readonly double C_RADIUS_EARTH_KM = 6371.1;
        readonly double C_PI = 3.14159265358979;
        readonly Int32 start1lat = 40744392;
        readonly Int32 start1long = 29786054;
        float my_old_gsm_time = 0;
        float refresh_time;
        UInt16 GL_baslik_hatali_u16;
        UInt16 GL_crc_hatali_u16;
        UInt32 GL_gelen_bayt_u32;
        UInt16 GL_cozulen_paket_u16;

        UInt32 GL_tour_distance_gps_u32 = 0;
        UInt32 GL_general_distance_gps_u32 = 0;
        static readonly int maksimumum_gelen_veri = 48;
        byte[] Yakalanan_veriler = new byte[maksimumum_gelen_veri + 1];

        #endregion
        #region Aesk_Telemetry_Verileri
        float bms_bat_volt_f32;
        float bms_bat_current_f32;
        float bms_bat_cons_f32;
        float bms_soc_f32;
        byte bms_error_u8;
        byte bms_dc_bus_state_u8;
        float bms_worst_cell_voltage_f32;
        byte bms_worst_cell_address_u8;
        byte bms_temp_u8;

        float ems_bat_cur_f32;
        float ems_fc_cur_f32;
        float ems_out_cur_f32;
        byte ems_current_error_handler_u8;
        float ems_bat_volt_f32;
        float ems_fc_volt_f32;
        float ems_out_volt_f32;
        byte ems_volt_error_handler_u8;
        float ems_bat_cons_f32;
        float ems_fc_cons_f32;
        float ems_fc_lt_cons_f32;
        float ems_out_cons_f32;
        sbyte ems_penalty_s8;
        float ems_bat_soc_f32;
        sbyte ems_temp_u8;
        byte ems_operation_u8;
        byte ems_general_errors_handler_u8;

        UInt32 driver_odometer_u32;
        byte driver_act_velocity_kmh_u8;
        float driver_phase_a_current_f32;
        float driver_phase_b_current_f32;
        float driver_phase_c_current_f32;
        float driver_dc_bus_current_f32;
        float driver_phase_a_voltage_f32;
        float driver_phase_b_voltage_f32;
        float driver_phase_c_voltage_f32;
        float driver_dc_bus_voltage_f32;
        float driver_motor_temperature_f32;
        float driver_id_f32;
        float driver_iq_f32;
        float driver_vd_f32;
        float driver_vq_f32;
        byte driver_drive_status_u8;
        byte driver_set_velocity_u8;
        byte driver_set_torque_u8;
        byte driver_drive_command_u8;
        byte driver_error_u8;
        byte my_maks_hiz = 0;
        byte vcu_wake_up_command_u8;
        double latitude_f64 = 40.744392;
        double longtitude_f64 = 29.786054;
        double anlik_hiz_u8;
        double ortalama_hiz_f32;
        double ortalama_hiz_vcu_f32;
        UInt32 GL_kalan_yol_u32 = 56000;
        UInt32 GL_kalan_yol_driver_u32;
        #endregion
        #region grafik_kontrol
        bool bat_cons_draw = false;
        bool grafik_baslat = false;
        bool fc_cons_draw = false;
        bool out_cons_draw = false;
        bool fc_lt_cons_draw = false;
        #endregion
        Stopwatch anlik_tur_süresi_time = new Stopwatch();
        TimeSpan gecen_sure_calc;
        TimeSpan ortalama_tur_suresi_time;
        DateTime race_start_time;
        bool first_start_area = false;
        bool calculate_about_race = false;
        bool gps_mouse_mod = false;
        UInt16 tour = 1;
        static PointLatLng start1 = new PointLatLng(40.744392, 29.786054); 
        PointLatLng lastposition = new PointLatLng(40.744392, 29.786054);
        string port_selected;
        double old_lat = 40.744762;
        double old_long = 29.784461;
        
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.MouseWheel += chart1_MouseWheel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("YARIŞA BAŞLAMADAN ÖNCE XBEE PORTUNU KULLANMASANIZ DA MUTLAKA İŞARETLEYİN!!");
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            Thread displayData = new Thread(new ThreadStart(displayAllData));
            displayData.Start();
            Thread timeCalculate = new Thread(new ThreadStart(calculateTimeOperation));
            timeCalculate.Start();
            Thread gsmDivide = new Thread(new ThreadStart(gsmDataConvert));
            gsmDivide.Start();
            history_displayer.ValueChanged -= new EventHandler(this.history_displayer_ValueChanged);
            Control.CheckForIllegalCrossThreadCalls = false;
            gmap.ShowCenter = false;
            GMapMarker marker = new GMarkerGoogle(start1, GMarkerGoogleType.red_dot);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gmap.SetPositionByKeywords("Korfez Yaris Pisti,Turkey");
            gmap.Overlays.Add(markers);
            gmap.DragButton = MouseButtons.Middle;
            gmap.MapProvider = GMapProviders.BingSatelliteMap;
            gmap.MaxZoom = 150;
            gmap.MinZoom = 5;
            gmap.Zoom = 17;
          
            

        }


        private void pORTToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {


            pORTToolStripMenuItem.DropDownItems.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                pORTToolStripMenuItem.DropDownItems.Add(port);
            }

        }

        private void pORTToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            port_selected = e.ClickedItem.Text;
            secilen_port.Text = port_selected;
        }


        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Her hakkı saklıdır." + "\n" +
                "AESK VCU ekibi tarafından hazırlanmıştır." + "\n" +
                "Tasarım Yılı : 2019");
        }

        private void cicikuşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cicikuşu görmeye hazır mısın?", "CİCİKUŞU GÖR", MessageBoxButtons.OKCancel);
        }
        static double total_angle = 0;
        static double old_angle;
        static bool anan = false;
        double x = 0;
        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (gps_mouse_mod && e.Button == MouseButtons.Left)
            {
                PointLatLng mouse_position = gmap.FromLocalToLatLng(e.X, e.Y);
                if(anan == false)
                {
                    old_angle = ComputeBearing(old_lat, old_long, start1.Lat, start1.Lng);
                    anan = true;
                }
                gps_yazdir(Math.Round(mouse_position.Lat, 6), Math.Round(mouse_position.Lng, 6));
                double gelen_lat = Math.Round(mouse_position.Lat, 6);
                double gelen_long = Math.Round(mouse_position.Lng, 6);
                double new_angle = ComputeBearing(old_lat, old_long, gelen_lat, gelen_long);
                if(new_angle < 0)
                {
                    new_angle = new_angle + 360;
                }
   
                    x = new_angle - old_angle;
                

                total_angle += x;
                ort_hiz.Text = (total_angle).ToString();
                old_angle = new_angle;
               }
        }


        
        public double ComputeBearing(double start_lat, double start_long, double end_lat, double end_long)
        {
             var φ1 = start_lat; //latitude 1
             var λ1 = start_long; //longitude 1
             var φ2 = end_lat; //latitude 2
             var λ2 = end_long; //longitude 2

             var y = Math.Sin(this.degreeToRadian(λ2 - λ1)) * Math.Cos(this.degreeToRadian(φ2));
             var x = Math.Cos(this.degreeToRadian(φ1)) * Math.Sin(this.degreeToRadian(φ2)) - Math.Sin(this.degreeToRadian(φ1)) * Math.Cos(this.degreeToRadian(φ2)) * Math.Cos(this.degreeToRadian(λ2 - λ1));

             var θ = Math.Atan2(y, x);
             θ = this.radianToDegree(θ);

             return θ;        
        }

        public double degreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public double radianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        private void gpsMouseModAktifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gps_mouse_mod = true;
        }

        private void gpsMouseModKapalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gps_mouse_mod = false;
        }

        private void markerTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Clear();
            gmap.Zoom += 0.00000001;
            gmap.Zoom -= 0.00000001;
        }
        private double angleFromCoordinate(double lat1, double long1, double lat2,
        double long2)
        {

            double dLon = (long2 - long1);

            double y = Math.Sin(dLon) * Math.Cos(lat2);
            double x = Math.Cos(lat1) * Math.Sin(lat2) - Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(dLon);

            double brng = Math.Atan2(y, x);

            brng = brng * 57.2957795;
            brng = (brng + 360);
            //brng = 360 - brng; // count degrees counter-clockwise - remove to make clockwise

            return brng;
            
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculate_about_race = true;
            time_counter.Enabled = true;
            race_start_time = DateTime.Now;
            anlik_tur_süresi_time.Start();
        }

        private void time_counter_Tick(object sender, EventArgs e)
        {
            calculateTimeOperation();
        }
        static int adim = 0;
        static int veri_sayaci = 0;
        static int crc_hesaplanan = 0;

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytes];
            serialPort1.Read(buffer, 0, bytes);
            GL_gelen_bayt_u32 += (UInt32)bytes;
            for (int i = 0; i < bytes; i++)
            {
                switch (adim)
                {
                    case 0:
                        {
                            if (buffer[i] == 0x69)
                            {

                                adim = 1;
                                Yakalanan_veriler[veri_sayaci] = buffer[i];
                                veri_sayaci++;
                            }
                            else
                            {
                                GL_baslik_hatali_u16++;
                                adim = 0;
                            }
                            break;
                        }
                    case 1:
                        {
                            Yakalanan_veriler[veri_sayaci] = buffer[i];
                            veri_sayaci++;
                            if (veri_sayaci >= 49)
                            {
                                veri_sayaci = 0;
                                crc_hesaplanan = (Yakalanan_veriler[47] << 8) | Yakalanan_veriler[48];
                                ushort gelen_crc = aeskCRCCalculate(Yakalanan_veriler, 61);
                                if (crc_hesaplanan == gelen_crc)
                                {
                                    GL_cozulen_paket_u16++;
                                    dataConvert(Yakalanan_veriler);
                                    displayAllData();
                                }
                                else
                                {
                                    GL_crc_hatali_u16++;
                                }
                                adim = 0;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }

        }

        static ushort aeskCRCCalculate(byte[] frame, uint framesize)
        {
            ushort crc16_data = 0;
            byte data = 0;
            for (byte mlen = 0; mlen < framesize; mlen++)
            {
                data = Convert.ToByte(((byte)frame[mlen] ^ Convert.ToByte(((crc16_data) & (0xFF)))));
                Console.WriteLine(data);
                data = (byte)((byte)data ^ (byte)(data << 4));
                crc16_data = (ushort)((((ushort)data << 8) | ((crc16_data & 0xFF00) >> 8)) ^ (byte)(data >> 4) ^ ((ushort)data << 3));
            }
            return (crc16_data);
        }
        void dataConvert(byte[] gelenVeri)
        {
            bms_soc_f32 = (float)BitConverter.ToUInt16(gelenVeri, 1) / 10;
            bms_bat_cons_f32 = (float)BitConverter.ToUInt16(gelenVeri, 3) / 10;
            bms_bat_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 5) / 10;
            bms_bat_volt_f32 = (float)BitConverter.ToUInt16(gelenVeri, 7) / 10;
            bms_temp_u8 = gelenVeri[9];
            bms_worst_cell_address_u8 = gelenVeri[10];
            bms_worst_cell_voltage_f32 = (float)BitConverter.ToUInt16(gelenVeri, 11) / 1000;
            bms_dc_bus_state_u8 = gelenVeri[13];
            bms_error_u8 = gelenVeri[14];

            driver_dc_bus_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 15) / 100;
            driver_phase_c_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 17) / 100;
            driver_phase_b_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 19) / 100;
            driver_phase_a_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 21) / 100;

            driver_dc_bus_voltage_f32 = (float)BitConverter.ToUInt16(gelenVeri, 23) / 100;
            driver_motor_temperature_f32 = (float)BitConverter.ToUInt16(gelenVeri, 25) / 100;
            
            driver_odometer_u32 = BitConverter.ToUInt32(gelenVeri, 27);
            driver_act_velocity_kmh_u8 = gelenVeri[31];
            driver_drive_status_u8 = gelenVeri[32];

            driver_drive_command_u8 = gelenVeri[33];
            driver_set_velocity_u8 = gelenVeri[34];

            latitude_f64 = (double)BitConverter.ToUInt32(gelenVeri, 35) / 1000000;
            longtitude_f64 = (double)BitConverter.ToUInt32(gelenVeri, 39) / 1000000;
            if (!gps_mouse_mod)
            {
                gps_yazdir(latitude_f64, longtitude_f64);
            }
            anlik_hiz_u8 = gelenVeri[43];
            vcu_wake_up_command_u8 = gelenVeri[44];
            driver_drive_status_u8 = gelenVeri[45];
            driver_error_u8 = gelenVeri[46];

        }
        static UInt32 GL_gidilen_yol_tour_u32;
        static UInt32 GL_gidilen_yol_toplayici_u32;
        static UInt32 i = 0;
        static float GL_ems_bat_cons_tour_f32;
        static float GL_ems_bat_cons_tour_toplayici_f32;
        static float GL_ems_fc_cons_tour_f32;
        static float GL_ems_fc_cons_tour_toplayici_f32;
        static float GL_ems_fc_lt_cons_tour_f32;
        static float GL_ems_fc_lt_cons_tour_toplayici_f32;
        static float GL_ems_out_cons_tour_f32;
        static float GL_ems_out_cons_tour_toplayici_f32;
        private void gps_yazdir(double latitude, double longtitude)
        {
            long sonuc1;
            long sonuc2;
            PointLatLng receivedPosition = new PointLatLng(latitude, longtitude);
            GMapMarker marker = new GMarkerGoogle(receivedPosition, GMarkerGoogleType.red_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
            UInt32 markerpointlng = (UInt32)(longtitude * 1000000);
            UInt32 markerpointlat = (UInt32)(latitude * 1000000);
            sonuc1 = markerpointlng - start1long;
            sonuc2 = markerpointlat - start1lat;
            sonuc1 = Math.Abs(sonuc1);
            sonuc2 = Math.Abs(sonuc2);
            if (calculate_about_race && sonuc1 < 150 && sonuc2 < 40)
            {
                first_start_area = true;
            }

            if(first_start_area)
            {
                i++;
            }
            if (calculate_about_race && first_start_area && (sonuc1 < 150 && sonuc2 < 40) && i >= 20)
            {
                #region dataGridCalculateArea
                anlik_tur_süresi_time.Stop();
                int sure = (int)anlik_tur_süresi_time.Elapsed.TotalSeconds;

                GL_gidilen_yol_tour_u32 = driver_odometer_u32 - GL_gidilen_yol_toplayici_u32;
                GL_gidilen_yol_toplayici_u32 += GL_gidilen_yol_tour_u32;

                ortalama_hiz_f32 = Math.Round(((float)GL_tour_distance_gps_u32 / sure) * 3.6, 2);
                ortalama_hiz_vcu_f32 = Math.Round(((float)GL_gidilen_yol_tour_u32 / sure) * 3.6, 2);

                ortalama_tur_suresi_time = new TimeSpan(gecen_sure_calc.Ticks / tour);

                GL_ems_bat_cons_tour_f32 = ems_bat_cons_f32 - GL_ems_bat_cons_tour_toplayici_f32;
                GL_ems_bat_cons_tour_toplayici_f32 += GL_ems_bat_cons_tour_f32;

                GL_ems_fc_cons_tour_f32 = ems_fc_cons_f32 - GL_ems_fc_cons_tour_toplayici_f32;
                GL_ems_fc_cons_tour_toplayici_f32 += GL_ems_fc_cons_tour_f32;

                GL_ems_fc_lt_cons_tour_f32 = ems_fc_lt_cons_f32 - GL_ems_fc_lt_cons_tour_toplayici_f32;
                GL_ems_fc_lt_cons_tour_toplayici_f32 += GL_ems_fc_lt_cons_tour_f32;

                GL_ems_out_cons_tour_f32 = ems_out_cons_f32 - GL_ems_out_cons_tour_toplayici_f32;
                GL_ems_out_cons_tour_toplayici_f32 += GL_ems_out_cons_tour_f32;

                dataGridView1.Rows.Add(tour, anlik_tur_süresi_time.Elapsed.Duration().ToString(@"hh\:mm\:ss"), GL_gidilen_yol_tour_u32, GL_tour_distance_gps_u32, ortalama_hiz_vcu_f32, ortalama_hiz_f32, GL_ems_bat_cons_tour_f32, GL_ems_fc_cons_tour_f32, GL_ems_fc_lt_cons_tour_f32, GL_ems_out_cons_tour_f32); 
                #endregion
                GL_tour_distance_gps_u32 = 0;
                    tour++;
                    i = 0;
                    anlik_tur_süresi_time.Restart();
                    anlik_tur_süresi_time.Start();
                    gmap.Overlays.Clear();
            }


            if (first_start_area) { 
                GL_tour_distance_gps_u32 += (UInt32)(GreatCircleDistance(latitude, longtitude, lastposition.Lat, lastposition.Lng) * 1000);
                GL_general_distance_gps_u32 += (UInt32)(GreatCircleDistance(latitude, longtitude, lastposition.Lat, lastposition.Lng) * 1000);
            }
            lastposition.Lat = latitude;
                lastposition.Lng = longtitude;
                gidilen_yol_gps.Text = GL_general_distance_gps_u32.ToString();
                turr.Text = tour.ToString();
                kalan_yol_gps.Text = (GL_kalan_yol_u32 - GL_general_distance_gps_u32).ToString();

            

            gmap.Zoom += 0.00000001;
            gmap.Zoom -= 0.00000001;
            #region gpsDatas
            gps_datas = latitude.ToString()                                 + '$' +
                                longtitude.ToString()                       + '$' +
                                GL_gidilen_yol_tour_u32.ToString()          + '$' +
                                GL_tour_distance_gps_u32.ToString()         + '$' +
                                GL_general_distance_gps_u32.ToString()      + '$' +
                                tour.ToString()                             + '$' +
                                kalan_yol_gps.Text                          + '$' +
                                gidilen_yol_gps.Text                        + '$' +
                                GL_ems_bat_cons_tour_f32.ToString()         + '$' +
                                GL_ems_fc_cons_tour_f32.ToString()          + '$' +
                                GL_ems_fc_lt_cons_tour_f32.ToString()       + '$' 
                                ;
            #endregion

        }
        double GreatCircleDistance(double Latitude1, double Longitude1, double Latitude2, double Longitude2)
        {
            double Lat1;
            double Lat2;
            double Long1;
            double Long2;
            double Delta;

            Lat1 = Latitude1;
            Long1 = Longitude1;
            Lat2 = Latitude2;
            Long2 = Longitude2;
            Lat1 = (Lat1 / 180) * C_PI;
            Lat2 = (Lat2 / 180) * C_PI;
            Long1 = (Long1 / 180) * C_PI;
            Long2 = (Long2 / 180) * C_PI;
            Delta = (2 * Math.Asin(Math.Sqrt((Math.Pow(Math.Sin((Lat1 - Lat2) / 2), 2) + Math.Cos(Lat1) * Math.Cos(Lat2) * (Math.Pow(Math.Sin((Long1 - Long2) / 2), 2))))));
            return (Delta * C_RADIUS_EARTH_KM);
        }

        private void bağlanToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = port_selected;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    serialPort1.Open();
                    xbee_durum.Text = "AKTİF";
                }
                else
                {
                    serialPort1.Close();
                }
            }

            catch
            {
                MessageBox.Show("Bağlantı açılamadı!");
            }
        }

    
        void gsmDataConvert()
        {
            float myhour = float.Parse(data.Substring(11, 2));
            float myminute = float.Parse(data.Substring(14, 2));
            float mysecond = float.Parse(data.Substring(17, 2));
            float mymillisecond = float.Parse(data.Substring(20, 3));

            float my_gsm_time = (myhour * 360000) + (myminute * 60000) + (mysecond * 1000) + mymillisecond;
            float my_gsm_time_millisecond = my_gsm_time;

            if(my_old_gsm_time == 0)
            {
                my_old_gsm_time = my_gsm_time;
            }

            if(my_gsm_time == my_old_gsm_time)
            {
                gsm_yenileme.Text = "NND";
            }

            else
            {
                refresh_time = my_gsm_time_millisecond - my_old_gsm_time;
                gsm_yenileme.Text = refresh_time.ToString();
                my_old_gsm_time = my_gsm_time_millisecond;
            }
            
  
            data = data.Split('&').Last();
            string[] dataarray = data.Split('$');
            bms_bat_volt_f32 = float.Parse(dataarray[0]);
            bms_bat_current_f32 = float.Parse(dataarray[1]);
            bms_bat_cons_f32 = float.Parse(dataarray[2]);
            bms_soc_f32 = float.Parse(dataarray[3]);
            bms_error_u8 = Convert.ToByte(dataarray[4]);
            bms_dc_bus_state_u8 = Convert.ToByte(dataarray[5]);
            bms_worst_cell_voltage_f32 = float.Parse(dataarray[6]);
            bms_worst_cell_address_u8 = Convert.ToByte(dataarray[7]);
            bms_temp_u8 = Convert.ToByte(dataarray[8]);
            driver_odometer_u32 = Convert.ToUInt32(dataarray[9]);
            GL_kalan_yol_driver_u32 = 56000 - driver_odometer_u32;
            driver_act_velocity_kmh_u8 = Convert.ToByte(dataarray[10]);
            driver_phase_a_current_f32 = float.Parse(dataarray[11]);
            driver_phase_b_current_f32 = float.Parse(dataarray[12]);
            driver_phase_c_current_f32 = float.Parse(dataarray[13]);
            driver_dc_bus_current_f32 = float.Parse(dataarray[14]);
            driver_dc_bus_voltage_f32 = float.Parse(dataarray[15]);
            driver_motor_temperature_f32 = float.Parse(dataarray[16]);
            driver_drive_status_u8 = Convert.ToByte(dataarray[17]);
            driver_set_velocity_u8 = Convert.ToByte(dataarray[18]);
            driver_drive_command_u8 = Convert.ToByte(dataarray[19]);
            latitude_f64 = (double)Convert.ToUInt32(dataarray[20]) / 1000000;
            longtitude_f64 = (double)Convert.ToUInt32(dataarray[21]) / 1000000;
            #region thread_protection
            if(latitude_f64 == 0)
            {
                latitude_f64 = 21.422504; 
            }
            if (longtitude_f64 == 0)
            {
                longtitude_f64 = 39.826192;
            }
            #endregion
            anlik_hiz_u8 = Convert.ToByte(dataarray[22]);
            vcu_wake_up_command_u8 = Convert.ToByte(dataarray[23]);
            driver_error_u8 = Convert.ToByte(dataarray[25]);
            if (!gps_mouse_mod)
            {
                gps_yazdir(latitude_f64, longtitude_f64);
            }
                displayAllData();
        }
        void displayAllData()
        {
            #region log_data_region          
            if (calculate_about_race)
            {
                string log_data = bms_bat_volt_f32.ToString() + '$' +
                                  bms_bat_current_f32.ToString() + '$' +
                                  bms_bat_cons_f32.ToString() + '$' +
                                  bms_soc_f32.ToString() + '$' +
                                  bms_error_u8.ToString() + '$' +
                                  bms_dc_bus_state_u8.ToString() + '$' +
                                  bms_worst_cell_voltage_f32.ToString() + '$' +
                                  bms_worst_cell_address_u8.ToString() + '$' +
                                  bms_temp_u8.ToString() + '$' +
                                  ems_bat_cur_f32.ToString() + '$' +
                                  ems_fc_cur_f32.ToString() + '$' +
                                  ems_out_cur_f32.ToString() + '$' +
                                  ems_current_error_handler_u8.ToString() + '$' +
                                  ems_bat_volt_f32.ToString() + '$' +
                                  ems_fc_volt_f32.ToString() + '$' +
                                  ems_out_volt_f32.ToString() + '$' +
                                  ems_volt_error_handler_u8.ToString() + '$' +
                                  ems_bat_cons_f32.ToString() + '$' +
                                  ems_fc_cons_f32.ToString() + '$' +
                                  ems_fc_lt_cons_f32.ToString() + '$' +
                                  ems_out_cons_f32.ToString() + '$' +
                                  ems_penalty_s8.ToString() + '$' +
                                  ems_bat_soc_f32.ToString() + '$' +
                                  ems_temp_u8.ToString() + '$' +
                                  driver_odometer_u32.ToString() + '$' +
                                  driver_act_velocity_kmh_u8.ToString() + '$' +
                                  driver_phase_a_current_f32.ToString() + '$' +
                                  driver_phase_b_current_f32.ToString() + '$' +
                                  driver_phase_c_current_f32.ToString() + '$' +
                                  driver_dc_bus_current_f32.ToString() + '$' +
                                  driver_phase_a_voltage_f32.ToString() + '$' +
                                  driver_phase_b_voltage_f32.ToString() + '$' +
                                  driver_phase_c_voltage_f32.ToString() + '$' +
                                  driver_dc_bus_voltage_f32.ToString() + '$' +
                                  driver_motor_temperature_f32.ToString() + '$' +
                                  driver_id_f32.ToString() + '$' +
                                  driver_iq_f32.ToString() + '$' +
                                  driver_vd_f32.ToString() + '$' +
                                  driver_vq_f32.ToString() + '$' +
                                  driver_drive_status_u8.ToString() + '$' +
                                  driver_set_velocity_u8.ToString() + '$' +
                                  gsm_yenileme.Text + '$' +
                                  driver_drive_command_u8.ToString() + '$' +
                                  my_maks_hiz.ToString() + '$' +
                                  GL_kalan_yol_driver_u32.ToString() + '$' + 
                                  vcu_wake_up_command_u8.ToString() +  '$' +
                                  driver_error_u8.ToString()        +  '$' +     
                                  "\n";
                File.AppendAllText(pathfile + filename, other_datas + gps_datas + log_data);
            }
            #endregion
            #region wake_up_control
            if ((vcu_wake_up_command_u8 & 0b00000001) != 0)
            {
                bms_durum.Text = "AKTİF";
            }
            else
            {
                bms_durum.Text = "KAPALI";
            }

            if ((vcu_wake_up_command_u8 & 0b00000010) != 0)
            {
                driver_durum.Text = "AKTİF";
            }
            else
            {
                driver_durum.Text = "KAPALI";
            }

            if ((vcu_wake_up_command_u8 & 0b00000100) != 0)
            {
                ems_durum.Text = "AKTİF";
            }
            else
            {
                ems_durum.Text = "KAPALI";
            }
            #endregion
            #region ems_text_write
            ems_bat_current.Text = ems_bat_cur_f32.ToString();
            ems_fc_current.Text = ems_fc_cur_f32.ToString();
            ems_out_current.Text = ems_out_cur_f32.ToString();
            ems_bat_volt.Text = ems_bat_volt_f32.ToString();
            ems_fc_volt.Text = ems_fc_volt_f32.ToString();
            ems_out_volt.Text = ems_out_volt_f32.ToString();
            ems_bat_cons.Text = ems_bat_cons_f32.ToString();
            ems_fc_cons.Text = ems_fc_cons_f32.ToString();
            ems_fc_lt_cons.Text = ems_fc_lt_cons_f32.ToString();
            ems_out_cons.Text = ems_out_cons_f32.ToString();
            ems_penalty.Text = ems_penalty_s8.ToString();
            ems_bat_soc.Text = ems_bat_soc_f32.ToString();
            ems_temp.Text = ems_temp_u8.ToString();
            #endregion
            #region ems_voltage_error_control
            if ((ems_volt_error_handler_u8 & 0b00000001) != 0)
            {
                ems_bat_volt_error.BackColor = Color.Red;
            }
            else

            {
                ems_bat_volt_error.BackColor = Color.SpringGreen;
            }

            if ((ems_volt_error_handler_u8 & 0b00000010) != 0)
            {
                ems_fc_volt_error.BackColor = Color.Red;
            }
            else
            {
                ems_fc_volt_error.BackColor = Color.SpringGreen;
            }

            if ((ems_volt_error_handler_u8 & 0b00000100) != 0)
            {
                ems_out_volt_error.BackColor = Color.Red;
            }
            else
            {
                ems_out_volt_error.BackColor = Color.SpringGreen;
            }
            #endregion
            #region ems_current_error_control
            if ((ems_current_error_handler_u8 & 0b00000001) != 0)
            {
                ems_bat_current_error.BackColor = Color.Red;
            }
            else

            {
                ems_bat_current_error.BackColor = Color.SpringGreen;
            }

            if ((ems_current_error_handler_u8 & 0b00000010) != 0)
            {
                ems_fc_current_error.BackColor = Color.Red;
            }
            else
            {
                ems_fc_current_error.BackColor = Color.SpringGreen;
            }

            if ((ems_current_error_handler_u8 & 0b00000100) != 0)
            {
                ems_out_current_error.BackColor = Color.Red;
            }
            else
            {
                ems_out_current_error.BackColor = Color.SpringGreen;
            }
            #endregion
            #region bms_text_write
            bms_bat_volt.Text = bms_bat_volt_f32.ToString();
            bms_bat_current.Text = bms_bat_current_f32.ToString();
            bms_bat_cons.Text = bms_bat_cons_f32.ToString();
            bms_soc.Text = bms_soc_f32.ToString();
            bms_worst_cell_address.Text = bms_worst_cell_address_u8.ToString();
            bms_worst_cell_volt.Text = bms_worst_cell_voltage_f32.ToString();
            bms_temp.Text = bms_temp_u8.ToString();
            #endregion
            #region bms_error_control

            if ((bms_error_u8 & 0b00000001) != 0)
            {
                bms_high_volt_error.BackColor = Color.Red;
            }
            else
            {
                bms_high_volt_error.BackColor = Color.SpringGreen;
            }

            if ((bms_error_u8 & 0b00000010) != 0)
            {
                bms_low_volt_error.BackColor = Color.Red;
            }
            else
            {
                bms_low_volt_error.BackColor = Color.SpringGreen;
            }

            if ((bms_error_u8 & 0b00000100) != 0)
            {
                bms_temp_error.BackColor = Color.Red;
            }
            else
            {
                bms_temp_error.BackColor = Color.SpringGreen;
            }

            if ((bms_error_u8 & 0b00001000) != 0)
            {
                bms_comm_error.BackColor = Color.Red;
            }
            else
            {
                bms_comm_error.BackColor = Color.SpringGreen;
            }

            if ((bms_error_u8 & 0b00010000) != 0)
            {
                bms_over_cur_error.BackColor = Color.Red;
            }
            else
            {
                bms_over_cur_error.BackColor = Color.SpringGreen;
            }

            #endregion
            #region dc_bus_state
            if ((bms_dc_bus_state_u8 & 0b00000001) != 0)
            {
                bms_precharge_flag.BackColor = Color.SpringGreen;
            }
            else
            {
                bms_precharge_flag.BackColor = Color.White;
            }

            if ((bms_dc_bus_state_u8 & 0b00000010) != 0)
            {
                bms_discharge_flag.BackColor = Color.SpringGreen;
            }
            else
            {
                bms_discharge_flag.BackColor = Color.White;
            }

            if ((bms_dc_bus_state_u8 & 0b00000100) != 0)
            {
                bms_dc_bus_ready_flag.BackColor = Color.SpringGreen;
            }
            else
            {
                bms_dc_bus_ready_flag.BackColor = Color.White;
            }
            #endregion
            #region driver_text_write
            gidilen_yol.Text = driver_odometer_u32.ToString();
            anlik_hiz.Text = driver_act_velocity_kmh_u8.ToString();
            anlik_hiz_gps.Text = anlik_hiz_u8.ToString();
            my_maks_hiz = driver_act_velocity_kmh_u8 > my_maks_hiz ? driver_act_velocity_kmh_u8 : my_maks_hiz;
            maks_hiz.Text = my_maks_hiz.ToString();
            phase_a_cur.Text = driver_phase_a_current_f32.ToString();
            phase_b_cur.Text = driver_phase_b_current_f32.ToString();
            phase_c_cur.Text = driver_phase_c_current_f32.ToString();
            dc_bus_cur.Text = driver_dc_bus_current_f32.ToString();
            phase_a_volt.Text = Math.Round(driver_dc_bus_voltage_f32 * driver_dc_bus_current_f32, 2).ToString();
            phase_b_volt.Text = driver_phase_b_voltage_f32.ToString();
            phase_c_volt.Text = driver_phase_c_voltage_f32.ToString();
            dc_bus_volt.Text = driver_dc_bus_voltage_f32.ToString();
            motor_temp.Text = driver_motor_temperature_f32.ToString();
            id.Text = driver_id_f32.ToString();
            act_torque.Text = Math.Round(((float)driver_id_f32 * 0.45), 2).ToString();
            iq.Text = driver_iq_f32.ToString();
            vd.Text = driver_vd_f32.ToString();
            vq.Text = driver_vq_f32.ToString();
            set_hiz.Text = driver_set_velocity_u8.ToString();
            kalan_yol.Text = GL_kalan_yol_driver_u32.ToString();
            #endregion
            #region statuscommandcontrol
            if ((driver_drive_status_u8 & 0b00000001) != 0)
            {
                driver_fwrv_status.Text = "REVERSE";
            }
            else
            {
                driver_fwrv_status.Text = "FORWARD";
            }

            if ((driver_drive_status_u8 & 0b00000010) != 0)
            {
                driver_brake_status.Text = "BRAKE ON";
            }
            else
            {
                driver_brake_status.Text = "BRAKE OFF";
            }

            if ((driver_drive_status_u8 & 0b00000100) != 0)
            {
                driver_ign_status.Text = "IGN ON";
            }
            else
            {
                driver_ign_status.Text = "IGN OFF";
            }

            if ((driver_drive_command_u8 & 0b00000001) != 0)
            {
                driver_fwrv_command.Text = "REVERSE";
            }
            else
            {
                driver_fwrv_command.Text = "FORWARD";
            }

            if ((driver_drive_command_u8 & 0b00000010) != 0)
            {
                driver_brake_command.Text = "BRAKE ON";
            }
            else
            {
                driver_brake_command.Text = "BRAKE OFF";
            }

            if ((driver_drive_command_u8 & 0b00000100) != 0)
            {
                driver_ign_command.Text = "IGN ON";
            }
            else
            {
                driver_ign_command.Text = "IGN OFF";
            }
            #endregion
            #region driver_error_control
            if ((driver_error_u8 & 0b00000001) != 0)
            {
                zpc.BackColor = Color.SpringGreen;
            }
            else

            {
                zpc.BackColor = Color.Red;
            }

            if ((driver_error_u8 & 0b00000010) != 0)
            {
                pwm_enabled.BackColor = Color.SpringGreen;
            }
            else
            {
                pwm_enabled.BackColor = Color.Red;
            }

            if ((driver_error_u8 & 0b00000100) != 0)
            {
                dc_bus_voltage_error.BackColor = Color.SpringGreen;
            }
            else
            {
                dc_bus_voltage_error.BackColor = Color.Red;
            }

            if ((driver_error_u8 & 0b00001000) != 0)
            {
                motor_temp_error.BackColor = Color.SpringGreen;
            }
            else
            {
                motor_temp_error.BackColor = Color.Red;
            }

            if ((driver_error_u8 & 0b00010000) != 0)
            {
                dc_bus_amper_error.BackColor = Color.SpringGreen;
            }
            else

            {
                dc_bus_amper_error.BackColor = Color.Red;
            }



            if ((driver_error_u8 & 0b00100000) != 0)
            {
                id_error.BackColor = Color.SpringGreen;
            }
            else
            {
                id_error.BackColor = Color.Red;
            }




            #endregion
        }

        private void gsm_trigger_Tick(object sender, EventArgs e)
        {
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            StreamReader donenbilgiler;
           try
            {
                cevap = istek.GetResponse();
                donenbilgiler = new StreamReader(cevap.GetResponseStream());
                data = donenbilgiler.ReadToEnd();
                String newData = data.Replace('.', ',');
                data = newData;
                gsmDataConvert();
            }
          
            catch
            {
                
                gsm_durum.Text = "KAPALI";
                gsm_trigger.Enabled = false;

                try
                {
                    if (serialPort1.IsOpen == false)
                    {
                        serialPort1.PortName = port_selected;
                        serialPort1.BaudRate = 9600;
                        serialPort1.Open();
                        xbee_durum.Text = "AKTİF";
                    }
                    else
                    {
                        serialPort1.Close();
                    }
                }

                catch
                {
                    gsm_trigger.Enabled = false;
                    MessageBox.Show("Bağlantı açılamadı!");
                }

            }
            }

        private void bağlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gsm_trigger.Enabled = true;
            gsm_durum.Text = "AKTİF";
            serialPort1.DataReceived -= new SerialDataReceivedEventHandler(sp_DataReceived);
            xbee_durum.Text = "KAPALI";
        }

        private void kayıtAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.ShowDialog();
            string path = dosya.FileName.ToString();
            if (path != "")
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader okunan_dosya = new StreamReader(fs);
                string okunanlar = okunan_dosya.ReadLine();
                while (okunanlar != null)
                {

                    gelenler.Items.Add(okunanlar);
                    okunanlar = okunan_dosya.ReadLine();
                }
            }
            history_displayer.ValueChanged += new EventHandler(this.history_displayer_ValueChanged);
            history_displayer.Maximum = gelenler.Items.Count - 1;
        }

        private void history_displayer_ValueChanged(object sender, EventArgs e)
        {
            string[] old_datass = gelenler.Items[history_displayer.Value].ToString().Split('$');
            ortalama_tur_suresi.Text = old_datass[0];
            anlik_tur_suresi.Text = old_datass[1];
            kalan_sure.Text = old_datass[2];
            gecen_sure.Text = old_datass[3];
            turr.Text = old_datass[4];
            ort_hiz.Text = old_datass[5];
            hedef_hiz.Text = old_datass[6];
            double old_latitudes = double.Parse(old_datass[7]);
            double old_longtitudes = double.Parse(old_datass[8]);
            GL_gidilen_yol_tour_u32 = Convert.ToUInt32(old_datass[9]);
            GL_tour_distance_gps_u32 = Convert.ToUInt32(old_datass[10]);
            GL_general_distance_gps_u32 = Convert.ToUInt32(old_datass[11]);
            tour = Convert.ToUInt16(old_datass[12]);
            kalan_yol_gps.Text = old_datass[13];
            gidilen_yol_gps.Text = old_datass[14];
            GL_ems_bat_cons_tour_f32 = float.Parse(old_datass[15]);
            GL_ems_fc_cons_tour_f32 = float.Parse(old_datass[16]);
            GL_ems_fc_lt_cons_tour_f32 = float.Parse(old_datass[17]);
            bms_bat_volt_f32 = float.Parse(old_datass[18]);
            bms_bat_current_f32 = float.Parse(old_datass[19]);
            bms_bat_cons_f32 = float.Parse(old_datass[20]);
            bms_soc_f32 = float.Parse(old_datass[21]);
            bms_error_u8 = Convert.ToByte(old_datass[22]);
            bms_dc_bus_state_u8 = Convert.ToByte(old_datass[23]);
            bms_worst_cell_voltage_f32 = float.Parse(old_datass[24]);
            bms_worst_cell_address_u8 = Convert.ToByte(old_datass[25]);
            bms_temp_u8 = Convert.ToByte(old_datass[26]);
            ems_bat_cur_f32 = float.Parse(old_datass[27]);
            ems_fc_cur_f32 = float.Parse(old_datass[28]);
            ems_out_cur_f32 = float.Parse(old_datass[29]);
            ems_current_error_handler_u8 = Convert.ToByte(old_datass[30]);
            ems_bat_volt_f32 = float.Parse(old_datass[31]);
            ems_fc_volt_f32 = float.Parse(old_datass[32]);
            ems_out_volt_f32 = float.Parse(old_datass[33]);
            ems_volt_error_handler_u8 = Convert.ToByte(old_datass[34]);
            ems_bat_cons_f32 = float.Parse(old_datass[35]);
            ems_fc_cons_f32 = float.Parse(old_datass[36]);
            ems_fc_lt_cons_f32 = float.Parse(old_datass[37]);
            ems_out_cons_f32 = float.Parse(old_datass[38]);
            ems_penalty_s8 = Convert.ToSByte(old_datass[39]);
            ems_bat_soc_f32 = float.Parse(old_datass[40]);
            ems_temp_u8 = Convert.ToSByte(old_datass[41]);
            driver_odometer_u32 = Convert.ToUInt32(old_datass[42]);
            driver_act_velocity_kmh_u8 = Convert.ToByte(old_datass[43]);
            driver_phase_a_current_f32 = float.Parse(old_datass[44]);
            driver_phase_b_current_f32 = float.Parse(old_datass[45]);
            driver_phase_c_current_f32 = float.Parse(old_datass[46]);
            driver_dc_bus_current_f32 = float.Parse(old_datass[47]);
            driver_phase_a_voltage_f32 = float.Parse(old_datass[48]);
            driver_phase_b_voltage_f32 = float.Parse(old_datass[49]);
            driver_phase_c_voltage_f32 = float.Parse(old_datass[50]);
            driver_dc_bus_voltage_f32 = float.Parse(old_datass[51]);
            driver_motor_temperature_f32 = float.Parse(old_datass[52]);
            driver_id_f32 = float.Parse(old_datass[53]);
            driver_iq_f32 = float.Parse(old_datass[54]);
            driver_vd_f32 = float.Parse(old_datass[55]);
            driver_vq_f32 = float.Parse(old_datass[56]);
            driver_drive_status_u8 = Convert.ToByte(old_datass[57]);
            driver_set_velocity_u8 = Convert.ToByte(old_datass[58]);
            gsm_yenileme.Text = old_datass[59];
            driver_drive_command_u8 = Convert.ToByte(old_datass[60]);
            my_maks_hiz = Convert.ToByte(old_datass[61]);
            GL_kalan_yol_driver_u32 = Convert.ToUInt32(old_datass[62]);
            vcu_wake_up_command_u8 = Convert.ToByte(old_datass[63]);
            driver_error_u8 = Convert.ToByte(old_datass[64]);
            history_gps_write(old_latitudes, old_longtitudes);
            displayAllData();
        }
        static UInt16 old_tour = 1;
        static UInt32 GL_tour_distance_gps_old_u32;
        static string anlik_tur_suresi_old;

        


        void history_gps_write(double latitude, double longtitude)
        {


            if (tour != old_tour && (tour>old_tour))
            {
                gmap.Overlays.Clear();
                ortalama_hiz_f32 = Math.Round((float)(GL_gidilen_yol_tour_u32 / TimeSpan.Parse(anlik_tur_suresi_old).TotalSeconds) * 3.6, 2);
                ortalama_hiz_vcu_f32 = Math.Round((float)(GL_tour_distance_gps_old_u32 / (int)TimeSpan.Parse(anlik_tur_suresi_old).TotalSeconds) * 3.6, 2);
                dataGridView1.Rows.Add(old_tour, anlik_tur_suresi_old, GL_gidilen_yol_tour_u32, GL_tour_distance_gps_old_u32, ortalama_hiz_vcu_f32, ortalama_hiz_f32, GL_ems_bat_cons_tour_f32, GL_ems_fc_cons_tour_f32, GL_ems_fc_lt_cons_tour_f32);
                old_tour = tour;
            }

            else
            {
                GL_tour_distance_gps_old_u32 = GL_tour_distance_gps_u32;
                anlik_tur_suresi_old = anlik_tur_suresi.Text;


            }
            PointLatLng receivedPosition = new PointLatLng(latitude, longtitude);
            GMapMarker marker = new GMarkerGoogle(receivedPosition, GMarkerGoogleType.red_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
            gmap.Zoom += 0.00000001;
            gmap.Zoom -= 0.00000001;
        }
        void calculateTimeOperation()
        {
            gecen_sure_calc = (DateTime.Now - race_start_time);
            ortalama_tur_suresi.Text = ortalama_tur_suresi_time.ToString(@"hh\:mm\:ss");
            TimeSpan kalan_sure_calc = gecen_sure_calc.Subtract(TimeSpan.FromSeconds(3901));
            hedef_hiz.Text = Math.Round((-(GL_kalan_yol_driver_u32 / kalan_sure_calc.TotalSeconds) * 3.6), 2).ToString();
            ort_hiz.Text = Math.Round(((driver_odometer_u32 / gecen_sure_calc.TotalSeconds) * 3.6), 2).ToString();
            anlik_tur_suresi.Text = anlik_tur_süresi_time.Elapsed.Duration().ToString(@"hh\:mm\:ss");
            kalan_sure.Text = kalan_sure_calc.ToString(@"hh\:mm\:ss");
            gecen_sure.Text =  gecen_sure_calc.ToString(@"hh\:mm\:ss");
            other_datas = ortalama_tur_suresi.Text + '$' + anlik_tur_suresi.Text + '$' + kalan_sure.Text + '$' + gecen_sure.Text + '$' + turr.Text + '$' + ort_hiz.Text + '$' +  hedef_hiz.Text + '$';
            gelen_bayt.Text = GL_gelen_bayt_u32.ToString();
            baslik_hatali.Text = GL_baslik_hatali_u16.ToString();
            crc_hatali.Text = GL_crc_hatali_u16.ToString();
            cozulen_paket.Text = GL_cozulen_paket_u16.ToString();
            if (GL_gelen_bayt_u32 > 0)
                verim.Text = Math.Round(((float)GL_cozulen_paket_u16 * 49 / GL_gelen_bayt_u32), 2).ToString();
            if (grafik_baslat)
            {
                grafik_cizdir();
            }
        }

        private void bağlantıKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
             serialPort1.Close();
             xbee_durum.Text = "KAPALI";
        }

        private void bağlantıyıKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gsm_trigger.Enabled = false;
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gps_mouse_mod = false;
            calculate_about_race = false;
            time_counter.Enabled = false;
            anlik_tur_süresi_time.Stop();

            #region dataGridCalculateArea
            if (tour != 30)
            {
                int sure = (int)anlik_tur_süresi_time.Elapsed.TotalSeconds;

                GL_gidilen_yol_tour_u32 = driver_odometer_u32 - GL_gidilen_yol_toplayici_u32;
                GL_gidilen_yol_toplayici_u32 += GL_gidilen_yol_tour_u32;

                ortalama_hiz_f32 = Math.Round(((float)GL_tour_distance_gps_u32 / sure) * 3.6, 2);
                ortalama_hiz_vcu_f32 = Math.Round(((float)GL_gidilen_yol_tour_u32 / sure) * 3.6, 2);

                ortalama_tur_suresi_time = new TimeSpan(gecen_sure_calc.Ticks / tour);

                GL_ems_bat_cons_tour_f32 = ems_bat_cons_f32 - GL_ems_bat_cons_tour_toplayici_f32;
                GL_ems_bat_cons_tour_toplayici_f32 += GL_ems_bat_cons_tour_f32;

                GL_ems_fc_cons_tour_f32 = ems_fc_cons_f32 - GL_ems_fc_cons_tour_toplayici_f32;
                GL_ems_fc_cons_tour_toplayici_f32 += GL_ems_fc_cons_tour_f32;

                GL_ems_fc_lt_cons_tour_f32 = ems_fc_lt_cons_f32 - GL_ems_fc_lt_cons_tour_toplayici_f32;
                GL_ems_fc_lt_cons_tour_toplayici_f32 += GL_ems_fc_lt_cons_tour_f32;

                GL_ems_out_cons_tour_f32 = ems_out_cons_f32 - GL_ems_out_cons_tour_toplayici_f32;
                GL_ems_out_cons_tour_toplayici_f32 += GL_ems_out_cons_tour_f32;

                dataGridView1.Rows.Add(tour, anlik_tur_süresi_time.Elapsed.Duration().ToString(@"hh\:mm\:ss"), GL_gidilen_yol_tour_u32, GL_tour_distance_gps_u32, ortalama_hiz_vcu_f32, ortalama_hiz_f32, GL_ems_bat_cons_tour_f32, GL_ems_fc_cons_tour_f32, GL_ems_fc_lt_cons_tour_f32, GL_ems_out_cons_tour_f32);
            }
                #endregion
        }


        private void grafikEkranıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grafik_baslat = true;
        }

        private void grafikDurdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grafik_baslat = false;
        }

        private void hidromobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Legends[0].Enabled = true;
            chart1.Legends[1].Enabled = false;
        }

        private void batConsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(chart1.Series[0].Enabled == true)
            {
                chart1.Series[0].Enabled = false;
                bat_cons_draw = false;
            }

            else
            {
                chart1.Series[0].Enabled = true;
                bat_cons_draw = true;
            }

            
        }

        private void fcConsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chart1.Series[1].Enabled  == true)
            {
                chart1.Series[1].Enabled = false;
                fc_cons_draw = false;
            }

            else
            {
                chart1.Series[1].Enabled = true;
                fc_cons_draw = true;
            }
          
            
        }

        private void outConsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chart1.Series[2].Enabled == true)
            {
                chart1.Series[2].Enabled = false;
                out_cons_draw = false;
            }

            else
            {
                chart1.Series[2].Enabled = true;
                out_cons_draw = true;
            }
        }

        private void fcLtConsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chart1.Series[3].Enabled == true)
            {
                chart1.Series[3].Enabled = false;
                fc_lt_cons_draw = false;
            }

            else
            {
                chart1.Series[3].Enabled = true;
                fc_lt_cons_draw = true;
            }
        }

        void grafik_cizdir()
        {
            if (bat_cons_draw)
            {
                chart1.Series["Bat Cons"].Points.AddXY(gecen_sure.Text, ems_bat_cons_f32);
            }

            if (fc_cons_draw)
            {
                chart1.Series["Fc Cons"].Points.AddXY(gecen_sure.Text, ems_fc_cons_f32);
            }

            if (out_cons_draw)
            {
                chart1.Series["Out Cons"].Points.AddXY(gecen_sure.Text, ems_out_cons_f32);
            }

            if (fc_lt_cons_draw)
            {
                chart1.Series["Fc Lt Cons"].Points.AddXY(gecen_sure.Text, ems_fc_lt_cons_f32);
            }
        }

        
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                Axis xAxis = chart1.ChartAreas[0].AxisX;
                double xMin = xAxis.ScaleView.ViewMinimum;
                double xMax = xAxis.ScaleView.ViewMaximum;
                double xPixelPos = xAxis.PixelPositionToValue(e.Location.X);

                if (e.Delta < 0 && FZoomLevel > 0)
                {
                    // Scrolled down, meaning zoom out
                    if (--FZoomLevel <= 0)
                    {
                        FZoomLevel = 0;
                        xAxis.ScaleView.ZoomReset();
                    }
                    else
                    {
                        double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) * CZoomScale, 0);
                        double xEndPos = Math.Min(xStartPos + (xMax - xMin) * CZoomScale, xAxis.Maximum);
                        xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    }
                }
                else if (e.Delta > 0)
                {
                    // Scrolled up, meaning zoom in
                    double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) / CZoomScale, 0);
                    double xEndPos = Math.Min(xStartPos + (xMax - xMin) / CZoomScale, xAxis.Maximum);
                    xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    FZoomLevel++;
                }
            }
            catch { }
        }

        private void elektromobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Legends[1].Enabled = true;
            chart1.Legends[0].Enabled = false;
        }

        private void turAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region dataGridCalculateArea
            anlik_tur_süresi_time.Stop();
            int sure = (int)anlik_tur_süresi_time.Elapsed.TotalSeconds;

            GL_gidilen_yol_tour_u32 = driver_odometer_u32 - GL_gidilen_yol_toplayici_u32;
            GL_gidilen_yol_toplayici_u32 += GL_gidilen_yol_tour_u32;

            ortalama_hiz_f32 = Math.Round(((float)GL_tour_distance_gps_u32 / sure) * 3.6, 2);
            ortalama_hiz_vcu_f32 = Math.Round(((float)GL_gidilen_yol_tour_u32 / sure) * 3.6, 2);

            ortalama_tur_suresi_time = new TimeSpan(gecen_sure_calc.Ticks / tour);

            GL_ems_bat_cons_tour_f32 = ems_bat_cons_f32 - GL_ems_bat_cons_tour_toplayici_f32;
            GL_ems_bat_cons_tour_toplayici_f32 += GL_ems_bat_cons_tour_f32;

            GL_ems_fc_cons_tour_f32 = ems_fc_cons_f32 - GL_ems_fc_cons_tour_toplayici_f32;
            GL_ems_fc_cons_tour_toplayici_f32 += GL_ems_fc_cons_tour_f32;

            GL_ems_fc_lt_cons_tour_f32 = ems_fc_lt_cons_f32 - GL_ems_fc_lt_cons_tour_toplayici_f32;
            GL_ems_fc_lt_cons_tour_toplayici_f32 += GL_ems_fc_lt_cons_tour_f32;

            GL_ems_out_cons_tour_f32 = ems_out_cons_f32 - GL_ems_out_cons_tour_toplayici_f32;
            GL_ems_out_cons_tour_toplayici_f32 += GL_ems_out_cons_tour_f32;

            dataGridView1.Rows.Add(tour, anlik_tur_süresi_time.Elapsed.Duration().ToString(@"hh\:mm\:ss"), GL_gidilen_yol_tour_u32, GL_tour_distance_gps_u32, ortalama_hiz_vcu_f32, ortalama_hiz_f32, GL_ems_bat_cons_tour_f32, GL_ems_fc_cons_tour_f32, GL_ems_fc_lt_cons_tour_f32, GL_ems_out_cons_tour_f32);
            #endregion
            GL_tour_distance_gps_u32 = 0;
            tour++;
            turr.Text = tour.ToString();
            i = 0;
            anlik_tur_süresi_time.Restart();
            anlik_tur_süresi_time.Start();
            gmap.Overlays.Clear();
        }
    }
    }


