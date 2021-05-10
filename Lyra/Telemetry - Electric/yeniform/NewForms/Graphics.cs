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
            phaseACur = 4,
            phaseBCur = 5,
            dcBusVolt = 6,
            dcBusCur = 7,
            id = 8,
            iq = 9,
            iarms = 10,
            torque = 11,
        }
        public Action<int> changeGraph = null;
        private graphs _graphType = 0;

        public Graphics(graphs a)
        {
            InitializeComponent();
            _graphType = a;

            switch (_graphType)
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
                case graphs.phaseACur:
                    myChart.Series[0].Name = "Phase A Current";
                    changeGraph = this.changePhaseACur;
                    break;
                case graphs.phaseBCur:
                    myChart.Series[0].Name = "Phase B Current";
                    changeGraph = this.changePhaseBCur;
                    break;
                case graphs.dcBusCur:
                    myChart.Series[0].Name = "DC Bus Current";
                    changeGraph = this.changeDcBusCur;
                    break;
                case graphs.dcBusVolt:
                    myChart.Series[0].Name = "DC Bus Voltage";
                    changeGraph = this.changeDcBusVolt;
                    break;
                case graphs.iarms:
                    myChart.Series[0].Name = "Iarms";
                    changeGraph = this.changeIarms;
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
        private void changeBatCur(int t)
        {
            myChart.Series[0].Points.AddXY(t, BMS.bat_current_f32);
        }
        private void changeBatVolt(int t)
        {
            myChart.Series[0].Points.AddXY(t, BMS.bat_volt_f32);
        }
        private void changeBatCons(int t)
        {
            myChart.Series[0].Points.AddXY(t, BMS.bat_cons_f32);
        }
        private void changeBatTemp(int t)
        {
            myChart.Series[0].Points.AddXY(t, BMS.temp_u8);
        }
        private void changePhaseACur(int t)
        {
            myChart.Series[0].Points.AddXY(t, Driver.phase_a_current_f32);
        }
        private void changePhaseBCur(int t)
        {
            myChart.Series[0].Points.AddXY(t, Driver.phase_b_current_f32);
        }
        private void changeDcBusCur(int t)
        {
            myChart.Series[0].Points.AddXY(t, Driver.dc_bus_current_f32);
        }
        private void changeDcBusVolt(int t)
        {
            myChart.Series[0].Points.AddXY(t, Driver.dc_bus_voltage_f32);
        }
        private void changeIarms(int t)
        {
            myChart.Series[0].Points.AddXY(t, Driver.IArms_f32);
        }
        private void changeIQ(int t)
        {
            myChart.Series[0].Points.AddXY(t, Driver.iq_f32);
        }
        private void changeID(int t)
        {
            myChart.Series[0].Points.AddXY(t, Driver.id_f32);
        }
        private void changeTorque(int t)
        {
            myChart.Series[0].Points.AddXY(t, Driver.Torque_f32);
        }

        private void clsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupBtn_Click(object sender, EventArgs e)
        {
            Graphics graphics = new Graphics(this._graphType);
            graphics.popupBtn.Visible = false;
            graphics.Show();
            this.Show();
        }
    }
}
