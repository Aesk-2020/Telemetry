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
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Net;



namespace yeniform
{
    public partial class graph_form : Form
    {
        public graph_form()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        bool calculate_about_race_graph = false;
        
        private Thread graph_thread;


        float driver_phase_a_current_f32_g;
         float driver_phase_b_current_f32_g;
         float driver_dc_bus_current_f32_g;

         float driver_id_f32_g;
         float driver_iq_f32_g;
         float driver_vd_f32_g;
         float driver_vq_f32_g;
        
        float bms_bat_volt_f32_g; 
        float bms_bat_current_f32_g; 
        //bunlarin carpimlari da eklenecek

        MqttClient Client = new MqttClient("157.230.29.63");

        private void graph_form_Load(object sender, EventArgs e)
        {
            calculate_about_race_graph = telemetry.calculate_about_race;

            if (calculate_about_race_graph)
            {
                //Yaristayiz:
                //mqtt eventi açılacak
                byte code = Client.Connect(Guid.NewGuid().ToString(), "digital", "aesk");
                Client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                try
                {
                    Client.Subscribe(new string[] { "/home/sensor" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                // form1 den variableler çekilecek, 
                //topluca graph cizilecek
                //history degistikce labeleler degissin


            }


        }

        DateTime graph_start = DateTime.Now;
        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            byte[] incoming = e.Message;
            dataConvert_2_g(incoming);
            //gelen datalar islenip grapha basilacak

        }

        private void geleni_bas()
        {
            graph_thread = new Thread(new ThreadStart(this.graph_draw));
            graph_thread.Start();
        }

        private void graph_draw()
        {

            this.Invoke((MethodInvoker)delegate { draw_funct(); });
            

            //Thread.Sleep(10);

        }
        private void draw_funct()
        {
            double total_sec = (DateTime.Now - graph_start).TotalSeconds;
            double power = bms_bat_volt_f32_g * bms_bat_current_f32_g;


            chart0.Series[0].Points.AddXY(total_sec,driver_phase_a_current_f32_g);
            chart0.Series[1].Points.AddXY(total_sec,driver_phase_b_current_f32_g);
            chart0.Series[2].Points.AddXY(total_sec,driver_dc_bus_current_f32_g);
            chart0.Series[3].Points.AddXY(total_sec,driver_id_f32_g);
            chart0.Series[4].Points.AddXY(total_sec,driver_iq_f32_g);
            chart0.Series[5].Points.AddXY(total_sec,driver_vd_f32_g);
            chart0.Series[6].Points.AddXY(total_sec,driver_vq_f32_g);
            chart0.Series[7].Points.AddXY(total_sec,bms_bat_volt_f32_g);
            chart0.Series[8].Points.AddXY(total_sec,bms_bat_current_f32_g);
            chart0.Series[9].Points.AddXY(total_sec,power);

            chart1.Series[0].Points.AddXY(total_sec, driver_phase_a_current_f32_g);
            chart1.Series[1].Points.AddXY(total_sec, driver_phase_b_current_f32_g);
            chart1.Series[2].Points.AddXY(total_sec, driver_dc_bus_current_f32_g);
            chart1.Series[3].Points.AddXY(total_sec, driver_id_f32_g);
            chart1.Series[4].Points.AddXY(total_sec, driver_iq_f32_g);
            chart1.Series[5].Points.AddXY(total_sec, driver_vd_f32_g);
            chart1.Series[6].Points.AddXY(total_sec, driver_vq_f32_g);
            chart1.Series[7].Points.AddXY(total_sec, bms_bat_volt_f32_g);
            chart1.Series[8].Points.AddXY(total_sec, bms_bat_current_f32_g);
            chart1.Series[9].Points.AddXY(total_sec, power);

            chart2.Series[0].Points.AddXY(total_sec, driver_phase_a_current_f32_g);
            chart2.Series[1].Points.AddXY(total_sec, driver_phase_b_current_f32_g);
            chart2.Series[2].Points.AddXY(total_sec, driver_dc_bus_current_f32_g);
            chart2.Series[3].Points.AddXY(total_sec, driver_id_f32_g);
            chart2.Series[4].Points.AddXY(total_sec, driver_iq_f32_g);
            chart2.Series[5].Points.AddXY(total_sec, driver_vd_f32_g);
            chart2.Series[6].Points.AddXY(total_sec, driver_vq_f32_g);
            chart2.Series[7].Points.AddXY(total_sec, bms_bat_volt_f32_g);
            chart2.Series[8].Points.AddXY(total_sec, bms_bat_current_f32_g);
            chart2.Series[9].Points.AddXY(total_sec, power);

            chart3.Series[0].Points.AddXY(total_sec, driver_phase_a_current_f32_g);
            chart3.Series[1].Points.AddXY(total_sec, driver_phase_b_current_f32_g);
            chart3.Series[2].Points.AddXY(total_sec, driver_dc_bus_current_f32_g);
            chart3.Series[3].Points.AddXY(total_sec, driver_id_f32_g);
            chart3.Series[4].Points.AddXY(total_sec, driver_iq_f32_g);
            chart3.Series[5].Points.AddXY(total_sec, driver_vd_f32_g);
            chart3.Series[6].Points.AddXY(total_sec, driver_vq_f32_g);
            chart3.Series[7].Points.AddXY(total_sec, bms_bat_volt_f32_g);
            chart3.Series[8].Points.AddXY(total_sec, bms_bat_current_f32_g);
            chart3.Series[9].Points.AddXY(total_sec, power);
            
        }



        void dataConvert_2_g(byte[] gelenVeri)
        {

            driver_phase_a_current_f32_g = (float)BitConverter.ToInt16(gelenVeri, 3) / 100;
            driver_phase_b_current_f32_g = (float)BitConverter.ToInt16(gelenVeri, 5) / 100;
            driver_dc_bus_current_f32_g = (float)BitConverter.ToInt16(gelenVeri, 7) / 100;
            

            driver_id_f32_g = (float)BitConverter.ToInt16(gelenVeri, 11) / 100;
            driver_iq_f32_g = (float)BitConverter.ToInt16(gelenVeri, 13) / 100;
            driver_vd_f32_g = (float)BitConverter.ToInt16(gelenVeri, 15) / 100;
            driver_vq_f32_g = (float)BitConverter.ToInt16(gelenVeri, 17) / 100;

            bms_bat_volt_f32_g = (float)BitConverter.ToUInt16(gelenVeri, 27) / 10;
            bms_bat_current_f32_g = (float)BitConverter.ToInt16(gelenVeri, 29) / 100;
            //bu iki deger carpilacak
        }

        #region chart0_checkboxes
        private void DriverPhaseACurrent_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[0].Enabled = !chart0.Series[0].Enabled;
        }

        private void DriverPhaseBCurrent_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[1].Enabled = !chart0.Series[1].Enabled;
        }

        private void DriverDCBusCurrent_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[2].Enabled = !chart0.Series[2].Enabled;
        }

        private void DriverID_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[3].Enabled = !chart0.Series[3].Enabled;
        }

        private void DriverIQ_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[4].Enabled = !chart0.Series[4].Enabled;
        }

        private void DriverVD_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[5].Enabled = !chart0.Series[5].Enabled;
        }

        private void DriverVQ_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[6].Enabled = !chart0.Series[6].Enabled;
        }

        private void BMSBatVoltage_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[7].Enabled = !chart0.Series[7].Enabled;
        }

        private void BMSBatCurrent_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[8].Enabled = !chart0.Series[8].Enabled;
        }

        private void BMSPowerEmitted_1_CheckedChanged(object sender, EventArgs e)
        {
            chart0.Series[9].Enabled = !chart0.Series[9].Enabled;
        }

        #endregion

        #region chart1_checkboxes
        private void DriverPhaseACurrent_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Enabled = !chart1.Series[0].Enabled;
        }

        private void DriverPhaseBCurrent_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Enabled = !chart1.Series[1].Enabled;
        }

        private void DriverDCBusCurrent_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[2].Enabled = !chart1.Series[2].Enabled;
        }

        private void DriverID_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[3].Enabled = !chart1.Series[3].Enabled;
        }

        private void DriverIQ_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[4].Enabled = !chart1.Series[4].Enabled;
        }

        private void DriverVD_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[5].Enabled = !chart1.Series[5].Enabled;
        }

        private void DriverVQ_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[6].Enabled = !chart1.Series[6].Enabled;
        }

        private void BMSBatVoltage_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[7].Enabled = !chart1.Series[7].Enabled;
        }

        private void BMSBatCurrent_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[8].Enabled = !chart1.Series[8].Enabled;
        }

        private void BMSPowerEmitted_2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[9].Enabled = !chart1.Series[9].Enabled;
        }

        #endregion

        #region chart2_checkboxes
        private void DriverPhaseACurrent_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[0].Enabled = !chart2.Series[0].Enabled;
        }

        private void DriverPhaseBCurrent_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[1].Enabled = !chart2.Series[1].Enabled;
        }

        private void DriverDCBusCurrent_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[2].Enabled = !chart2.Series[2].Enabled;
        }

        private void DriverID_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[3].Enabled = !chart2.Series[3].Enabled;
        }

        private void DriverIQ_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[4].Enabled = !chart2.Series[4].Enabled;
        }

        private void DriverVD_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[5].Enabled = !chart2.Series[5].Enabled;
        }

        private void DriverVQ_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[6].Enabled = !chart2.Series[6].Enabled;
        }

        private void BMSBatVoltage_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[7].Enabled = !chart2.Series[7].Enabled;
        }

        private void BMSBatCurrent_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[8].Enabled = !chart2.Series[8].Enabled;
        }

        private void BMSPowerEmitted_3_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[9].Enabled = !chart2.Series[9].Enabled;
        }


        #endregion

        #region chart3_checkboxes
        private void DriverPhaseACurrent_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[0].Enabled = !chart3.Series[0].Enabled;
        }

        private void DriverPhaseBCurrent_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[1].Enabled = !chart3.Series[1].Enabled;
        }

        private void DriverDCBusCurrent_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[2].Enabled = !chart3.Series[2].Enabled;
        }

        private void DriverID_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[3].Enabled = !chart3.Series[3].Enabled;
        }

        private void DriverIQ_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[4].Enabled = !chart3.Series[4].Enabled;
        }

        private void DriverVD_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[5].Enabled = !chart3.Series[5].Enabled;
        }

        private void DriverVQ_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[6].Enabled = !chart3.Series[6].Enabled;
        }

        private void BMSBatVoltage_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[7].Enabled = !chart3.Series[7].Enabled;
        }

        private void BMSBatCurrent_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[8].Enabled = !chart3.Series[8].Enabled;
        }

        private void BMSPowerEmitted_4_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series[9].Enabled = !chart3.Series[9].Enabled;
        }
        #endregion

    }
}
