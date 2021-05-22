using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.Variables;

namespace Telemetri.NewForms
{
    public partial class Graphics : Form
    {
        public enum graphs
        {
            batCur = 0,
            batVolt = 1,
            batCons = 2,
            batTemp = 3,
            VD = 4,
            VQ = 5,
            dcBusVolt = 6,
            dcBusCur = 7,
            id = 8,
            iq = 9,
            iarms = 10,
            torque = 11,
        }
        public Action changeGraph = null;
        public static List<Graphics> graphicsList = new List<Graphics>();
        public static Graphics oldGraph = null;
        public graphs graphType = 0;

        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion

        #region .. code for Flucuring ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        public Graphics(graphs a)
        {
            InitializeComponent();
            #region doubleBuffer
            SetDoubleBuffered(myChart);
            #endregion
            this.ControlBox = false;
            graphType = a;
            switch (graphType)
            {
                case graphs.batCur:
                    myChart.Series[0].Name = "Battery Current";
                    changeGraph = this.changeBatCur;
                    break;
                case graphs.batVolt:
                    myChart.Series[0].Name = "Battery Voltage";
                    changeGraph = this.changeBatVolt;
                    break;
                case graphs.batCons:
                    myChart.Series[0].Name = "Battery Consumption";
                    changeGraph = this.changeBatCons;
                    break;
                case graphs.batTemp:
                    myChart.Series[0].Name = "Battery Temperature";
                    changeGraph = this.changeBatTemp;
                    break;
                case graphs.VD:
                    myChart.Series[0].Name = "VD";
                    changeGraph = this.changeVD;
                    break;
                case graphs.VQ:
                    myChart.Series[0].Name = "VQ";
                    changeGraph = this.changeVQ;
                    break;
                case graphs.dcBusCur:
                    myChart.Series[0].Name = "DC Bus Current";
                    changeGraph = this.changeDcBusCur;
                    break;
                case graphs.dcBusVolt:
                    myChart.Series[0].Name = "DC Bus Voltage";
                    changeGraph = this.changeDcBusVolt;
                    break;
                case graphs.iq:
                    myChart.Series[0].Name = "IQ";
                    changeGraph = this.changeIQ;
                    break;
                case graphs.id:
                    myChart.Series[0].Name = "ID";
                    changeGraph = this.changeID;
                    break;
                case graphs.torque:
                    myChart.Series[0].Name = "Torque";
                    changeGraph = this.changeTorque;
                    break;
            }
        }
        private void changeBatCur()
        {
            myChart.Series[0].Points.Add(DataBMS.cur_s16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeBatVolt()
        {
            myChart.Series[0].Points.Add(DataBMS.volt_u16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeBatCons()
        {
            myChart.Series[0].Points.Add(DataBMS.cur_s16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeBatTemp()
        {
            myChart.Series[0].Points.Add(DataBMS.temperature_u8);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeVD()
        {
            myChart.Series[0].Points.Add(DataMCU.vd_s16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeVQ()
        {
            myChart.Series[0].Points.Add(DataMCU.vq_s16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeDcBusCur()
        {
            myChart.Series[0].Points.Add(DataMCU.i_dc_s16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeDcBusVolt()
        {
            myChart.Series[0].Points.Add(DataMCU.v_dc_s16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeIQ()
        {
            myChart.Series[0].Points.Add(DataMCU.act_iq_current_s16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeID()
        {
            myChart.Series[0].Points.Add(DataMCU.act_id_current_s16);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }
        private void changeTorque()
        {
            myChart.Series[0].Points.Add(DataMCU.act_torque_s8);
            myChart.ChartAreas[0].AxisX.Minimum = myChart.Series[0].Points.Count - 100;
            myChart.ChartAreas[0].AxisX.Maximum = myChart.Series[0].Points.Count;
        }

        private void clsButton_Click(object sender, EventArgs e)
        {
            foreach (var item in Graphics.graphicsList.Where(i => i.graphType == this.graphType).ToList())
            {
                item.Close();
            }
            Graphics.graphicsList.RemoveAll(i => i.graphType == this.graphType);
            Graphics.oldGraph = null;
        }

        private void popupBtn_Click(object sender, EventArgs e)
        {
            Graphics.graphicsList.Add(new Graphics(graphType));
            Graphics.graphicsList.Last().popupBtn.Visible = false;
            Graphics.graphicsList.Last().Show();
        }
    }
}
