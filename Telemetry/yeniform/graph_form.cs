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

using yeniform.Variables;
using System.Windows.Forms.DataVisualization.Charting;

namespace yeniform
{
    public partial class graph_form :Form
    {
        public delegate void DrawGraphDelegate(Chart myChart, double mySecond, object myData, int i);
        DateTime graph_start = DateTime.Now;
        Thread graph_thread;
        public graph_form()
        {
            InitializeComponent();
        }
    
        private void graph_form_Load(object sender, EventArgs e)
        {
            graph_thread = new Thread(draw_funct) { IsBackground = true, Priority = ThreadPriority.Highest};
            graph_thread.Start();
        }

        public void drawDatas(Chart myChart, object mySecond, object myData, int i)
        {
            if(myChart.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    drawDatas(myChart, mySecond, myData, i);
                };
                myChart.Invoke(del);
                return;
            }
            myChart.Series[i].Points.AddXY(mySecond, myData);   
        }

        Dictionary<string, int> Graph_dic = new Dictionary<string, int>
        {
            {"DriverPhaseA",0 },
            {"DriverPhaseB",1 },
            {"DriverDCBusCurrent",2 },
            {"DriverID",3 },
            {"DriverIQ",4 },
            {"DriverVD",5 },
            {"DriverVQ",6 },
            {"BMSBatVoltage",7 },
            {"BMSBatCurrent",8 },
            {"BMSPower",9 }
        };
        

        private void draw_funct()
        {
           int a= Graph_dic["DriverPhaseA"];
            while(true)
            {
                if (MACROS.race_start_flag)
                {
                    string total_sec = Timers.Gecen_süre.ToString(MACROS.TimeStringFormat);

                    drawDatas(chart_0, total_sec, Driver.phase_a_current_f32, Graph_dic["DriverPhaseA"]);
                    drawDatas(chart_0, total_sec, Driver.phase_b_current_f32, Graph_dic["DriverPhaseB"]);
                    drawDatas(chart_0, total_sec, Driver.dc_bus_current_f32, Graph_dic["DriverDCBusCurrent"]);
                    drawDatas(chart_0, total_sec, Driver.id_f32, Graph_dic["DriverID"]);
                    drawDatas(chart_0, total_sec, Driver.iq_f32, Graph_dic["DriverIQ"]);
                    drawDatas(chart_0, total_sec, Driver.vd_f32, Graph_dic["DriverVD"]);
                    drawDatas(chart_0, total_sec, Driver.vq_f32, Graph_dic["DriverVQ"]);
                    drawDatas(chart_0, total_sec, BMS.bat_volt_f32, Graph_dic["BMSBatVoltage"]);
                    drawDatas(chart_0, total_sec, BMS.bat_current_f32, Graph_dic["BMSBatCurrent"]);
                    drawDatas(chart_0, total_sec, BMS.power_emitted, Graph_dic["BMSPower"]);

                    drawDatas(chart_1, total_sec, Driver.phase_a_current_f32, Graph_dic["DriverPhaseA"]);
                    drawDatas(chart_1, total_sec, Driver.phase_b_current_f32, Graph_dic["DriverPhaseB"]);
                    drawDatas(chart_1, total_sec, Driver.dc_bus_current_f32, Graph_dic["DriverDCBusCurrent"]);
                    drawDatas(chart_1, total_sec, Driver.id_f32, Graph_dic["DriverID"]);
                    drawDatas(chart_1, total_sec, Driver.iq_f32, Graph_dic["DriverIQ"]);
                    drawDatas(chart_1, total_sec, Driver.vd_f32, Graph_dic["DriverVD"]);
                    drawDatas(chart_1, total_sec, Driver.vq_f32, Graph_dic["DriverVQ"]);
                    drawDatas(chart_1, total_sec, BMS.bat_volt_f32, Graph_dic["BMSBatVoltage"]);
                    drawDatas(chart_1, total_sec, BMS.bat_current_f32, Graph_dic["BMSBatCurrent"]);
                    drawDatas(chart_1, total_sec, BMS.power_emitted, Graph_dic["BMSPower"]);

                    drawDatas(chart_2, total_sec, Driver.phase_a_current_f32, Graph_dic["DriverPhaseA"]);
                    drawDatas(chart_2, total_sec, Driver.phase_b_current_f32, Graph_dic["DriverPhaseB"]);
                    drawDatas(chart_2, total_sec, Driver.dc_bus_current_f32, Graph_dic["DriverDCBusCurrent"]);
                    drawDatas(chart_2, total_sec, Driver.id_f32, Graph_dic["DriverID"]);
                    drawDatas(chart_2, total_sec, Driver.iq_f32, Graph_dic["DriverIQ"]);
                    drawDatas(chart_2, total_sec, Driver.vd_f32, Graph_dic["DriverVD"]);
                    drawDatas(chart_2, total_sec, Driver.vq_f32, Graph_dic["DriverVQ"]);
                    drawDatas(chart_2, total_sec, BMS.bat_volt_f32, Graph_dic["BMSBatVoltage"]);
                    drawDatas(chart_2, total_sec, BMS.bat_current_f32, Graph_dic["BMSBatCurrent"]);
                    drawDatas(chart_2, total_sec, BMS.power_emitted, Graph_dic["BMSPower"]);

                    drawDatas(chart_3, total_sec, Driver.phase_a_current_f32, Graph_dic["DriverPhaseA"]);
                    drawDatas(chart_3, total_sec, Driver.phase_b_current_f32, Graph_dic["DriverPhaseB"]);
                    drawDatas(chart_3, total_sec, Driver.dc_bus_current_f32, Graph_dic["DriverDCBusCurrent"]);
                    drawDatas(chart_3, total_sec, Driver.id_f32, Graph_dic["DriverID"]);
                    drawDatas(chart_3, total_sec, Driver.iq_f32, Graph_dic["DriverIQ"]);
                    drawDatas(chart_3, total_sec, Driver.vd_f32, Graph_dic["DriverVD"]);
                    drawDatas(chart_3, total_sec, Driver.vq_f32, Graph_dic["DriverVQ"]);
                    drawDatas(chart_3, total_sec, BMS.bat_volt_f32, Graph_dic["BMSBatVoltage"]);
                    drawDatas(chart_3, total_sec, BMS.bat_current_f32, Graph_dic["BMSBatCurrent"]);
                    drawDatas(chart_0, total_sec, BMS.power_emitted, Graph_dic["BMSPower"]);

                    Thread.Sleep(500);
                }
            }
        }


        #region chart0_checkboxes
        private void DriverPhaseACurrent_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[0].Enabled = !chart_0.Series[0].Enabled;
        }

        private void DriverPhaseBCurrent_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[1].Enabled = !chart_0.Series[1].Enabled;
        }

        private void DriverDCBusCurrent_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[2].Enabled = !chart_0.Series[2].Enabled;
        }

        private void DriverID_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[3].Enabled = !chart_0.Series[3].Enabled;
        }

        private void DriverIQ_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[4].Enabled = !chart_0.Series[4].Enabled;
        }

        private void DriverVD_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[5].Enabled = !chart_0.Series[5].Enabled;
        }

        private void DriverVQ_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[6].Enabled = !chart_0.Series[6].Enabled;
        }

        private void BMSBatVoltage_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[7].Enabled = !chart_0.Series[7].Enabled;
        }

        private void BMSBatCurrent_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[8].Enabled = !chart_0.Series[8].Enabled;
        }

        private void BMSPowerEmitted_1_CheckedChanged(object sender, EventArgs e)
        {
            chart_0.Series[9].Enabled = !chart_0.Series[9].Enabled;
        }

        #endregion

        #region chart1_checkboxes
        private void DriverPhaseACurrent_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[0].Enabled = !chart_2.Series[0].Enabled;
        }

        private void DriverPhaseBCurrent_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[1].Enabled = !chart_2.Series[1].Enabled;
        }

        private void DriverDCBusCurrent_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[2].Enabled = !chart_2.Series[2].Enabled;
        }

        private void DriverID_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[3].Enabled = !chart_2.Series[3].Enabled;
        }

        private void DriverIQ_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[4].Enabled = !chart_2.Series[4].Enabled;
        }

        private void DriverVD_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[5].Enabled = !chart_2.Series[5].Enabled;
        }

        private void DriverVQ_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[6].Enabled = !chart_2.Series[6].Enabled;
        }

        private void BMSBatVoltage_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[7].Enabled = !chart_2.Series[7].Enabled;
        }

        private void BMSBatCurrent_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[8].Enabled = !chart_2.Series[8].Enabled;
        }

        private void BMSPowerEmitted_2_CheckedChanged(object sender, EventArgs e)
        {
            chart_2.Series[9].Enabled = !chart_2.Series[9].Enabled;
        }

        #endregion

        #region chart2_checkboxes
        private void DriverPhaseACurrent_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[0].Enabled = !chart_1.Series[0].Enabled;
        }

        private void DriverPhaseBCurrent_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[1].Enabled = !chart_1.Series[1].Enabled;
        }

        private void DriverDCBusCurrent_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[2].Enabled = !chart_1.Series[2].Enabled;
        }

        private void DriverID_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[3].Enabled = !chart_1.Series[3].Enabled;
        }

        private void DriverIQ_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[4].Enabled = !chart_1.Series[4].Enabled;
        }

        private void DriverVD_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[5].Enabled = !chart_1.Series[5].Enabled;
        }

        private void DriverVQ_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[6].Enabled = !chart_1.Series[6].Enabled;
        }

        private void BMSBatVoltage_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[7].Enabled = !chart_1.Series[7].Enabled;
        }

        private void BMSBatCurrent_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[8].Enabled = !chart_1.Series[8].Enabled;
        }

        private void BMSPowerEmitted_3_CheckedChanged(object sender, EventArgs e)
        {
            chart_1.Series[9].Enabled = !chart_1.Series[9].Enabled;
        }


        #endregion

        #region chart3_checkboxes
        private void DriverPhaseACurrent_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[0].Enabled = !chart_3.Series[0].Enabled;
        }

        private void DriverPhaseBCurrent_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[1].Enabled = !chart_3.Series[1].Enabled;
        }

        private void DriverDCBusCurrent_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[2].Enabled = !chart_3.Series[2].Enabled;
        }

        private void DriverID_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[3].Enabled = !chart_3.Series[3].Enabled;
        }

        private void DriverIQ_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[4].Enabled = !chart_3.Series[4].Enabled;
        }

        private void DriverVD_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[5].Enabled = !chart_3.Series[5].Enabled;
        }

        private void DriverVQ_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[6].Enabled = !chart_3.Series[6].Enabled;
        }

        private void BMSBatVoltage_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[7].Enabled = !chart_3.Series[7].Enabled;
        }

        private void BMSBatCurrent_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[8].Enabled = !chart_3.Series[8].Enabled;
        }

        private void BMSPowerEmitted_4_CheckedChanged(object sender, EventArgs e)
        {
            chart_3.Series[9].Enabled = !chart_3.Series[9].Enabled;
        }
        #endregion

        private void graph_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            graph_thread.Abort();
        }


    }
}
