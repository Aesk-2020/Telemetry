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

 
        int MQTT_Counter = 0;

        byte[] array_of_x = new byte[100];


        public static PointLatLng start1 = new PointLatLng(40.744392, 29.786054);

        public static MqttClient Client = new MqttClient("46.102.106.183");


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");

            if (code == 0x00)
            {
             
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

        /*
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



                    #region Print

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
                    #endregion




         */


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

            //text boxdakiler 
            Driver.phase_a_current_f32 = float.Parse(textBox1.Text);
            Driver.phase_b_current_f32 = float.Parse(textBox2.Text);
            Driver.dc_bus_current_f32 = float.Parse(textBox10.Text);
            Driver.dc_bus_voltage_f32 = float.Parse(textBox9.Text);
            Driver.id_f32 = float.Parse(textBox8.Text);
            Driver.iq_f32 = float.Parse(textBox7.Text);
            Driver.phase_a_rms_f32 = float.Parse(textBox6.Text);
            Driver.torque_f32 = float.Parse(textBox5.Text);

           
            Driver.odometer_u32 = (UInt32)Convert.ToUInt32(textBox11.Text);
            Driver.motor_temperature_u8 = (byte)Convert.ToByte(textBox12.Text);
            Driver.actual_velocity_u8 = (byte)Convert.ToByte(textBox13.Text);

            BMS.bat_cons_f32 = float.Parse(textBox18.Text);



            int ref_index = 0;

            array_of_x[ref_index] = VCU.wake_up_u8;
            ref_index++;

            array_of_x[ref_index] = VCU.drive_command_u8;
            ref_index++;

            array_of_x[ref_index] = VCU.set_velocity_u8;
            ref_index++;


            BitConverter.GetBytes((Int16)(Driver.phase_a_current_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(Driver.phase_b_current_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;
            
            BitConverter.GetBytes((Int16)(Driver.dc_bus_current_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(Driver.dc_bus_voltage_f32 * 10)).CopyTo(array_of_x, ref_index);
            ref_index += 2;


            BitConverter.GetBytes((Int16)(Driver.id_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(Driver.iq_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(Driver.phase_a_rms_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(Driver.torque_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            array_of_x[ref_index] = (Driver.drive_status_u8);
            ref_index++;

            array_of_x[ref_index] = (Driver.driver_error_u8);
            ref_index++;

            BitConverter.GetBytes(Driver.odometer_u32).CopyTo(array_of_x, ref_index);
            ref_index+=4;

            array_of_x[ref_index] = (Driver.motor_temperature_u8);
            ref_index++;

            array_of_x[ref_index] = (Driver.actual_velocity_u8);
            ref_index++;

            BitConverter.GetBytes((UInt16)BMS.bat_volt_f32 * 10).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((Int16)(BMS.bat_current_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes((UInt16)(BMS.bat_cons_f32 * 10)).CopyTo(array_of_x, ref_index);
            ref_index += 2;

            BitConverter.GetBytes(((UInt16)BMS.soc_f32 * 100)).CopyTo(array_of_x, ref_index);
            ref_index += 2;


            array_of_x[ref_index] = (BMS.bms_error_u8);
            ref_index++;

            array_of_x[ref_index] = (BMS.dc_bus_state_u8);
            ref_index++;

            BitConverter.GetBytes((UInt16)(BMS.worst_cell_voltage_f32 * 10)).CopyTo(array_of_x, 37);

            array_of_x[ref_index] = (BMS.worst_cell_address_u8);
            ref_index++;

            array_of_x[ref_index] = (BMS.temp_u8);
            ref_index++;

            BitConverter.GetBytes(GPS.gps_latitude_f64).CopyTo(array_of_x, ref_index);
            ref_index += 4;

            BitConverter.GetBytes(GPS.gps_longtitude_f64).CopyTo(array_of_x, ref_index);
            ref_index += 4;

            array_of_x[ref_index] = (GPS.gps_velocity_u8);
            ref_index++;

            array_of_x[ref_index] = (GPS.gps_sattelite_number_u8);
            ref_index++;

            array_of_x[ref_index] = (GPS.gps_efficiency_u8);
            ref_index++;


            //fronttan bi kere çek sonra hepsine ata 
            for(int i = 0; i < 16; i++)
            {
                array_of_x[ref_index] = 0;
                ref_index++;

            }
            //eys verileri, frontta oluştur
            EMS.bat_cons_f32 = 0;
            EMS.fc_cons_f32 = 0;
            EMS.fc_lt_cons_f32 = 0;
            EMS.out_cons_f32 = 0;
            EMS.bat_cur_f32 = 0;
            EMS.fc_cur_f32 = 0;
            EMS.out_cur_f32 = 0;
            EMS.bat_volt_f32 = 0;
            EMS.fc_volt_f32 = 0;
            EMS.out_volt_f32 = 0;
            EMS.penalty_s8 = 0;
            EMS.bat_soc_f32 = 0;
            EMS.temperature_u8 = 0;
            EMS.error_u8 = 0;



            //mqtt counter öncesi vcu can error 1 byte uint8
            MQTT_Counter++;
            array_of_x[52] = 0;
            BitConverter.GetBytes(MQTT_Counter).CopyTo(array_of_x, 53);
               
            Combine_Publish(Macros.MQTT_topic,array_of_x);
            

     

            #region Print

           /* richTextBox1.Text += wake_up_u8.ToString() + " " + drive_command_u8.ToString() + " " +
                set_velocity.ToString() + " " + phase_a_current_f32.ToString() + " " +
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
                "\n";*/
            #endregion

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

            var vcu_drive_command = (checkBox_17.Checked ? 128 : 0) + (checkBox_16.Checked ? 64 : 0) + (checkBox_15.Checked ? 32 : 0) + (checkBox_14.Checked ? 16 : 0)
           + (checkBox_13.Checked ? 8 : 0) + (checkBox_12.Checked ? 4 : 0) + (checkBox_11.Checked ? 2 : 0) + (checkBox_10.Checked ? 1 : 0);

            VCU.drive_command_u8 = (byte)Convert.ToByte(vcu_drive_command);

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
    }

}
