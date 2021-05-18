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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            UITools.TestForms.actDriveModeBox = actDriveModeBox;
            UITools.TestForms.actIdBox = actIdBox;
            UITools.TestForms.actIqBox = actIqBox;
            UITools.TestForms.actSpeedBox = actSpeedBox;
            UITools.TestForms.setDriveModeBox = setDriveModeBox;
            UITools.TestForms.setIdBox = setIdBox;
            UITools.TestForms.setIqBox = setIqBox;
            UITools.TestForms.setTorqueBox = setTorqueBox;
            UITools.TestForms.setSpeedBox = setSpeedBox;
            UITools.TestForms.temperatureBox = temperatureBox;
            UITools.TestForms.saturationBox = saturationBox;
            UITools.TestForms.mqttBox = mqttBox;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
