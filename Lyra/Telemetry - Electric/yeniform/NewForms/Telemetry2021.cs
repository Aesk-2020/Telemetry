using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//47 136 202

namespace PlayerUI
{
    public partial class Telemetry2021 : Form
    {
        public Telemetry2021()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(FormManagement.activeForm != null) FormManagement.activeForm.Close();
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {

        }

        /*private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/
    }
}
