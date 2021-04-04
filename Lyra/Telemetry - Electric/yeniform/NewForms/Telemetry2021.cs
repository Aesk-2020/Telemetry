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
            FormManagement.openChildForm(new Anasayfa(), panelChildForm);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(new Anasayfa(), panelChildForm);
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
        }

        private void mqttButton_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(new MQTTdeneme(), panelChildForm);
        }

        
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Telemetry2021.ActiveForm.Close();
        }

        private void logplyrButton_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(new LogPlayer(), panelChildForm);
        }

        private void lapPlusBtn_Click(object sender, EventArgs e)
        {
            lapCntLabel.Text = (Convert.ToDecimal(lapCntLabel.Text) + 1).ToString();
        }

        private void lapMinusBtn_Click(object sender, EventArgs e)
        {
            if(lapCntLabel.Text != "0") lapCntLabel.Text = (Convert.ToDecimal(lapCntLabel.Text) - 1).ToString();
        }

        private void LapResetBtn_Click(object sender, EventArgs e)
        {
            lapCntLabel.Text = "0";
        }
    }
}
