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
using System.IO;
using System.Threading;
using System.Net;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace yeniform
{
    public partial class telemetry : Form
    {
        public telemetry()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        static int gelen_crc = 0;
        static int gelen_crc_bms = 0;
        string other_datas;
        #region veri
        float my_old_gsm_time = 0;
        float refresh_time;

     
        //BMS
        float bms_bat_volt_f32; // bu graphda olacak
        float bms_bat_current_f32; // bu da olacak
        // bi de bunlarin carpimlari
        float bms_bat_cons_f32; 
        float bms_soc_f32;
        byte  bms_error_u8;
        byte  bms_dc_bus_state_u8; 
        float bms_worst_cell_voltage_f32;
        byte  bms_worst_cell_address_u8;
        byte  bms_temp_u8;

        //Driver
        static public UInt32 driver_odometer_u32;

        //bu 3
        static public float  driver_phase_a_current_f32;
        static public float  driver_phase_b_current_f32;
        static public float  driver_dc_bus_current_f32;


        static public float  driver_dc_bus_voltage_f32;// bu yok

        //bu 4 olacak
        static public float  driver_id_f32;
        static public float  driver_iq_f32;
        static public float  driver_vd_f32;
        static public float  driver_vq_f32;
        
        static public byte   driver_actual_velocity_u8;
        static public byte   driver_motor_temperature_u8;
        static public byte   driver_drive_status_u8;
        static public byte   driver_error_u8;

        //VCU
        byte vcu_wake_up_u8;
        byte vcu_set_velocity_u8;
        byte vcu_drive_commands_u8;

        //GPS
        double gps_latitude_f64 = 40.744392;
        double gps_longtitude_f64 = 29.786054;
        byte   gps_velocity_u8;
        byte   gps_sattelite_number_u8;
        byte   gps_efficiency_u8;
        string gps_datas;

        //RF Kontrol
        UInt16 GL_baslik_hatali_u16;
        UInt16 GL_crc_hatali_u16;
        UInt32 GL_gelen_bayt_u32;
        UInt16 GL_cozulen_paket_u16;

        //MQTT
        MqttClient Client = new MqttClient("157.230.29.63");
        int MQTT_counter_int32 = 0;

        //Define
        static readonly int GPS_DIVIDE = 1000000;
        static readonly UInt32 TOTAL_BYTES = 43;
        public const int BMS_PACK = 5;
        public const int BMS_PACK_RECOGNIZE = 6;

        //Arayüz verileri
        byte my_maks_hiz = 0;
        double ortalama_hiz_f32;
        double ortalama_hiz_vcu_f32;
        //byte driver_set_torque_u8;
        UInt32 GL_kalan_yol_u32 = 56000;
        UInt32 GL_kalan_yol_driver_u32;
        string pathfile = @"Logs\";
        string filename = DateTime.Now.ToString("yyyy_MM_dd_HH_mm") + ".txt";
        ListBox gelenler = new ListBox();
        bool error_flagg = false;
        string[] ports = SerialPort.GetPortNames();
        Color AeskBlue = new Color();

        
        byte[] captured_data = new byte[TOTAL_BYTES + 1];
        PointLatLng start1 = new PointLatLng(40.744392, 29.786054);
        PointLatLng lastposition = new PointLatLng(40.744392, 29.786054);
        bool gps_mouse_mod = false;
        readonly Int32 start1lat = 40744392;
        readonly Int32 start1long = 29786054;
        string port_selected;
        Stopwatch anlik_tur_süresi_time = new Stopwatch();
        TimeSpan gecen_sure_calc;
        TimeSpan ortalama_tur_suresi_time;
        DateTime race_start_time; 

        bool first_start_area = false;
        static public bool calculate_about_race = false;
        
        UInt16 tour = 1;
        UInt32 GL_tour_distance_gps_u32 = 0;
        UInt32 GL_general_distance_gps_u32 = 0;

        #endregion

        string[] dizi = new string[1000];

        private void Form1_Load(object sender, EventArgs e)
        {
            AeskBlue = Color.FromArgb(47, 136, 202);
            history_displayer.ValueChanged -= new EventHandler(this.history_displayer_ValueChanged);
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
            anlikhiz_gauge.Value = 75;
            go_graphs_button.Enabled = false;
        }

        //mqtt koparsa otomatik rf'e geçme
        private void timer1_Tick(object sender, EventArgs e)
        {
            calculateTimeOperation();           
            double delay_second = (DateTime.Now - mqtt_reference_time).TotalSeconds;
            if (delay_second > 3)
            {
                
                gsm_durum.BackColor = Color.Transparent;
                try
                {
                    if (serialPort1.IsOpen == false)
                    {
                        serialPort1.PortName = port_selected;
                        serialPort1.BaudRate = 9600;
                        serialPort1.Open();
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                        if (serialPort1.IsOpen == true)
                        {
                            xbee_active.BackColor = AeskBlue;
                        }
                    }
                }
                catch
                {
                    if (error_flagg == false)
                    {
                        error_flagg = true;
                        MessageBox.Show("Bağlanılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                 
        }

        static int step = 0;
        static int data_counter = 0;
        static int BMS_data_type = 0;
        static int BMS_message_length = 0;

        //time operations eklenebilir, thread invoke gibi arka planda çalışsın
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                int bytes = serialPort1.BytesToRead;
                byte[] buffer = new byte[bytes];
                GL_gelen_bayt_u32 += (UInt32)bytes;

                serialPort1.Read(buffer, 0, bytes);

                for (int i = 0; i < bytes; i++)
                {
                    switch (step)
                    {         
                        //TELEMETRİ PAKETİ

                        case 0:
                            {
                                if (buffer[i] == 97)
                                {                                    
                                    step = 1;
                                    captured_data[data_counter] = buffer[i];
                                    data_counter = 1;
                                }
                                else if(buffer[i] == 0xA0) //paket bms verilerini içeriyorsa o veriler basılacak
                                {
                                    step = BMS_PACK_RECOGNIZE;
                                    captured_data[data_counter] = buffer[i];
                                    data_counter = 1;
                                }
                                else
                                {
                                    GL_baslik_hatali_u16++;
                                    step = 0;
                                }
                                break;
                            }
                        case 1:
                            {
                                captured_data[data_counter] = buffer[i];
                                data_counter++;
                                if(data_counter >= TOTAL_BYTES)
                                {
                                    data_counter = 0;
                                    gelen_crc = (captured_data[TOTAL_BYTES] << 8) | captured_data[TOTAL_BYTES - 1]; // CRC son iki byte
                                    ushort crc_hesaplanan = aeskCRCCalculate(captured_data, TOTAL_BYTES - 2);
                                    if(crc_hesaplanan == gelen_crc)
                                    {
                                        GL_cozulen_paket_u16++;
                                        dataConvert_2(captured_data);
                                        displayAllData();
                                        displayGauges();
                                    }
                                    else
                                    {
                                        GL_crc_hatali_u16++;
                                    }
                                    step = 0;
                                }                              
                                break;
                            }

                            //BMS PAKETİ 

                        case BMS_PACK_RECOGNIZE:
                            {
                                BMS_data_type = buffer[i] >> 6;
                                BMS_message_length = buffer[i] & 0b00111111;
                                step = BMS_PACK;
                                break;
                            }
                        case BMS_PACK:
                            {
                                captured_data[data_counter] = buffer[i];
                                data_counter++;

                                if(data_counter > (BMS_message_length + 2))
                                {
                                    gelen_crc_bms = (captured_data[BMS_message_length + 1] << 8) | captured_data[BMS_message_length];
                                    ushort crc_hesaplanan = aeskCRCCalculate(captured_data, Convert.ToUInt32(BMS_message_length));
                                    if(gelen_crc_bms == crc_hesaplanan)
                                    {
                                        //do something for nature, making electric cars is not enough you know..
                                    }
                                }
                                break;
                            }
                        default: break;
                    }
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
                data = (byte)((byte)data ^ (byte)(data << 4));
                crc16_data = (ushort)((((ushort)data << 8) | ((crc16_data & 0xFF00) >> 8)) ^ (byte)(data >> 4) ^ ((ushort)data << 3));
            }
            return (crc16_data);
        }
        
        void dataConvert_2(byte[] gelenVeri)
        {
            vcu_wake_up_u8 = gelenVeri[0];
            vcu_drive_commands_u8 = gelenVeri[1];
            vcu_set_velocity_u8 = gelenVeri[2];

            driver_phase_a_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 3) / 100;
            driver_phase_b_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 5) / 100;
            driver_dc_bus_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 7) / 100;
            driver_dc_bus_voltage_f32 = (float)BitConverter.ToUInt16(gelenVeri, 9) / 10;
            driver_id_f32 = (float)BitConverter.ToInt16(gelenVeri, 11) / 100;
            driver_iq_f32 = (float)BitConverter.ToInt16(gelenVeri, 13) / 100;
            driver_vd_f32 = (float)BitConverter.ToInt16(gelenVeri, 15) / 100;
            driver_vq_f32 = (float)BitConverter.ToInt16(gelenVeri, 17) / 100;
            driver_drive_status_u8 = gelenVeri[19];
            driver_error_u8 = gelenVeri[20];
            driver_odometer_u32 = BitConverter.ToUInt32(gelenVeri, 21);
            driver_motor_temperature_u8 = gelenVeri[25];
            driver_actual_velocity_u8 = gelenVeri[26];

            bms_bat_volt_f32 = (float)BitConverter.ToUInt16(gelenVeri, 27) / 10;
            bms_bat_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 29) / 100;
            bms_bat_cons_f32 = (float)BitConverter.ToInt16(gelenVeri, 31) / 10;
            bms_soc_f32 = (float)BitConverter.ToUInt16(gelenVeri, 33) / 100;
            bms_error_u8 = gelenVeri[35];
            bms_dc_bus_state_u8 = gelenVeri[36];
            bms_worst_cell_voltage_f32 = (float)BitConverter.ToUInt16(gelenVeri, 37) / 10;
            bms_worst_cell_address_u8 = gelenVeri[39];
            bms_temp_u8 = gelenVeri[40];

            gps_latitude_f64 = (float)BitConverter.ToInt64(gelenVeri, 41) / GPS_DIVIDE;
            gps_longtitude_f64 = (float)BitConverter.ToInt64(gelenVeri, 45) / GPS_DIVIDE;
            gps_velocity_u8 = gelenVeri[49];
            gps_sattelite_number_u8 = gelenVeri[50];
            gps_efficiency_u8 = gelenVeri[51];

            MQTT_counter_int32 = BitConverter.ToInt32(gelenVeri, 52);            
        }

        void gsmDataConvert()
        {
            #region kullanılabilir
            /*
           
            #region Yenilenecek_1
            float myhour = float.Parse(data.Substring(11, 2));
            float myminute = float.Parse(data.Substring(14, 2));
            float mysecond = float.Parse(data.Substring(17, 2));
            float mymillisecond = float.Parse(data.Substring(20, 3));
            float my_gsm_time = (myhour * 360000) + (myminute * 60000) + (mysecond * 1000) + mymillisecond;
            float my_gsm_time_millisecond = my_gsm_time;
            #endregion

            if (my_old_gsm_time == 0)
            {
                my_old_gsm_time = my_gsm_time;
            }

            if (my_gsm_time == my_old_gsm_time)
            {
                gsm_yenileme.Text = "NND";
            }

            else
            {
                refresh_time = my_gsm_time_millisecond - my_old_gsm_time;
                gsm_yenileme.Text = refresh_time.ToString();
                my_old_gsm_time = my_gsm_time_millisecond;
            }

            #region yenilenecek_2
            data = data.Split('&').Last();
            data = data.Replace('.', ','); //  data.Replace('.', ',')
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
            #endregion

            driver_odometer_u32 = Convert.ToUInt32(dataarray[9]);

            #region yenilenecek_3
            GL_kalan_yol_driver_u32 = 56000 - driver_odometer_u32;
            driver_actual_velocity_u8 = Convert.ToByte(dataarray[10]);
            driver_phase_a_current_f32 = float.Parse(dataarray[11]);
            driver_phase_b_current_f32 = float.Parse(dataarray[12]);
            driver_phase_c_current_f32 = float.Parse(dataarray[13]);
            driver_dc_bus_current_f32 = float.Parse(dataarray[14]);
            driver_dc_bus_voltage_f32 = float.Parse(dataarray[15]);
            driver_motor_temperature_u8 = float.Parse(dataarray[16]);
            driver_drive_status_u8 = Convert.ToByte(dataarray[17]);
            vcu_set_velocity_u8 = Convert.ToByte(dataarray[18]);
            vcu_drive_commands_u8 = Convert.ToByte(dataarray[19]);

            try
            {
                gps_latitude_f64 = (double)Convert.ToDouble(dataarray[20]);
                gps_longtitude_f64 = (double)Convert.ToDouble(dataarray[21]);
            }
            catch
            {

            }
            

            anlik_hiz_u8 = Convert.ToByte(dataarray[22]);
            vcu_wake_up_u8 = Convert.ToByte(dataarray[23]);
            driver_error_u8 = Convert.ToByte(dataarray[25]);
            #endregion

           
            displayAllData();
            */
            #endregion
        }

        void displayAllData()
        {
            //if (calculate_about_race)

            #region logdata
            string log_data = 
                
                              vcu_wake_up_u8.ToString() + '$' +  
                              vcu_drive_commands_u8.ToString() + '$' +
                              vcu_set_velocity_u8.ToString() + '$' +

                              driver_phase_a_current_f32.ToString() + '$' +
                              driver_phase_b_current_f32.ToString() + '$' +
                              driver_dc_bus_current_f32.ToString() + '$' +
                              driver_dc_bus_voltage_f32.ToString() + '$' +
                              driver_id_f32.ToString() + '$' +
                              driver_iq_f32.ToString() + '$' +
                              driver_vd_f32.ToString() + '$' +
                              driver_vq_f32.ToString() + '$' +
                              driver_drive_status_u8.ToString() + '$' +
                              driver_error_u8.ToString() + '$' +
                              driver_odometer_u32.ToString() + '$' +
                              driver_motor_temperature_u8.ToString() + '$' +
                              driver_actual_velocity_u8.ToString() + '$' +

                              bms_bat_volt_f32.ToString() + '$' +
                              bms_bat_current_f32.ToString() + '$' +
                              bms_bat_cons_f32.ToString() + '$' +
                              bms_soc_f32.ToString() + '$' +
                              bms_error_u8.ToString() + '$' +
                              bms_dc_bus_state_u8.ToString() + '$' +
                              bms_worst_cell_voltage_f32.ToString() + '$' +
                              bms_worst_cell_address_u8.ToString() + '$' +
                              bms_temp_u8.ToString() + '$' +             
                              
                              gps_latitude_f64.ToString() + '$'+
                              gps_longtitude_f64.ToString() + '$' +
                              gps_velocity_u8.ToString() + '$' +

                              gsm_yenileme.Text + '$' +
                              my_maks_hiz.ToString() + '$' +
                              GL_kalan_yol_driver_u32.ToString() + '$' +
                               
                             
                              "\n";
         //   File.AppendAllText(pathfile + filename, other_datas + gps_datas + log_data); //OTHER DATAS KULLANILACAK CALC TIME OP DA
            #endregion
            #region wake_up_control
            if ((vcu_wake_up_u8 & 0b00000001) != 0)
            {
                bms_durum.BackColor = AeskBlue;
            }
            else
            {
                bms_durum.BackColor = Color.Transparent;
            }

            if ((vcu_wake_up_u8 & 0b00000010) != 0)
            {
                driver_durum.BackColor = AeskBlue;
            }
            else
            {
                driver_durum.BackColor = Color.Transparent;
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
                bms_high_volt_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_high_volt_error.BackColor = AeskBlue;
            }

            if ((bms_error_u8 & 0b00000010) != 0)
            {
                bms_low_volt_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_low_volt_error.BackColor = AeskBlue;
            }

            if ((bms_error_u8 & 0b00000100) != 0)
            {
                bms_temp_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_temp_error.BackColor = AeskBlue;
            }

            if ((bms_error_u8 & 0b00001000) != 0)
            {
                bms_comm_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_comm_error.BackColor = AeskBlue;
            }

            if ((bms_error_u8 & 0b00010000) != 0)
            {
                bms_over_cur_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_over_cur_error.BackColor = AeskBlue;
            }
            #endregion
            #region dc_bus_state
            if ((bms_dc_bus_state_u8 & 0b00000001) != 0)
            {
                bms_precharge_flag.BackColor = AeskBlue;
            }
            else
            {
                bms_precharge_flag.BackColor = Color.Transparent;
            }

            if ((bms_dc_bus_state_u8 & 0b00000010) != 0)
            {
                bms_discharge_flag.BackColor = AeskBlue;
            }
            else
            {
                bms_discharge_flag.BackColor = Color.Transparent;
            }

            if ((bms_dc_bus_state_u8 & 0b00000100) != 0)
            {
                bms_dc_bus_ready_flag.BackColor = AeskBlue;
            }
            else
            {
                bms_dc_bus_ready_flag.BackColor = Color.Transparent;
            }
            #endregion
            #region driver_text_write
            gidilen_yol_gps.Text = driver_odometer_u32.ToString();
            anlik_hiz.Text = driver_actual_velocity_u8.ToString();
            anlik_hiz_gps.Text = gps_velocity_u8.ToString();
            set_hiz.Text = vcu_set_velocity_u8.ToString();
            my_maks_hiz = driver_actual_velocity_u8 > my_maks_hiz ? driver_actual_velocity_u8 : my_maks_hiz;
            maks_hiz.Text = my_maks_hiz.ToString();
            phase_a_cur.Text = driver_phase_a_current_f32.ToString();
            phase_b_cur.Text = driver_phase_b_current_f32.ToString();
            dc_bus_cur.Text = driver_dc_bus_current_f32.ToString();
            dc_bus_volt.Text = driver_dc_bus_voltage_f32.ToString();
            motor_temp.Text = driver_motor_temperature_u8.ToString();
            id.Text = driver_id_f32.ToString();
            act_torque.Text = Math.Round(((float)driver_id_f32 * 0.45), 2).ToString();
            iq.Text = driver_iq_f32.ToString();
            vd.Text = driver_vd_f32.ToString();
            vq.Text = driver_vq_f32.ToString();
            hedef_hiz.Text = vcu_set_velocity_u8.ToString();
            kalan_yol_gps.Text = GL_kalan_yol_driver_u32.ToString();
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

            if ((vcu_drive_commands_u8 & 0b00000001) != 0)
            {
                driver_fwrv_command.Text = "REVERSE";
            }
            else
            {
                driver_fwrv_command.Text = "FORWARD";
            }

            if ((vcu_drive_commands_u8 & 0b00000010) != 0)
            {
                driver_brake_command.Text = "BRAKE ON";
            }
            else
            {
                driver_brake_command.Text = "BRAKE OFF";
            }

            if ((vcu_drive_commands_u8 & 0b00000100) != 0)
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
                zpc.BackColor = AeskBlue;
            }
            else
            {
                zpc.BackColor = Color.Transparent;
            }
            if ((driver_error_u8 & 0b00000010) != 0)
            {
                pwm_enabled.BackColor = AeskBlue;
            }
            else
            {
                pwm_enabled.BackColor = Color.Transparent;
            }

            if ((driver_error_u8 & 0b00000100) != 0)
            {
                dc_bus_voltage_error.BackColor = AeskBlue;
            }
            else
            {
                dc_bus_voltage_error.BackColor = Color.Transparent;
            }

            if ((driver_error_u8 & 0b00001000) != 0)
            {
                motor_temp_error.BackColor = AeskBlue;
            }
            else
            {
                motor_temp_error.BackColor = Color.Transparent;
            }

            if ((driver_error_u8 & 0b00010000) != 0)
            {
                dc_bus_amper_error.BackColor = AeskBlue;
            }
            else

            {
                dc_bus_amper_error.BackColor = Color.Transparent;
            }
            if ((driver_error_u8 & 0b00100000) != 0)
            {
                id_error.BackColor = AeskBlue;
            }
            else
            {
                id_error.BackColor = Color.Transparent;
            }
            #endregion
            #region rf_kontrol
            baslik_hatali.Text = GL_baslik_hatali_u16.ToString();
            cozulen_paket.Text = GL_cozulen_paket_u16.ToString();
            crc_hatali.Text = GL_crc_hatali_u16.ToString();
            #endregion

            gelen_bayt.Text = GL_gelen_bayt_u32.ToString();
            baslik_hatali.Text = GL_baslik_hatali_u16.ToString();
            
           
            if (GL_gelen_bayt_u32 > 0)
                verim.Text = Math.Round(((float)GL_cozulen_paket_u16 * TOTAL_BYTES / GL_gelen_bayt_u32), 2).ToString();

        }

        private void displayGauges()
        {
            anlikhiz_gauge.Value = ((driver_actual_velocity_u8 * 100) / 60);
            gpshiz_gauge.Value = ((gps_velocity_u8 * 100) / 60);
            hedefhiz_gauge.Value = ((vcu_set_velocity_u8 * 100) / 60);
            kalanyol_bar.Value = Convert.ToInt32(((driver_odometer_u32 * 100) / (driver_odometer_u32 + GL_kalan_yol_u32)));
        }

        private void portToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            portToolStripMenuItem.DropDownItems.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portToolStripMenuItem.DropDownItems.Add(port);
            }
        }

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
            gmap.Zoom += 0.00000001;
            gmap.Zoom -= 0.00000001;

            gps_datas = latitude.ToString() + '$' +
                    longtitude.ToString() + '$' +
                    GL_gidilen_yol_tour_u32.ToString() + '$' +
                    GL_tour_distance_gps_u32.ToString() + '$' +
                    GL_general_distance_gps_u32.ToString() + '$' +
                    tour.ToString() + '$' +
                    kalan_yol_gps.Text + '$' +
                    gidilen_yol_gps.Text + '$' +
                    GL_ems_bat_cons_tour_f32.ToString() + '$' +
                    GL_ems_fc_cons_tour_f32.ToString() + '$' +
                    GL_ems_fc_lt_cons_tour_f32.ToString() + '$'
                    ;
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
          
            if (gps_mouse_mod && e.Button == MouseButtons.Left)
            {
                PointLatLng mouse_position = gmap.FromLocalToLatLng(e.X, e.Y);
                gps_yazdir(Math.Round(mouse_position.Lat, 6), Math.Round(mouse_position.Lng, 6));

            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }



        DateTime mqtt_reference_time;

        private void bağlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");
            Client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            
            //SERVERDEN YANIT BAGLANDI BAGLANILAMADI
            if (code == 0x00)
            {
                //Connected
                gsm_durum.BackColor = AeskBlue;
                timer1.Start();
                go_graphs_button.Enabled = true;
            }
            else
            {
                //Connection Refused
                gsm_durum.BackColor = Color.Transparent;
            }


            //SERVER BIZI KABUL ETTI MI
            try
            {
                Client.Subscribe(new string[] { "home/sensor" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            }

            catch (Exception ex)
            {
                //Subscribe error

            }

            mqtt_reference_time = DateTime.Now;
           
        }

        private void bağlantıyıKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
            gsm_durum.BackColor = Color.Transparent;
            //event kapama
            Client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
        }

        private void bağlanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = port_selected;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    if (serialPort1.IsOpen == true)
                    {
                        xbee_active.BackColor = Color.Green;
                        go_graphs_button.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bağlanılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bağlantıyıKesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                if(serialPort1.IsOpen == false)
                {
                    xbee_active.BackColor = Color.Transparent;
                }
            }
        }

        private void portToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            port_selected = e.ClickedItem.Text;
        }

        private void go_cells_button_Click(object sender, EventArgs e)
        {
            BMS bmsform = new BMS();
            bmsform.Show();
        }

        private void go_graphs_button_Click(object sender, EventArgs e)
        {
            graph_form grafiklerr = new graph_form();
            grafiklerr.Show();
        }

        public static DateTime old_time;
        public static double totalTime = 0;
        public static int mqtt_total_counter = 0;
        int error_counter = 0;

        int mqtt_counter_old = 0;


        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //sayacin eskisini olda atiyoruz
            mqtt_counter_old = MQTT_counter_int32;
            

            //bu ne mk
            //counter ++;'i direkt bunun altina aldim
            // payda 0 olmamali oran hesaplarinda
            if (mqtt_total_counter == 0)
            {
                old_time = DateTime.Now;
            }
            mqtt_total_counter++;

            DateTime current_time = DateTime.Now;
            totalTime += (current_time - old_time).TotalMilliseconds;

            DateTime gsm_new_time = DateTime.Now;
            double total_sec = (gsm_new_time - mqtt_reference_time).TotalSeconds;


            byte[] mqtt_data = e.Message;

            //burada MQTT_counter_int32 guncelleniyor
            dataConvert_2(mqtt_data);
            // (old, new)
            //uyari: yukarida old ve MQTT_counteri =0 ile baslangicta tanimladik
            // ilk veri geldiginde old = 0 new = gelen olacak
            //find error fonksiyonu old 0 sa default 0 donduruyor
            //yani ilk veride hata varsa bilemeyecez

            error_counter += find_error(mqtt_counter_old,MQTT_counter_int32);
            

            double c = Convert.ToDouble(error_counter) / Convert.ToDouble(mqtt_total_counter);

            
            gsm_yenileme.Text = (totalTime / (double)mqtt_total_counter).ToString();

            //RECEIVE 
            displayAllData();
            displayGauges();
            //RECEIVE

            old_time = current_time;


            
            // gerekli yerlere yazdik
            mqtt_reference_time = gsm_new_time;
            mqtt_toplam_paket.Text = mqtt_total_counter.ToString();
            mqtt_solved_paket.Text = (mqtt_total_counter - error_counter).ToString();
            mqtt_verim.Text = string.Format("{0:N2}%", c);

        }

        int find_error(int old_d, int new_d)
        {

            int x = new_d - old_d;
            //hata olup olmadigini anlamak icin en az 2 veri gelmeli
            //biz old_d yi basta 0 set ettik
            //yani ilk veri 24 gelince 24 hatamiz olmamali
            if (old_d == 0)
            {
                return 0;
            }

            return Math.Abs(x - 1);

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
            go_graphs_button.Enabled = true;
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
            set_hiz.Text = old_datass[6];
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
            driver_odometer_u32 = Convert.ToUInt32(old_datass[42]);
            driver_actual_velocity_u8 = Convert.ToByte(old_datass[43]);
            driver_phase_a_current_f32 = float.Parse(old_datass[44]);
            driver_phase_b_current_f32 = float.Parse(old_datass[45]);
            driver_dc_bus_current_f32 = float.Parse(old_datass[47]);
            driver_dc_bus_voltage_f32 = float.Parse(old_datass[51]);
            //driver_motor_temperature_u8 = float.Parse(old_datass[52]);
            driver_id_f32 = float.Parse(old_datass[53]);
            driver_iq_f32 = float.Parse(old_datass[54]);
            driver_vd_f32 = float.Parse(old_datass[55]);
            driver_vq_f32 = float.Parse(old_datass[56]);
            driver_drive_status_u8 = Convert.ToByte(old_datass[57]);
            vcu_set_velocity_u8 = Convert.ToByte(old_datass[58]);
            gsm_yenileme.Text = old_datass[59];
            vcu_drive_commands_u8 = Convert.ToByte(old_datass[60]);
            my_maks_hiz = Convert.ToByte(old_datass[61]);
            GL_kalan_yol_driver_u32 = Convert.ToUInt32(old_datass[62]);
            vcu_wake_up_u8 = Convert.ToByte(old_datass[63]);
            driver_error_u8 = Convert.ToByte(old_datass[64]);
            history_gps_write(old_latitudes, old_longtitudes);
            displayGauges();
            displayAllData();
        }

        static UInt16 old_tour = 1;
        static UInt32 GL_tour_distance_gps_old_u32;
        static string anlik_tur_suresi_old;
        static UInt32 GL_gidilen_yol_tour_u32;
        static float GL_ems_bat_cons_tour_f32;
        static float GL_ems_fc_cons_tour_f32;
        static float GL_ems_fc_lt_cons_tour_f32;

        void history_gps_write(double latitude, double longtitude)
        {

            if (tour != old_tour && (tour > old_tour))
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
            gecen_sure.Text = gecen_sure_calc.ToString(@"hh\:mm\:ss");
            
            other_datas = ortalama_tur_suresi.Text + '$' + anlik_tur_suresi.Text + '$' + kalan_sure.Text + '$' + gecen_sure.Text + '$' + turr.Text + '$' + ort_hiz.Text + '$' + hedef_hiz.Text + '$';
        }
        
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void gmap_sag_Opening(object sender, CancelEventArgs e)
        {

        }

        private void GpsMouseModAktif_Click(object sender, EventArgs e)
        {
            gps_mouse_mod = true;
        }

        private void GpsMouseModDeaktif_Click(object sender, EventArgs e)
        {
            gps_mouse_mod = false;
        }

        private void MarkerTemizlee_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Clear();
            gmap.Zoom += 0.00000001;
            gmap.Zoom -= 0.00000001;
        }
    }
}
