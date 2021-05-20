using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.NewForms;

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
        }
        public static class BMSForm
        {
            public static TextBox voltageTextBox;
            public static TextBox consTextBox;
            public static TextBox tempTextBox;
            public static TextBox curTextBox;
            public static TextBox socTextBox;
        }
        public static class DriverForm
        {
            public static Label phaseALabel;
            public static Label phaseBLabel;
            public static Label dcBusVoltLabel;
            public static Label dcBusCurLabel;
            public static Label IdLabel;
            public static Label IqLabel;
            public static Label IArmsLabel;
            public static Label TorqueLabel;
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
            Anasayfa.actVelocityLabel.Text = Driver.actual_velocity_u8.ToString();
            Anasayfa.batConsLabel.Text = BMS.bat_cons_f32.ToString();
            Anasayfa.batCurLabel.Text = BMS.bat_current_f32.ToString();
            Anasayfa.setVelocityLabel.Text = VCU.set_velocity_u8.ToString();
            Anasayfa.socLabel.Text = "%" + BMS.soc_f32.ToString();

            BMSForm.consTextBox.Text = BMS.bat_cons_f32.ToString();
            BMSForm.curTextBox.Text = BMS.bat_current_f32.ToString();
            BMSForm.socTextBox.Text = "%" + BMS.soc_f32.ToString();
            BMSForm.tempTextBox.Text = BMS.temp_u8.ToString();
            BMSForm.voltageTextBox.Text = BMS.bat_volt_f32.ToString();
           
            DriverForm.dcBusCurLabel.Text = Driver.dc_bus_current_f32.ToString();
            DriverForm.dcBusVoltLabel.Text = Driver.dc_bus_voltage_f32.ToString();
            DriverForm.IArmsLabel.Text = Driver.IArms_f32.ToString();
            DriverForm.IdLabel.Text = Driver.id_f32.ToString();
            DriverForm.IqLabel.Text = Driver.iq_f32.ToString();
            DriverForm.phaseALabel.Text = Driver.phase_a_current_f32.ToString();
            DriverForm.phaseBLabel.Text = Driver.phase_b_current_f32.ToString();
            DriverForm.TorqueLabel.Text = Driver.Torque_f32.ToString();

            foreach (var item in Graphics.graphicsList)
            {
                item.changeGraph(Graphics.graphTime);
            }
            Graphics.graphTime++;
        }
    }
}
