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
using MqttPublissssh.Variables;
using System.Data.SQLite;

namespace MqttPublissssh
{
    public partial class Form1 : Form
    {

        


        public static PointLatLng start1 = new PointLatLng(40.744392, 29.786054);

        public static MqttClient Client = new MqttClient("46.102.106.183");


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");

            Macros.consoleFront = bos;
            if (code == 0x00)
            {
             //
            }
            else
            {
             
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

  


        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
               
                PointLatLng mouse_position = gmap.FromLocalToLatLng(e.X, e.Y);
                GPS.gps_latitude_f64 =Convert.ToUInt32(mouse_position.Lat * 1000000);
                GPS.gps_longtitude_f64 = Convert.ToUInt32(mouse_position.Lng * 1000000);

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

            Macros.MQttCounter++;

            BufferUpgrade();

            Combine_Publish(Macros.MQTT_topic, Macros.array_of_x);

            Macros.consoleFront();


        }

        private void bos()
        {

        }

        private void BufferUpgrade()
        {
            int ref_index = 0;

            Macros.array_of_x[ref_index] = VCU.wake_up_u8;
            ref_index++;

            /*
            Macros.array_of_x[ref_index] = VCU.drive_command_u8;
            ref_index++;*/

            Macros.array_of_x[ref_index] = VCU.set_velocity_u8;
            ref_index++;


            BitConverter.GetBytes((Int16)(Driver.phase_a_current_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;
        
            BitConverter.GetBytes((Int16)(Driver.phase_b_current_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(Driver.dc_bus_current_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(Driver.dc_bus_voltage_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;


            BitConverter.GetBytes((Int16)(Driver.id_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(Driver.iq_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(Driver.phase_a_rms_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(Driver.torque_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            Macros.array_of_x[ref_index] = (Driver.drive_status_u8);
            ref_index++;

            Macros.array_of_x[ref_index] = (Driver.driver_error_u8);
            ref_index++;

            BitConverter.GetBytes(Driver.odometer_u32).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 4;

            Macros.array_of_x[ref_index] = (Driver.motor_temperature_u8);
            ref_index++;

            Macros.array_of_x[ref_index] = (Driver.actual_velocity_u8);
            ref_index++;

            BitConverter.GetBytes((UInt16)BMS.bat_volt_f32 * 100).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(BMS.bat_current_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(BMS.bat_cons_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes(((UInt16)BMS.soc_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;


            Macros.array_of_x[ref_index] = (BMS.bms_error_u8);
            ref_index++;

            Macros.array_of_x[ref_index] = (BMS.dc_bus_state_u8);
            ref_index++;

            BitConverter.GetBytes((UInt16)(BMS.worst_cell_voltage_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            Macros.array_of_x[ref_index] = (BMS.worst_cell_address_u8);
            ref_index++;

            Macros.array_of_x[ref_index] = (BMS.temp_u8);
            ref_index++;

            BitConverter.GetBytes(GPS.gps_latitude_f64).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 4;

            BitConverter.GetBytes(GPS.gps_longtitude_f64).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 4;

            Macros.array_of_x[ref_index] = (GPS.gps_velocity_u8);
            ref_index++;

            Macros.array_of_x[ref_index] = (GPS.gps_sattelite_number_u8);
            ref_index++;

            Macros.array_of_x[ref_index] = (GPS.gps_efficiency_u8);
            ref_index++;


            //fronttan bi kere çek sonra hepsine ata 
            for (int i = 0; i < 16; i++)
            {
                Macros.array_of_x[ref_index] = 0;
                ref_index++;

            }

            BitConverter.GetBytes((UInt16)(EMS.bat_cons_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(EMS.fc_cons_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(EMS.fc_lt_cons_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(EMS.out_cons_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;


            BitConverter.GetBytes((Int16)(EMS.bat_cur_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(EMS.fc_cur_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(EMS.out_cur_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(EMS.bat_volt_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(EMS.fc_volt_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(EMS.out_volt_f32 * 10)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            Macros.array_of_x[ref_index] = (byte)(EMS.penalty_s8);
            ref_index++;

            BitConverter.GetBytes((UInt16)(EMS.bat_soc_f32 * 100)).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 2;

            Macros.array_of_x[ref_index] = (EMS.temperature_u8);
            ref_index++;

            Macros.array_of_x[ref_index] = (EMS.error_u8);
            ref_index++;



            Macros.array_of_x[ref_index] = (VCU.can_error_u8);
            ref_index++;

            Macros.array_of_x[ref_index] = 0;
            BitConverter.GetBytes(Macros.MQttCounter).CopyTo(Macros.array_of_x, ref_index);
            ref_index += 4;

     
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Clear();
            gmap.Zoom += 0.00000001;
            gmap.Zoom -= 0.00000001;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                button4.Text = "Stop";
            }
            else
            {
                button4.Text = "Contiune";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vcu_wak = (checkBox_07.Checked ? 128 : 0) + (checkBox_06.Checked ? 64 : 0) + (checkBox_05.Checked ? 32 : 0) + (checkBox_04.Checked ? 16 : 0) 
           +  (checkBox_03.Checked ? 8 : 0) + (checkBox_02.Checked ? 4 : 0) + (checkBox_01.Checked ? 2 : 0) + (checkBox_00.Checked ? 1 : 0);

            VCU.wake_up_u8 = (byte)Convert.ToByte(vcu_wak);

            var vcu_can_error = (checkBox_27.Checked ? 128 : 0) + (checkBox_26.Checked ? 64 : 0) + (checkBox_25.Checked ? 32 : 0) + (checkBox_24.Checked ? 16 : 0)
           + (checkBox_23.Checked ? 8 : 0) + (checkBox_22.Checked ? 4 : 0) + (checkBox_21.Checked ? 2 : 0) + (checkBox_20.Checked ? 1 : 0);

            VCU.can_error_u8 = (byte)Convert.ToByte(vcu_can_error);

            var driver_drive_command = (checkBox_37.Checked ? 128 : 0) + (checkBox_36.Checked ? 64 : 0) + (checkBox_35.Checked ? 32 : 0) + (checkBox_34.Checked ? 16 : 0)
           + (checkBox_33.Checked ? 8 : 0) + (checkBox_32.Checked ? 4 : 0) + (checkBox_31.Checked ? 2 : 0) + (checkBox_30.Checked ? 1 : 0);

            Driver.drive_command_u8 = (byte)Convert.ToByte(driver_drive_command);

            var driver_status = (checkBox_47.Checked ? 128 : 0) + (checkBox_46.Checked ? 64 : 0) + (checkBox_45.Checked ? 32 : 0) + (checkBox_44.Checked ? 16 : 0)
           + (checkBox_43.Checked ? 8 : 0) + (checkBox_42.Checked ? 4 : 0) + (checkBox_41.Checked ? 2 : 0) + (checkBox_40.Checked ? 1 : 0);

            Driver.drive_status_u8 = (byte)Convert.ToByte(driver_status);

            var driver_error = (checkBox_57.Checked ? 128 : 0) + (checkBox_56.Checked ? 64 : 0) + (checkBox_55.Checked ? 32 : 0) + (checkBox_54.Checked ? 16 : 0)
           + (checkBox_53.Checked ? 8 : 0) + (checkBox_52.Checked ? 4 : 0) + (checkBox_51.Checked ? 2 : 0) + (checkBox_50.Checked ? 1 : 0);

            Driver.driver_error_u8 = (byte)Convert.ToByte(driver_error);

            var ems_error = (checkBox_67.Checked ? 128 : 0) + (checkBox_66.Checked ? 64 : 0) + (checkBox_65.Checked ? 32 : 0) + (checkBox_64.Checked ? 16 : 0)
           + (checkBox_63.Checked ? 8 : 0) + (checkBox_62.Checked ? 4 : 0) + (checkBox_61.Checked ? 2 : 0) + (checkBox_60.Checked ? 1 : 0);

            EMS.error_u8 = (byte)Convert.ToByte(ems_error);

            var bms_error = (checkBox_77.Checked ? 128 : 0) + (checkBox_76.Checked ? 64 : 0) + (checkBox_75.Checked ? 32 : 0) + (checkBox_74.Checked ? 16 : 0)
           + (checkBox_73.Checked ? 8 : 0) + (checkBox_72.Checked ? 4 : 0) + (checkBox_71.Checked ? 2 : 0) + (checkBox_70.Checked ? 1 : 0);

            BMS.bms_error_u8 = (byte)Convert.ToByte(bms_error);

            var dc_bus_state = (checkBox_87.Checked ? 128 : 0) + (checkBox_86.Checked ? 64 : 0) + (checkBox_85.Checked ? 32 : 0) + (checkBox_84.Checked ? 16 : 0)
           + (checkBox_83.Checked ? 8 : 0) + (checkBox_82.Checked ? 4 : 0) + (checkBox_81.Checked ? 2 : 0) + (checkBox_80.Checked ? 1 : 0);

            BMS.dc_bus_state_u8 = (byte)Convert.ToByte(dc_bus_state);


        }

        //textbox 1-15 
        //Driver , VCU , GPS
        private void button3_Click(object sender, EventArgs e)
        {
        
            Driver.phase_a_current_f32 = float.Parse(textBox1.Text);
            Driver.phase_b_current_f32 = float.Parse(textBox2.Text);
            Driver.dc_bus_current_f32 = float.Parse(textBox3.Text);
            Driver.dc_bus_voltage_f32 = float.Parse(textBox4.Text);
            Driver.id_f32 = float.Parse(textBox5.Text);
            Driver.iq_f32 = float.Parse(textBox6.Text);
            Driver.torque_f32 = float.Parse(textBox7.Text);
            Driver.odometer_u32 = (UInt32)Convert.ToUInt32(textBox8.Text);


            Driver.phase_a_rms_f32 = float.Parse(textBox9.Text);
            Driver.actual_velocity_u8 = (byte)Convert.ToByte(textBox10.Text);
            Driver.motor_temperature_u8 = (byte)Convert.ToByte(textBox11.Text);

            VCU.set_velocity_u8 = (byte)Convert.ToByte(textBox12.Text);

            GPS.gps_velocity_u8 = (byte)Convert.ToByte(textBox13.Text);
            GPS.gps_sattelite_number_u8 = (byte)Convert.ToByte(textBox14.Text);
            GPS.gps_efficiency_u8 = (byte)Convert.ToByte(textBox15.Text);






        }

        //textbox 16-27 
        //EMS
        private void button7_Click(object sender, EventArgs e)
        {
            EMS.bat_cons_f32 = float.Parse(textBox16.Text);
            EMS.fc_cons_f32 = float.Parse(textBox17.Text);
            EMS.fc_lt_cons_f32 = float.Parse(textBox18.Text);
            EMS.out_cons_f32 = float.Parse(textBox19.Text);
            EMS.bat_cur_f32 = float.Parse(textBox20.Text);
            EMS.fc_cur_f32 = float.Parse(textBox21.Text);
            EMS.out_cur_f32 = float.Parse(textBox22.Text);
            EMS.bat_volt_f32 = float.Parse(textBox23.Text);
            EMS.fc_volt_f32 = float.Parse(textBox24.Text);
            EMS.out_volt_f32 = float.Parse(textBox25.Text);
            EMS.penalty_s8 =(sbyte)Convert.ToByte(textBox26.Text);
            EMS.temperature_u8 = (byte)Convert.ToByte(textBox27.Text);





        }

        //textbpx 28-34
        //bms
        private void button6_Click(object sender, EventArgs e)
        {
           BMS.bat_volt_f32 = float.Parse(textBox28.Text);
           BMS.bat_current_f32 = float.Parse(textBox29.Text);
           BMS.bat_cons_f32 = float.Parse(textBox30.Text);
           BMS.soc_f32 = float.Parse(textBox31.Text);
           BMS.worst_cell_voltage_f32 = float.Parse(textBox32.Text);
           BMS.worst_cell_address_u8 = (byte)Convert.ToByte(textBox33.Text);
           BMS.temp_u8 = (byte)Convert.ToByte(textBox34.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            console myConsole = new console();
            myConsole.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BufferUpgrade();

            Combine_Publish(Macros.MQTT_topic, Macros.array_of_x);

            Macros.consoleFront();
        }
    }

}
