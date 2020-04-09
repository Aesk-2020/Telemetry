﻿using System;
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

        static int crc_hesaplanan = 0;
        
        //BURADAKI "data" degiskeninin turu degisecek "[]byte"
        #region veri
        float my_old_gsm_time = 0;
        float refresh_time;
        //string data = "10.03.2020 23:00:00.00000 -> Veri -> &0,0$0,0$0,0$0,00$0$0$3,14$14$25$1250$15$0,00$0,00$0,00$0,00$0,00$25,55$0$53$0$0$0$15$1$0$0";
       

        float bms_bat_volt_f32;
        float bms_bat_current_f32;
        float bms_bat_cons_f32;
        float bms_soc_f32;
        byte bms_error_u8;
        byte bms_dc_bus_state_u8;
        float bms_worst_cell_voltage_f32;
        byte bms_worst_cell_address_u8;
        byte bms_temp_u8;
        UInt32 driver_odometer_u32;
        byte driver_act_velocity_kmh_u8;
        float driver_phase_a_current_f32;
        float driver_phase_b_current_f32;
        float driver_phase_c_current_f32;
        float driver_dc_bus_current_f32;
        //float driver_phase_a_voltage_f32;
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
        byte anlik_hiz_u8;
        double ortalama_hiz_f32;
        double ortalama_hiz_vcu_f32;
        UInt32 GL_kalan_yol_u32 = 56000;
        UInt32 GL_kalan_yol_driver_u32;
        #endregion

        //MQTT
        MqttClient Client = new MqttClient("157.230.29.63");
        DateTime gsm_old_time;

        ListBox gelenler = new ListBox();
        bool error_flagg = false;
        string[] ports = SerialPort.GetPortNames();
        static readonly int max_incoming = 32;
        byte[] captured_data = new byte[max_incoming + 1];
        PointLatLng start1 = new PointLatLng(40.744392, 29.786054);
        PointLatLng lastposition = new PointLatLng(40.744392, 29.786054);
        bool gps_mouse_mod = true;
        readonly Int32 start1lat = 40744392;
        readonly Int32 start1long = 29786054;
        string port_selected;
      //  Stopwatch anlik_tur_süresi_time = new Stopwatch();
        TimeSpan gecen_sure_calc;
        TimeSpan ortalama_tur_suresi_time;
        DateTime race_start_time;
        bool first_start_area = false;
        bool calculate_about_race = false;
        UInt16 tour = 1;
        UInt32 GL_tour_distance_gps_u32 = 0;
        UInt32 GL_general_distance_gps_u32 = 0;

        string[] dizi = new string[1000];

        private void Form1_Load(object sender, EventArgs e)
        {
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

            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            maks_hiz.Text = captured_data[5].ToString();
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                int bytes = serialPort1.BytesToRead;
                byte[] buffer = new byte[bytes];

                int step = 0;
                int data_counter = 0;
                int counter = 0;

                serialPort1.Read(buffer, 0, bytes);

                for (int i = 0; i < bytes; i++)
                {
                    switch (step)
                    {                        
                        case 0:
                            {
                                if (buffer[i] == 97)
                                {
                                    
                                    step = 1;
                                    captured_data[data_counter] = buffer[i];
                                    counter = 1;
                                    data_counter = 1;
                                }
                                else
                                {                                    
                                                                        
                                }
                                break;
                            }
                        case 1:
                            {
                                captured_data[data_counter] = buffer[i];
                                data_counter++;
                                counter++;
                                if(buffer[i] == 100)

                                {
                                    step = 0;
                                    dataConvert(captured_data);
                                    crc_hesaplanan = (captured_data[16] << 8) | captured_data[15]; // crc gelecek yerler tayin ettikten sonra burayı değiştir
                                    ushort gelen_crc = aeskCRCCalculate(captured_data, 15);
                                    counter = 0;
                                    data_counter = 0;
                                }
                                /*if (counter > 27)
                                {
                                    step = 2;
                                    counter = 0;
                                    data_counter = 0;
                                } */
                                break;
                            }                       
                        /*case 2:
                            {
                                if (buffer[i] == 100)
                                {
                                    step = 0;
                                    dataConvert(captured_data); 0101 1100
                                }
                                break;
                            }*/
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

            try
            {
                bms_soc.Text = bms_soc_f32.ToString();
                bms_bat_cons.Text = bms_bat_cons_f32.ToString();
                bms_bat_current.Text = bms_bat_current_f32.ToString();
                bms_worst_cell_address.Text = bms_worst_cell_address_u8.ToString();
                bms_worst_cell_volt.Text = bms_worst_cell_voltage_f32.ToString();
                bms_temp.Text = bms_temp_u8.ToString();
                bms_bat_volt.Text = bms_bat_volt_f32.ToString();

                phase_a_cur.Text = driver_phase_a_current_f32.ToString();
                phase_b_cur.Text = driver_phase_b_current_f32.ToString();
                phase_c_cur.Text = driver_phase_c_current_f32.ToString();
            }
            catch
            {

            }



        }

        void gsmDataConvert()
        {/*
           
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

            try
            {
                latitude_f64 = (double)Convert.ToDouble(dataarray[20]);
                longtitude_f64 = (double)Convert.ToDouble(dataarray[21]);
            }
            catch
            {

            }
            

            anlik_hiz_u8 = Convert.ToByte(dataarray[22]);
            vcu_wake_up_command_u8 = Convert.ToByte(dataarray[23]);
            driver_error_u8 = Convert.ToByte(dataarray[25]);
            #endregion

           
            displayAllData();
            */
        }

        void gsmDataConvert_2(byte[] gelenVeri)
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
            

        }

        void displayAllData()
        {
            //if (calculate_about_race)

            #region logdata
            string log_data = bms_bat_volt_f32.ToString() + '$' +
                              bms_bat_current_f32.ToString() + '$' +
                              bms_bat_cons_f32.ToString() + '$' +
                              bms_soc_f32.ToString() + '$' +
                              bms_error_u8.ToString() + '$' +
                              bms_dc_bus_state_u8.ToString() + '$' +
                              bms_worst_cell_voltage_f32.ToString() + '$' +
                              bms_worst_cell_address_u8.ToString() + '$' +
                              bms_temp_u8.ToString() + '$' +                             
                              driver_odometer_u32.ToString() + '$' +
                              driver_act_velocity_kmh_u8.ToString() + '$' +
                              driver_phase_a_current_f32.ToString() + '$' +
                              driver_phase_b_current_f32.ToString() + '$' +
                              driver_phase_c_current_f32.ToString() + '$' +
                              driver_dc_bus_current_f32.ToString() + '$' +
                              //driver_phase_a_voltage_f32.ToString() + '$' +
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
                              vcu_wake_up_command_u8.ToString() + '$' +
                              driver_error_u8.ToString() + '$' +
                              "\n";
            // File.AppendAllText(pathfile + filename, other_datas + gps_datas + log_data); //OTHER DATAS KULLANILACAK CALC TIME OP DA
            #endregion
            #region wake_up_control
            if ((vcu_wake_up_command_u8 & 0b00000001) != 0)
            {
                bms_durum.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                bms_durum.BackColor = Color.Transparent;
            }

            if ((vcu_wake_up_command_u8 & 0b00000010) != 0)
            {
                driver_durum.BackColor = Color.FromArgb(47, 136, 202);
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
                bms_high_volt_error.BackColor = Color.FromArgb(47, 136, 202);
            }

            if ((bms_error_u8 & 0b00000010) != 0)
            {
                bms_low_volt_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_low_volt_error.BackColor = Color.FromArgb(47, 136, 202);
            }

            if ((bms_error_u8 & 0b00000100) != 0)
            {
                bms_temp_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_temp_error.BackColor = Color.FromArgb(47, 136, 202);
            }

            if ((bms_error_u8 & 0b00001000) != 0)
            {
                bms_comm_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_comm_error.BackColor = Color.FromArgb(47, 136, 202);
            }

            if ((bms_error_u8 & 0b00010000) != 0)
            {
                bms_over_cur_error.BackColor = Color.Transparent;
            }
            else
            {
                bms_over_cur_error.BackColor = Color.FromArgb(47, 136, 202);
            }
            #endregion
            #region dc_bus_state
            if ((bms_dc_bus_state_u8 & 0b00000001) != 0)
            {
                bms_precharge_flag.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                bms_precharge_flag.BackColor = Color.Transparent;
            }

            if ((bms_dc_bus_state_u8 & 0b00000010) != 0)
            {
                bms_discharge_flag.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                bms_discharge_flag.BackColor = Color.Transparent;
            }

            if ((bms_dc_bus_state_u8 & 0b00000100) != 0)
            {
                bms_dc_bus_ready_flag.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                bms_dc_bus_ready_flag.BackColor = Color.Transparent;
            }
            #endregion
            #region driver_text_write
            gidilen_yol_gps.Text = driver_odometer_u32.ToString();
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
            hedef_hiz.Text = driver_set_velocity_u8.ToString();
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
                zpc.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                zpc.BackColor = Color.Transparent;
            }
            if ((driver_error_u8 & 0b00000010) != 0)
            {
                pwm_enabled.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                pwm_enabled.BackColor = Color.Transparent;
            }

            if ((driver_error_u8 & 0b00000100) != 0)
            {
                dc_bus_voltage_error.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                dc_bus_voltage_error.BackColor = Color.Transparent;
            }

            if ((driver_error_u8 & 0b00001000) != 0)
            {
                motor_temp_error.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                motor_temp_error.BackColor = Color.Transparent;
            }

            if ((driver_error_u8 & 0b00010000) != 0)
            {
                dc_bus_amper_error.BackColor = Color.FromArgb(47, 136, 202);
            }
            else

            {
                dc_bus_amper_error.BackColor = Color.Transparent;
            }
            if ((driver_error_u8 & 0b00100000) != 0)
            {
                id_error.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                id_error.BackColor = Color.Transparent;
            }
            #endregion

        }

        private void displayGauges()
        {
            anlikhiz_gauge.Value = (driver_act_velocity_kmh_u8 / 60) * 100;
            gpshiz_gauge.Value = (anlik_hiz_u8 / 60) * 100;
            hedefhiz_gauge.Value = (driver_set_velocity_u8 / 60) * 100;
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

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Clear();
            gmap.Zoom += 0.00000001;
            gmap.Zoom -= 0.00000001;
        }

        private void bağlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gsm_trigger.Start();

            byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");
            Client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;

            //SERVERDEN YANIT BAGLANDI BAGLANILAMADI
            if (code == 0x00)
            {
                //Connected
                gsm_durum.BackColor = Color.FromArgb(47, 136, 202);
            }
            else
            {
                //Connection Refused
                gsm_durum.BackColor = Color.FromArgb(199, 10, 32);
            }


            //SERVER KABUL ETTI MI BIZI
            try
            {
                Client.Subscribe(new string[] { "home/sensor" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            }

            catch (Exception ex)
            {
                //Subscribe error

            }

            DateTime a = DateTime.Now;
        }

        private void bağlantıyıKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
            gsm_durum.BackColor = Color.FromArgb(199, 10, 32);
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

        }


        /*
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
            gsmDataConvert();
            }

            catch
            {

                gsm_durum.BackColor = Color.Transparent;
                gsm_trigger.Enabled = false;                              

            }
        }*/

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            DateTime gsm_new_time = DateTime.Now;
            double total_sec = (gsm_new_time - gsm_old_time).TotalSeconds;

            byte[] mqtt_data = e.Message;

            gsmDataConvert_2(mqtt_data);
            //gsmDataConvert_2(e.Message);

            //RECEIVE 
            displayAllData();

            //RECEIVE
            gsm_old_time = gsm_new_time;
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
            driver_act_velocity_kmh_u8 = Convert.ToByte(old_datass[43]);
            driver_phase_a_current_f32 = float.Parse(old_datass[44]);
            driver_phase_b_current_f32 = float.Parse(old_datass[45]);
            driver_phase_c_current_f32 = float.Parse(old_datass[46]);
            driver_dc_bus_current_f32 = float.Parse(old_datass[47]);
            //driver_phase_a_voltage_f32 = float.Parse(old_datass[48]);
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

    }
}
