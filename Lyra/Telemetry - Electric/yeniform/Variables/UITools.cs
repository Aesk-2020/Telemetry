using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telemetri.Variables
{
    public static class UITools
    {
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
    }
}
