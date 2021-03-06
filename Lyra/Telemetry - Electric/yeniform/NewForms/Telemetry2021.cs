using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Telemetri.Variables;
using Telemetri.NewForms;

namespace Telemetri.NewForms
{
    public partial class Telemetry2021 : Form
    {
        public Telemetry2021()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (FormManagement.activeForm != null) FormManagement.activeForm.Close();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(new Map(), panelChildForm);
        }

        private void btnBattery_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(new BMS(), panelChildForm);
        }

        private void btnMotorDriver_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(new MotorDriver(), panelChildForm);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Telemetry2021_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            listBox1.Items.AddRange(ports);
        }

        private void mqttButton_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(new MQTTdeneme(), panelChildForm);
        }
    }
}
