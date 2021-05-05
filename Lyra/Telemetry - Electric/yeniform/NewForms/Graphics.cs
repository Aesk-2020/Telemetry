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
        private graphs _graphType = 0;

        public Graphics(graphs a)
        {
            InitializeComponent();
            _graphType = a;

            switch (_graphType)
            {
                case graphs.batCur:
                    myChart.Series[0].Name = "Battery Current";
                    break;
                case graphs.batVolt:
                    myChart.Series[0].Name = "Battery Voltage";
                    break;
                case graphs.batCons:
                    myChart.Series[0].Name = "Battery Consumption";
                    break;
                case graphs.batTemp:
                    myChart.Series[0].Name = "Battery Temperature";
                    break;
                case graphs.phaseACur:
                    myChart.Series[0].Name = "Phase A Current";
                    break;
                case graphs.phaseBCur:
                    myChart.Series[0].Name = "Phase B Current";
                    break;
                case graphs.dcBusCur:
                    myChart.Series[0].Name = "DC Bus Current";
                    break;
                case graphs.dcBusVolt:
                    myChart.Series[0].Name = "DC Bus Voltage";
                    break;
                case graphs.iarms:
                    myChart.Series[0].Name = "Iarms";
                    break;
                case graphs.iq:
                    myChart.Series[0].Name = "IQ";
                    break;
                case graphs.id:
                    myChart.Series[0].Name = "ID";
                    break;
                case graphs.torque:
                    myChart.Series[0].Name = "Torque";
                    break;
            }
        }

        public void changeGraph(double t)
        {
            switch(_graphType)
            {
                case graphs.batCur:
                    myChart.Series[0].Points.AddXY(t,BMS.bat_current_f32);
                    break;
                case graphs.batVolt:
                    myChart.Series[0].Points.AddXY(t, BMS.bat_volt_f32);
                    break;
                case graphs.batCons:
                    myChart.Series[0].Points.AddXY(t, BMS.bat_cons_f32);
                    break;
                case graphs.batTemp:
                    myChart.Series[0].Points.AddXY(t, BMS.temp_u8);
                    break;
                case graphs.phaseACur:
                    myChart.Series[0].Points.AddXY(t, Driver.phase_a_current_f32);
                    break;
                case graphs.phaseBCur:
                    myChart.Series[0].Points.AddXY(t, Driver.phase_b_current_f32);
                    break;
                case graphs.dcBusCur:
                    myChart.Series[0].Points.AddXY(t, Driver.dc_bus_current_f32);
                    break;
                case graphs.dcBusVolt:
                    myChart.Series[0].Points.AddXY(t, Driver.dc_bus_voltage_f32);
                    break;
                case graphs.iarms:
                    myChart.Series[0].Points.AddXY(t, Driver.IArms_f32);
                    break;
                case graphs.iq:
                    myChart.Series[0].Points.AddXY(t, Driver.iq_f32);
                    break;
                case graphs.id:
                    myChart.Series[0].Points.AddXY(t, Driver.id_f32);
                    break;
                case graphs.torque:
                    myChart.Series[0].Points.AddXY(t, Driver.Torque_f32);
                    break;
            }
                
        }
        
    }
}
