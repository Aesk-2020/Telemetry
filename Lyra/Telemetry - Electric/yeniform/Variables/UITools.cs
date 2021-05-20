using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            public static TextBox driveStatusLabel;
            public static Stopwatch mqttStopwatch = new Stopwatch();
        }
        public static class BMSForm
        {
            public static TextBox voltageTextBox;
            public static TextBox consTextBox;
            public static TextBox tempTextBox;
            public static TextBox curTextBox;
            public static TextBox socTextBox;
            public static TextBox dcBusStateBox;
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
            public static Label errorsLabel;
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
            Anasayfa.actVelocityLabel.Text = Driver.actual_velocity_u8.ToString();  //DEĞİŞECEK
            Anasayfa.batConsLabel.Text = DataBMS.cons_u16.ToString();               
            Anasayfa.batCurLabel.Text = DataBMS.cur_s16.ToString();                 
            Anasayfa.setVelocityLabel.Text = VCU.set_velocity_u8.ToString();        //DEĞİŞECEK
            Anasayfa.socLabel.Text = "%" + DataBMS.soc_u16.ToString();              

            BMSForm.consTextBox.Text = DataBMS.cons_u16.ToString();
            BMSForm.curTextBox.Text = DataBMS.cur_s16.ToString();
            BMSForm.socTextBox.Text = "%" + DataBMS.soc_u16.ToString();
            BMSForm.tempTextBox.Text = DataBMS.temperature_u8.ToString();
            BMSForm.voltageTextBox.Text = DataBMS.volt_u16.ToString();

            if(DataMCU.free_wheeling_status == true)
            {
                DriverForm.actualStatusLabel.Text = "NO SWITCHING";
            }
            else
            {
                DriverForm.actualStatusLabel.Text = DataMCU.torque_mode ? "TORQUE MODE": "SPEED MODE";
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
                item.changeGraph(NewForms.Graphics.graphTime);
            }
            NewForms.Graphics.graphTime++;

            switch ((DataBMS.DC_BUS_STATE)DataBMS.dc_bus_state_u8)
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
            }
        }
    }
}
