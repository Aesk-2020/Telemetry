using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

using System.Net;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace MqttPublissssh
{
    public partial class Form1 : Form
    {
        byte wake_up_u8 = 0;
        byte drive_command_u8 = 0;
        byte set_velocity = 0;

        Int16 phase_a_current_f32 = 0;
        Int16 phase_b_current_f32 = 0;
        Int16 dc_bus_current_f32 = 0;
        UInt16 dc_bus_voltage_f32 = 0;
        Int16 ID_f32 = 0;
        Int16 IQ_f32 = 0;
        Int16 VD_f32 =0;
        Int16 VQ_f32 = 0;
        byte drive_status_u8 = 0;
        byte driver_error_u8 = 0;
        UInt32 odometer_u32 = 0;
        byte motor_temperature_u8 = 0;
        byte actual_velocity_u8 = 0;

        UInt16 bat_volt_f32 = 0;
        Int16 bat_cur_32 = 0;
        UInt16 bat_const_f32 = 0;
        UInt16 soc_f32 = 0;
        byte error_u8 = 0;
        byte dc_bus_state_u8 = 0;
        UInt16 worst_cell_voltage_f32 = 0;
        byte worst_cell_adress_u8 = 0;
        byte temperature_u8 = 0;



        UInt32 gps_latitude_f64 = 0;
        UInt32 gps_longtitude_f64 = 0;

        byte gps_velocity = 0;
        byte gps_sattelite_number_u8 = 0;
        byte gps_efficiency_u8 = 0;



        //byte[] array_of_x = BitConverter.GetBytes(x);

        //bu artacak
        int MQTT_Counter = 0;


       

        public static PointLatLng start1 = new PointLatLng(40.744392, 29.786054);

        public static MqttClient Client = new MqttClient("157.230.29.63");


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");

            if (code == 0x00)
            {
                richTextBox1.Text += "Connected\n";
            }
            else
            {
                richTextBox1.Text += "Connection Refused\n";
            }
   
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
            gmap.Zoom = 16;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // (Int16)Convert.ToInt16(textBox1.Text);
            phase_a_current_f32 = (Int16)Convert.ToInt16(textBox1.Text);
            phase_b_current_f32 = (Int16)Convert.ToInt16(textBox2.Text);
            dc_bus_current_f32 = (Int16)Convert.ToInt16(textBox3.Text);
            dc_bus_voltage_f32 = (UInt16)Convert.ToUInt16(textBox4.Text);
            ID_f32 = (Int16)Convert.ToInt16(textBox5.Text);
            IQ_f32 = (Int16)Convert.ToInt16(textBox6.Text);
            VD_f32 = (Int16)Convert.ToInt16(textBox7.Text);
            VQ_f32 = (Int16)Convert.ToInt16(textBox8.Text);
            drive_status_u8 = (byte)Convert.ToByte(textBox9.Text);
            error_u8 = (byte)Convert.ToByte(textBox10.Text);
            odometer_u32 = (UInt32)Convert.ToUInt32(textBox11.Text); ;
            motor_temperature_u8 = (byte)Convert.ToByte(textBox12.Text);
            actual_velocity_u8 = (byte)Convert.ToByte(textBox13.Text);
            MQTT_Counter++;

            //byte[] array_of_x = BitConverter.GetBytes(x);
            byte[] array_of_x = BitConverter.GetBytes(wake_up_u8);
            byte[] array_of_x1 = BitConverter.GetBytes(drive_command_u8);
            byte[] array_of_x2 = BitConverter.GetBytes(set_velocity);
            byte[] array_of_x3 = BitConverter.GetBytes(phase_a_current_f32*100);
            byte[] array_of_x4 = BitConverter.GetBytes(phase_b_current_f32*100);
            byte[] array_of_x5 = BitConverter.GetBytes(dc_bus_current_f32*100);
            byte[] array_of_x6 = BitConverter.GetBytes(dc_bus_voltage_f32*10);

            byte[] array_of_x7 = BitConverter.GetBytes(ID_f32*100);

            byte[] array_of_x8 = BitConverter.GetBytes(IQ_f32*100);

            byte[] array_of_x9 = BitConverter.GetBytes(VD_f32*100);
            byte[] array_of_x10 = BitConverter.GetBytes(VQ_f32*100);
            byte[] array_of_x11 = BitConverter.GetBytes(drive_status_u8);
            byte[] array_of_x12 = BitConverter.GetBytes(driver_error_u8);
            byte[] array_of_x13 = BitConverter.GetBytes(odometer_u32);
            byte[] array_of_x14 = BitConverter.GetBytes(motor_temperature_u8);
            byte[] array_of_x15 = BitConverter.GetBytes(actual_velocity_u8);
            byte[] array_of_x16 = BitConverter.GetBytes(bat_volt_f32*10);
            byte[] array_of_x17 = BitConverter.GetBytes(bat_cur_32*100);
            byte[] array_of_x18 = BitConverter.GetBytes(bat_const_f32*10);
            byte[] array_of_x19 = BitConverter.GetBytes(soc_f32*100);
            byte[] array_of_x20 = BitConverter.GetBytes(error_u8);
            byte[] array_of_x21 = BitConverter.GetBytes(dc_bus_state_u8);

            byte[] array_of_x22 = BitConverter.GetBytes(worst_cell_voltage_f32);
            byte[] array_of_x23 = BitConverter.GetBytes(worst_cell_adress_u8*10);
            byte[] array_of_x24 = BitConverter.GetBytes(temperature_u8);
            byte[] array_of_x25 = BitConverter.GetBytes(gps_latitude_f64);
            byte[] array_of_x26 = BitConverter.GetBytes(gps_longtitude_f64);
            byte[] array_of_x27 = BitConverter.GetBytes(gps_velocity);

            byte[] array_of_x28 = BitConverter.GetBytes(gps_sattelite_number_u8);
            byte[] array_of_x29 = BitConverter.GetBytes(gps_efficiency_u8);
            byte[] array_of_x30 = BitConverter.GetBytes(MQTT_Counter);



            richTextBox1.Text +=wake_up_u8.ToString()+" "+drive_command_u8.ToString() + " " +
                set_velocity.ToString() + " " +phase_a_current_f32.ToString() + " " +
                phase_b_current_f32.ToString() + " " +
                   dc_bus_current_f32.ToString() + " " +
                dc_bus_voltage_f32.ToString() + " " +
                ID_f32.ToString() + " " +
                IQ_f32.ToString() + " " +
                VD_f32.ToString() + " " +
                VQ_f32.ToString() + " " +
                drive_status_u8.ToString() + " " +
                driver_error_u8.ToString() + " " +
                odometer_u32.ToString() + " " +
                motor_temperature_u8.ToString() + " " +
                actual_velocity_u8.ToString() + " " +
                bat_volt_f32.ToString() + " " +
                bat_cur_32.ToString() + " " +
                bat_const_f32.ToString() + " " +
                soc_f32.ToString() + " " +
                error_u8.ToString() + " " +
                dc_bus_state_u8.ToString() + " " +
                worst_cell_voltage_f32.ToString() + " " +
                worst_cell_adress_u8.ToString() + " " +
                temperature_u8.ToString() + " " +
                gps_latitude_f64.ToString() + " " +
                gps_longtitude_f64.ToString() + " " +
                gps_velocity.ToString() + " " +
                gps_sattelite_number_u8.ToString() + " " +
                gps_efficiency_u8.ToString() + " " +



                MQTT_Counter.ToString() + " " +
                "\n";



            Combine_Publish("/home/sensor",
                array_of_x,array_of_x1,array_of_x2,array_of_x3,
                array_of_x4,array_of_x5,array_of_x6,array_of_x7,
                array_of_x8,array_of_x9,array_of_x10,array_of_x11,
                array_of_x12,array_of_x13,array_of_x14,array_of_x15,
                array_of_x16,array_of_x17,array_of_x18,array_of_x19,
                array_of_x20, array_of_x21, array_of_x22, array_of_x23,
                array_of_x24, array_of_x25,array_of_x26, array_of_x27
                , array_of_x28, array_of_x29, array_of_x30


                );







        }


        #region tersine_dataconvert2
        /*
                     vcu_wake_up_u8 = gelenVeri[0];
            vcu_drive_commands_u8 = gelenVeri[1];
            vcu_set_velocity_u8 = gelenVeri[2];

            Driver.phase_a_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 3) / 100;
            Driver.phase_b_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 5) / 100;
            Driver.dc_bus_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 7) / 100;
            Driver.dc_bus_voltage_f32 = (float)BitConverter.ToUInt16(gelenVeri, 9) / 10;
            Driver.id_f32 = (float)BitConverter.ToInt16(gelenVeri, 11) / 100;
            Driver.iq_f32 = (float)BitConverter.ToInt16(gelenVeri, 13) / 100;
            Driver.vd_f32 = (float)BitConverter.ToInt16(gelenVeri, 15) / 100;
            Driver.vq_f32 = (float)BitConverter.ToInt16(gelenVeri, 17) / 100;
            Driver.drive_status_u8 = gelenVeri[19];
            Driver.error_u8 = gelenVeri[20];
            Driver.odometer_u32 = BitConverter.ToUInt32(gelenVeri, 21);
            Driver.motor_temperature_u8 = gelenVeri[25];
            Driver.actual_velocity_u8 = gelenVeri[26];

            BMS.bat_volt_f32 = (float)BitConverter.ToUInt16(gelenVeri, 27) / 10;
            BMS.bat_current_f32 = (float)BitConverter.ToInt16(gelenVeri, 29) / 100;
            BMS.bat_cons_f32 = (float)BitConverter.ToInt16(gelenVeri, 31) / 10;
            BMS.soc_f32 = (float)BitConverter.ToUInt16(gelenVeri, 33) / 100;
            BMS.error_u8 = gelenVeri[35];
            BMS.dc_bus_state_u8 = gelenVeri[36];
            BMS.worst_cell_voltage_f32 = (float)BitConverter.ToUInt16(gelenVeri, 37) / 10;
            BMS.worst_cell_address_u8 = gelenVeri[39];
            BMS.temp_u8 = gelenVeri[40];

            //kendi custom degiskenim direkt gelmiyor ikisini carparak elde ediyoruz
            BMS.power_emitted = BMS.bat_volt_f32 * BMS.bat_current_f32;

            gps_latitude_f64 = (float)BitConverter.ToInt64(gelenVeri, 41) / GPS_DIVIDE;
            gps_longtitude_f64 = (float)BitConverter.ToInt64(gelenVeri, 45) / GPS_DIVIDE;
            gps_velocity_u8 = gelenVeri[49];
            gps_sattelite_number_u8 = gelenVeri[50];
            gps_efficiency_u8 = gelenVeri[51];

            MQTT_counter_int32 = BitConverter.ToInt32(gelenVeri, 52);     
             */
        #endregion
        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
               
                PointLatLng mouse_position = gmap.FromLocalToLatLng(e.X, e.Y);
                gps_latitude_f64 =Convert.ToUInt32(mouse_position.Lat * 1000000);
                gps_longtitude_f64 = Convert.ToUInt32(mouse_position.Lng * 1000000);

                GMapMarker marker = new GMarkerGoogle(mouse_position, GMarkerGoogleType.red_small);
                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
                gmap.Zoom += 0.00000001;
                gmap.Zoom -= 0.00000001;
            }
        }
        public static void Combine_Publish(string topic, params byte[][] arrays)
        {
            byte[] ret = new byte[arrays.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in arrays)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            Client.Publish(topic, ret);

        }


    }
}
