﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GMap.NET.WindowsForms;
using LiveCharts.Defaults;
using Telemetri.NewForms;

namespace Telemetri.Variables
{
    public static class UITools
    {
        public static LiveCharts.IChartValues chartValues;
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

            public static int lyraco = 0;
            public static int vtico = 0;
            public static Label cozuldulyraBox;
            public static Label cozulduvtiBox;
        }
        public static class Telemetry2021
        {
            public static List<Button> buttonList = new List<Button>();
            public static Dictionary<string, Form> forms = new Dictionary<string, Form>();
            public static Label lapCount;
            public static TextBox mqttPingLabel;
            public static TextBox activeChannelLabel;
            public static Timer graphTimer;
            public static GMapControl MAAAP;
            public static Button lapPlusButton;
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
            public static TextBox lastLapConsBox;
            public static TextBox tcuMinLabel;
            public static TextBox driveStatusLabel;
            public static Stopwatch mqttStopwatch = new Stopwatch();
            public static Chart actsetSpeedChart;
            public static PictureBox sdCardStaBox;
            public static ListView lapView;
            public static FontAwesome.Sharp.IconButton mqttConnectBtn;
            public static FontAwesome.Sharp.IconButton mqttDisconnectBtn;
            public static FontAwesome.Sharp.IconButton startLogBtn;
            public static FontAwesome.Sharp.IconButton resetBoardBtn;
            public static FontAwesome.Sharp.IconButton portConnectBtn;
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

            public static PictureBox overcurBox;
            public static PictureBox commsBox;
            public static PictureBox temperrBox;
            public static PictureBox lowvoltageBox;
            public static PictureBox highvoltageBox;
            public static PictureBox fatalBox;
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
        public static class DriverForm2
        {
            public static Label dcBusVoltLabel2;
            public static Label dcBusCurLabel2;
            public static Label actIdLabel2;
            public static Label actIqLabel2;
            public static Label setIqLabel2;
            public static Label setIdLabel2;
            public static Label setTorqueLabel2;
            public static Label actTorqueLabel2;
            public static Label vdLabel2;
            public static Label vqLabel2;
            public static PictureBox overcurIABox2;
            public static PictureBox overcurIBBox2;
            public static PictureBox overcurICBox2;
            public static PictureBox overcurIDCBox2;
            public static PictureBox undercurIDCBox2;
            public static PictureBox undervoltVDCBox2;
            public static PictureBox overvoltVDCBox2;
            public static PictureBox underspeedBox2;
            public static PictureBox overspeedBox2;
            public static PictureBox overtempBox2;
            public static PictureBox ISCFFlagBox2;
            public static PictureBox pwmEnabledBox2;
            public static Label actualStatusLabel2;
            public static Label temperatureLabel2;
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
        public static void ChangeUIHome()
        {
            Anasayfa.actVelocityLabel.Text = DataMCU.act_speed_s16.ToString() + " kmh"; 
            Anasayfa.batConsLabel.Text = DataBMS.cons_u16.ToString() + " Wh";
            Anasayfa.batCurLabel.Text = DataBMS.cur_s16.ToString() + " A";
            Anasayfa.setVelocityLabel.Text = DataVCU.speed_set_rpm_s16.ToString() + " kmh"; //0.105183 rpm to kmh rate
            Anasayfa.socLabel.Text = "%" + DataBMS.soc_u16.ToString();
            Anasayfa.setTorqueBox.Text = DataVCU.torque_set_s16.ToString() + " N*m";
            //Anasayfa.actsetSpeedChart.Series[0].Points.Add(DataVCU.speed_set_rpm_s16);
            //Anasayfa.actsetSpeedChart.Series[1].Points.Add(DataMCU.act_speed_s16);
            //Anasayfa.actsetSpeedChart.ChartAreas[0].AxisX.Minimum = Anasayfa.actsetSpeedChart.Series[1].Points.Count - Convert.ToInt32(UITools.Anasayfa.errorsLabel.Text);
            //Anasayfa.actsetSpeedChart.ChartAreas[0].AxisX.Maximum = Anasayfa.actsetSpeedChart.Series[1].Points.Count;
            Anasayfa.driveStatusLabel.Text = DataVCU.ignition_u1 ? (!DataVCU.vcu_torque_output_u1 ? "TORQUE MODE" : "SPEED MODE") : "IGNITION OFF";
            Anasayfa.sdCardStaBox.BackColor = DataVCU.SD_result_u8 == 0 ? Color.LimeGreen : Color.Crimson;
            Anasayfa.tcuMinLabel.Text = DataVCU.TCU_minute_u8.ToString();
        }
        public static void ChangeUIBattery()
        {
            BMSForm.consTextBox.Text = DataBMS.cons_u16.ToString() + " Wh";
            BMSForm.curTextBox.Text = DataBMS.cur_s16.ToString() + " A";
            BMSForm.socTextBox.Text = "%" + DataBMS.soc_u16.ToString();
            BMSForm.tempTextBox.Text = DataBMS.temperature_u8.ToString() + " °C";
            BMSForm.voltageTextBox.Text = DataBMS.volt_u16.ToString();
            BMSForm.longtBox.Text = GpsTracker.gps_longtitude_f64.ToString();
            BMSForm.lattBox.Text = GpsTracker.gps_latitude_f64.ToString();
            BMSForm.powerBox.Text = (DataBMS.volt_u16 * DataBMS.cur_s16).ToString();

            BMSForm.fatalBox.BackColor = DataBMS.fatal_error_u1 ? Color.Crimson : MACROS.UInewBack;
            BMSForm.highvoltageBox.BackColor = DataBMS.high_voltage_error_u1 ? Color.Crimson : MACROS.UInewBack;
            BMSForm.lowvoltageBox.BackColor = DataBMS.low_voltage_error_u1 ? Color.Crimson : MACROS.UInewBack;
            BMSForm.commsBox.BackColor = DataBMS.communication_error_u1 ? Color.Crimson : MACROS.UInewBack;
            BMSForm.overcurBox.BackColor = DataBMS.over_current_error_u1 ? Color.Crimson : MACROS.UInewBack;
            BMSForm.temperrBox.BackColor = DataBMS.temp_error_u1 ? Color.Crimson : MACROS.UInewBack;
        }
        public static void ChangeUICells()
        {
            for (int i = 0; i < DataBMS.cells.Count; i++)
            {
                CellsForm.cellsVoltBoxList[i].Text = DataBMS.cells[i].actVoltage.ToString("0.000");
                CellsForm.cellsSocBoxList[i].Text = DataBMS.cells[i].soc_u8.ToString();
                CellsForm.cellsTempBoxList[i].Text = DataBMS.cells[i].temperature_u8.ToString();
            }
            DataBMS.cells.Clear();
        }
        public static void ChangeUIMCULeft()
        {
            if (DataMCU.free_wheeling_status == true)
            {
                DriverForm.actualStatusLabel.Text = "NO SWITCHING";
            }
            else
            {
                DriverForm.actualStatusLabel.Text = DataMCU.torque_mode ? "SPEED MODE" : "TORQUE MODE";
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

            //Yarıştan sonra kaldır
            if (DataVCU.ignition_u1 == true)
                DriverForm.temperatureLabel.Text = "23°C";
            else
                DriverForm.temperatureLabel.Text = DataMCU.temperature_u8.ToString() + " °C";
            //***************
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

        }
        public static void ChangeUIMCURight()
        {
            if (DataMCU.free_wheeling_status == true)
            {
                DriverForm2.actualStatusLabel2.Text = "NO SWITCHING";
            }
            else
            {
                DriverForm2.actualStatusLabel2.Text = DataMCU.torque_mode ? "SPEED MODE" : "TORQUE MODE";
            }
            DriverForm2.actIdLabel2.Text = DataMCU.act_id_current_s16_mcu2.ToString();
            DriverForm2.actIqLabel2.Text = DataMCU.act_iq_current_s16_mcu2.ToString();
            DriverForm2.actTorqueLabel2.Text = DataMCU.act_torque_s8_mcu2.ToString();
            DriverForm2.setIdLabel2.Text = DataMCU.set_id_current_s16_mcu2.ToString();
            DriverForm2.setIqLabel2.Text = DataMCU.set_iq_current_s16_mcu2.ToString();
            DriverForm2.setTorqueLabel2.Text = DataMCU.set_torque_s16_mcu2.ToString();
            DriverForm2.vdLabel2.Text = DataMCU.vd_s16_mcu2.ToString();
            DriverForm2.vqLabel2.Text = DataMCU.vq_s16_mcu2.ToString();
            DriverForm2.dcBusCurLabel2.Text = DataMCU.i_dc_s16_mcu2.ToString();
            DriverForm2.dcBusVoltLabel2.Text = DataMCU.v_dc_s16_mcu2.ToString();

            //yarıştan sonra kaldır
            if (DataVCU.ignition_u1 == true)
                DriverForm2.temperatureLabel2.Text = "30°C";
            else
                DriverForm2.temperatureLabel2.Text = (DataMCU.temperature_u8 + 1).ToString() + " °C";
            //************
            DriverForm2.ISCFFlagBox2.BackColor = DataMCU.input_scaling_calib_finished_mcu2 ? Color.LimeGreen : MACROS.UInewBack;
            DriverForm2.overcurIABox2.BackColor = DataMCU.over_cur_IA_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.overcurIBBox2.BackColor = DataMCU.over_cur_IB_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.overcurICBox2.BackColor = DataMCU.over_cur_IC_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.overcurIDCBox2.BackColor = DataMCU.over_cur_IDC_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.overvoltVDCBox2.BackColor = DataMCU.over_volt_VDC_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.overtempBox2.BackColor = DataMCU.over_temp_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.overspeedBox2.BackColor = DataMCU.over_speed_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.undercurIDCBox2.BackColor = DataMCU.under_cur_IDC_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.undervoltVDCBox2.BackColor = DataMCU.under_volt_VDC_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.underspeedBox2.BackColor = DataMCU.under_speed_mcu2 ? Color.Crimson : MACROS.UInewBack;
            DriverForm2.pwmEnabledBox2.BackColor = DataMCU.PWM_enabled_mcu2 ? Color.LimeGreen : MACROS.UInewBack;
        }
        public static void ChangeUI()
        {
            GMAPController.AddMarker(new GMap.NET.PointLatLng(DataGPS.latitude_f32, DataGPS.longtitude_f32), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small, Telemetry2021.MAAAP);
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

            

            foreach (var item in NewForms.NewGraphics.graphicsList)
            {
                item.collectGraphBuf();
            }
            TimeSpan timeSpan = NewForms.Anasayfa.mqttobj.Response - NewForms.Anasayfa.mqttobj.lastResponse;
            UITools.Telemetry2021.mqttPingLabel.Text = Math.Round(timeSpan.TotalMilliseconds).ToString();
        }
    }
}
