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

        float phase_a_current_f32 = 0;
        float phase_b_current_f32 = 0;
        float dc_bus_current_f32 = 0;
        float dc_bus_voltage_f32 = 0;
        float ID_f32 = 0;
        float IQ_f32 = 0;
        float VD_f32 =0;
        float VQ_f32 = 0;
        byte drive_status_u8 = 0;
        byte driver_error_u8 = 0;
        UInt32 odometer_u32 = 0;
        byte motor_temperature_u8 = 0;
        byte actual_velocity_u8 = 0;

        float bat_volt_f32 = 0;
        float bat_cur_32 = 0;
        float bat_const_f32 = 0;
        float soc_f32 = 0;
        byte error_u8 = 0;
        byte dc_bus_state_u8 = 0;
        float worst_cell_voltage_f32 = 0;
        byte worst_cell_adress_u8 = 0;
        byte temperature_u8 = 0;



        UInt32 gps_latitude_f64 = 0;
        UInt32 gps_longtitude_f64 = 0;

        byte gps_velocity = 0;
        byte gps_sattelite_number_u8 = 0;
        byte gps_efficiency_u8 = 0;
        byte[] array_of_x = new byte[56];


        //byte[] array_of_x = BitConverter.GetBytes(x);

        //bu artacak
        int MQTT_Counter = 0;


       

        public static PointLatLng start1 = new PointLatLng(40.744392, 29.786054);

        public static MqttClient Client = new MqttClient("157.230.29.63");

        byte mode = 2;
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
            if(!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // (Int16)Convert.ToInt16(textBox1.Text);
            phase_a_current_f32 = float.Parse(textBox1.Text);
            phase_b_current_f32 = float.Parse(textBox2.Text);
            dc_bus_current_f32 = float.Parse(textBox10.Text);
            dc_bus_voltage_f32 = float.Parse(textBox9.Text);
            ID_f32 = float.Parse(textBox8.Text);
            IQ_f32 = float.Parse(textBox7.Text);
            VD_f32 = float.Parse(textBox6.Text);
            VQ_f32 = float.Parse(textBox5.Text);
            drive_status_u8 = (byte)Convert.ToByte(textBox4.Text);
            driver_error_u8 = (byte)Convert.ToByte(textBox3.Text);
            odometer_u32 = (UInt32)Convert.ToUInt32(textBox11.Text); 
            motor_temperature_u8 = (byte)Convert.ToByte(textBox12.Text);
            actual_velocity_u8 = (byte)Convert.ToByte(textBox13.Text);
            wake_up_u8 = (byte)Convert.ToByte(textBox14.Text);
            drive_command_u8 = (byte)Convert.ToByte(textBox15.Text);
            dc_bus_state_u8 = (byte)Convert.ToByte(textBox16.Text);
            error_u8 = (byte)Convert.ToByte(textBox17.Text);
            bat_const_f32 = float.Parse(textBox18.Text);

            //byte[] array_of_x = BitConverter.GetBytes(x);

            array_of_x[0] = wake_up_u8;
             array_of_x[1] =  drive_command_u8;
             array_of_x[2] = set_velocity;
             BitConverter.GetBytes((Int16)(phase_a_current_f32*100)).CopyTo(array_of_x, 3);
             BitConverter.GetBytes((Int16)(phase_b_current_f32 *100)).CopyTo(array_of_x, 5);
             BitConverter.GetBytes((Int16)(dc_bus_current_f32 *100)).CopyTo(array_of_x, 7);
             BitConverter.GetBytes((UInt16)(dc_bus_voltage_f32 *10)).CopyTo(array_of_x, 9);

             BitConverter.GetBytes((Int16)(ID_f32 *100)).CopyTo(array_of_x, 11);
                                         
             BitConverter.GetBytes((Int16)(IQ_f32 *100)).CopyTo(array_of_x, 13);
                                        
             BitConverter.GetBytes((Int16)(VD_f32 *100)).CopyTo(array_of_x, 15);
             BitConverter.GetBytes((Int16)(VQ_f32 *100)).CopyTo(array_of_x, 17);
             array_of_x[19] = (drive_status_u8);
             array_of_x[20] = (driver_error_u8);
             BitConverter.GetBytes(odometer_u32).CopyTo(array_of_x, 21);
             array_of_x[25] = (motor_temperature_u8);
             array_of_x[26] = (actual_velocity_u8);
             BitConverter.GetBytes((UInt16)bat_volt_f32 *10).CopyTo(array_of_x, 27);
             BitConverter.GetBytes((Int16)(bat_cur_32*100)).CopyTo(array_of_x, 29);
             BitConverter.GetBytes((UInt16)(bat_const_f32 *10)).CopyTo(array_of_x, 31);
             BitConverter.GetBytes(((UInt16)soc_f32 *100)).CopyTo(array_of_x, 33);
             array_of_x[35] = (error_u8);
             array_of_x[36] = (dc_bus_state_u8);
            
            BitConverter.GetBytes((UInt16)(worst_cell_voltage_f32 * 10)).CopyTo(array_of_x, 37);
            array_of_x[39] = (worst_cell_adress_u8);
            array_of_x[40] = (temperature_u8);




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

        private void timer1_Tick(object sender, EventArgs e)
        {
            BitConverter.GetBytes(gps_latitude_f64).CopyTo(array_of_x, 41);
            BitConverter.GetBytes(gps_longtitude_f64).CopyTo(array_of_x, 45);
            array_of_x[49] = gps_velocity;
            array_of_x[50] = (gps_sattelite_number_u8);
            array_of_x[51] = (gps_efficiency_u8);
            if (mode == 1)
            {
            MQTT_Counter++; 
            BitConverter.GetBytes(MQTT_Counter).CopyTo(array_of_x, 52);
            Combine_Publish("/home/sensor",
    array_of_x);
            }

            if(mode == 0)
            {
                BitConverter.GetBytes(aeskCRCCalculate(array_of_x, (uint)array_of_x.Length)).CopyTo(array_of_x, 52);
                byte[] myArray = new byte[55];
                myArray[0] = 0x69;
                for(byte i = 1; i< myArray.Length; i++)
                {
                    myArray[i] = array_of_x[i - 1];
                }
                ushort crc = aeskCRCCalculate(myArray, (uint)myArray.Length - 2);
                BitConverter.GetBytes(crc).CopyTo(myArray, 53);
                serialPort1.Write(myArray, 0, myArray.Length);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = 0;
        }

        private ushort aeskCRCCalculate(byte[] frame, uint framesize)
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

        private void button5_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Clear();
            gmap.Zoom += 0.00000001;
            gmap.Zoom -= 0.00000001;
        }
    }

}
