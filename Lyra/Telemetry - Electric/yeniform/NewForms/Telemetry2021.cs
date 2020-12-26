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
            FormManagement.openChildForm(new Harita(), panelChildForm);
        }

        private void btnBMS_Click(object sender, EventArgs e)
        {
            FormManagement.openChildForm(new BMS(), panelChildForm);
        }
    }
}
