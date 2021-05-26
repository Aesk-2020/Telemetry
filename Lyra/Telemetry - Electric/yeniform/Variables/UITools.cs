using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Telemetri.Variables
{
    public static class UITools
    {
        public static class TestForms
        {
            public static TextBox setTorqueBox;
            public static TextBox setSpeedBox;
            public static TextBox setIdBox;
            public static TextBox setIqBox;
            public static TextBox actSpeedBox;
            public static TextBox actIdBox;
            public static TextBox actIqBox;
            public static TextBox setDriveModeBox;
            public static TextBox actDriveModeBox;
            public static TextBox saturationBox;
            public static TextBox temperatureBox;
            public static TextBox mqttBox;
        }
        public static class Telemetry2021
        {
            public static List<Button> buttonList = new List<Button>();
            public static Dictionary<string, Form> forms = new Dictionary<string, Form>();
        }
        public static class Anasayfa
        {
            public static TextBox startTimeLabel;
            public static TextBox socLabel;
            public static TextBox batCurLabel;
            public static TextBox batConsLabel;
            public static TextBox setVelocityLabel;
            public static TextBox actVelocityLabel;
            public static TextBox errorsLabel;
            public static TextBox setTorqueBox;
            public static TextBox driveStatusLabel;
            public static Stopwatch mqttStopwatch = new Stopwatch();
            public static Chart actsetSpeedChart;
        }
        public static class BMSForm
        {
            public static TextBox voltageTextBox;
            public static TextBox consTextBox;
            public static TextBox tempTextBox;
            public static TextBox curTextBox;
            public static TextBox socTextBox;
            public static TextBox dcBusStateBox;
            public static TextBox lattBox;
            public static TextBox longtBox;
            public static TextBox powerBox;

            public static PictureBox prechargeBox;
            public static PictureBox dischargeBox;
            public static PictureBox dcBusReadyBox;
            public static PictureBox chargingBox;
            public static PictureBox balancingBox;
            public static PictureBox prechargeErrorBox;
        }
        public static class DriverForm
        {
            public static Label dcBusVoltLabel;
            public static Label dcBusCurLabel;
            public static Label actIdLabel;
            public static Label actIqLabel;
            public static Label setIqLabel;
            public static Label setIdLabel;
            public static Label setTorqueLabel;
            public static Label actTorqueLabel;
            public static Label vdLabel;
            public static Label vqLabel;
            public static PictureBox overcurIABox;
            public static PictureBox overcurIBBox;
            public static PictureBox overcurICBox;
            public static PictureBox overcurIDCBox;
            public static PictureBox undercurIDCBox;
            public static PictureBox undervoltVDCBox;
            public static PictureBox overvoltVDCBox;
            public static PictureBox underspeedBox;
            public static PictureBox overspeedBox;
            public static PictureBox overtempBox;
            public static PictureBox ISCFFlagBox;
            public static PictureBox pwmEnabledBox;
            public static Label actualStatusLabel;
            public static Label temperatureLabel;
        }
        public static class CellsForm
        {
            public static List<TextBox> cellsVoltBoxList = new List<TextBox>();
            public static List<TextBox> cellsTempBoxList = new List<TextBox>();
            public static List<TextBox> cellsSocBoxList = new List<TextBox>();
        }
        public static class PIDForm
        {
            public static Button sendButton;
            public static Button queryButton;
            public static TextBox logBox;
            public static ConsoleTextBoxWriter logWriter;
        }
        public static void ChangeUI()
        {
            Anasayfa.actVelocityLabel.Text = DataMCU.act_speed_s16.ToString() + " kmh"; 
            Anasayfa.batConsLabel.Text = DataBMS.cons_u16.ToString() + " Wh";
            Anasayfa.batCurLabel.Text = DataBMS.cur_s16.ToString() + " A";
            Anasayfa.setVelocityLabel.Text = DataVCU.speed_set_rpm_s16.ToString() + " kmh"; //0.105183 rpm to kmh rate
            Anasayfa.socLabel.Text = "%" + DataBMS.soc_u16.ToString();
            Anasayfa.setTorqueBox.Text = DataVCU.torque_set_s16.ToString() + " N*m";
            Anasayfa.actsetSpeedChart.Series[0].Points.Add(DataVCU.speed_set_rpm_s16);
            Anasayfa.actsetSpeedChart.Series[1].Points.Add(DataMCU.act_speed_s16);
            Anasayfa.actsetSpeedChart.ChartAreas[0].AxisX.Minimum = Anasayfa.actsetSpeedChart.Series[1].Points.Count - Convert.ToInt32(UITools.Anasayfa.errorsLabel.Text);
            Anasayfa.actsetSpeedChart.ChartAreas[0].AxisX.Maximum = Anasayfa.actsetSpeedChart.Series[1].Points.Count;

            BMSForm.consTextBox.Text = DataBMS.cons_u16.ToString() + " Wh";
            BMSForm.curTextBox.Text = DataBMS.cur_s16.ToString() + " A";
            BMSForm.socTextBox.Text = "%" + DataBMS.soc_u16.ToString();
            BMSForm.tempTextBox.Text = DataBMS.temperature_u8.ToString() + " °C";
            BMSForm.voltageTextBox.Text = DataBMS.volt_u16.ToString();
            BMSForm.longtBox.Text = GpsTracker.gps_longtitude_f64.ToString();
            BMSForm.lattBox.Text = GpsTracker.gps_latitude_f64.ToString();
            BMSForm.powerBox.Text = (DataBMS.volt_u16 * DataBMS.cur_s16).ToString();

            if (DataMCU.free_wheeling_status == true)
            {
                DriverForm.actualStatusLabel.Text = "NO SWITCHING";
            }
            else
            {
                DriverForm.actualStatusLabel.Text = DataMCU.torque_mode ? "TORQUE MODE" : "SPEED MODE";
            }
            DriverForm.actIdLabel.Text = DataMCU.act_id_current_s16.ToString();
            DriverForm.actIqLabel.Text = DataMCU.act_iq_current_s16.ToString();
            DriverForm.actTorqueLabel.Text = DataMCU.act_torque_s8.ToString();
            DriverForm.setIdLabel.Text = DataMCU.set_id_current_s16.ToString();
            DriverForm.setIqLabel.Text = DataMCU.set_iq_current_s16.ToString();
            DriverForm.setTorqueLabel.Text = DataMCU.set_torque_s16.ToString();
            DriverForm.vdLabel.Text = DataMCU.vd_s16.ToString();
            DriverForm.vqLabel.Text = DataMCU.vq_s16.ToString();
            DriverForm.dcBusCurLabel.Text = DataMCU.i_dc_s16.ToString();
            DriverForm.dcBusVoltLabel.Text = DataMCU.v_dc_s16.ToString();
            DriverForm.temperatureLabel.Text = DataMCU.temperature_u8.ToString();

            DriverForm.ISCFFlagBox.BackColor = DataMCU.input_scaling_calib_finished ? Color.LimeGreen : MACROS.UInewBack;
            DriverForm.overcurIABox.BackColor = DataMCU.over_cur_IA ? Color.Crimson : MACROS.UInewBack;
            DriverForm.overcurIBBox.BackColor = DataMCU.over_cur_IB ? Color.Crimson : MACROS.UInewBack;
            DriverForm.overcurICBox.BackColor = DataMCU.over_cur_IC ? Color.Crimson : MACROS.UInewBack;
            DriverForm.overcurIDCBox.BackColor = DataMCU.over_cur_IDC ? Color.Crimson : MACROS.UInewBack;
            DriverForm.overvoltVDCBox.BackColor = DataMCU.over_volt_VDC ? Color.Crimson : MACROS.UInewBack;
            DriverForm.overtempBox.BackColor = DataMCU.over_temp ? Color.Crimson : MACROS.UInewBack;
            DriverForm.overspeedBox.BackColor = DataMCU.over_speed ? Color.Crimson : MACROS.UInewBack;
            DriverForm.undercurIDCBox.BackColor = DataMCU.under_cur_IDC ? Color.Crimson : MACROS.UInewBack;
            DriverForm.undervoltVDCBox.BackColor = DataMCU.under_volt_VDC ? Color.Crimson : MACROS.UInewBack;
            DriverForm.underspeedBox.BackColor = DataMCU.under_speed ? Color.Crimson : MACROS.UInewBack;
            DriverForm.pwmEnabledBox.BackColor = DataMCU.PWM_enabled ? Color.LimeGreen : MACROS.UInewBack;

            foreach (var item in NewForms.Graphics.graphicsList)
            {
                item.changeGraph();
            }

            /*switch ((DataBMS.DC_BUS_STATE)DataBMS.dc_bus_state_u8)
            {
                case DataBMS.DC_BUS_STATE.PRECHARGE:
                    {
                        BMSForm.dcBusStateBox.Text = "PRECHARGE";
                        break;
                    }
                case DataBMS.DC_BUS_STATE.DISCHARGE:
                    {
                        BMSForm.dcBusStateBox.Text = "DISCHARGE";
                        break;
                    }
                case DataBMS.DC_BUS_STATE.READY:
                    {
                        BMSForm.dcBusStateBox.Text = "READY";
                        break;
                    }
                case DataBMS.DC_BUS_STATE.CHARGING:
                    {
                        BMSForm.dcBusStateBox.Text = "CHARGING";
                        break;
                    }
                case DataBMS.DC_BUS_STATE.BALANCE:
                    {
                        BMSForm.dcBusStateBox.Text = "BALANCE";
                        break;
                    }
                case DataBMS.DC_BUS_STATE.PRECHARGE_ERROR:
                    {
                        BMSForm.dcBusStateBox.Text = "PRECHARGE ERROR";
                        break;
                    }
                default:
                    {
                        BMSForm.dcBusStateBox.Text = "DATA ERROR";
                        break;
                    }
            }*/

            for (int i = 0; i < DataBMS.cells.Count; i++)
            {
                CellsForm.cellsVoltBoxList[i].Text = DataBMS.cells[i].voltage_u8.ToString();
                CellsForm.cellsSocBoxList[i].Text = DataBMS.cells[i].soc_u8.ToString();
                CellsForm.cellsTempBoxList[i].Text = DataBMS.cells[i].temperature_u8.ToString();
            }
            DataBMS.cells.Clear();
        }
    }
}
