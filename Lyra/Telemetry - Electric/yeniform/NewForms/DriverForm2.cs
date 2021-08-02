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
    public partial class DriverForm2 : Form
    {
        public DriverForm2()
        {
            InitializeComponent();

            UITools.DriverForm2.dcBusCurLabel2 = dcBusCurLabel;
            UITools.DriverForm2.dcBusVoltLabel2 = dcBusVoltLabel;
            UITools.DriverForm2.actIdLabel2 = actIDLabel;
            UITools.DriverForm2.actIqLabel2 = actIQLabel;
            UITools.DriverForm2.setIdLabel2 = setIDLabel;
            UITools.DriverForm2.setIqLabel2 = setIQLabel;
            UITools.DriverForm2.vdLabel2 = vdLabel;
            UITools.DriverForm2.vqLabel2 = vqLabel;
            UITools.DriverForm2.setTorqueLabel2 = setTorqueLabel;
            UITools.DriverForm2.actTorqueLabel2 = actTorqueLabel;
            UITools.DriverForm2.overcurIABox2 = overCurABox;
            UITools.DriverForm2.overcurIBBox2 = overCurBBox;
            UITools.DriverForm2.overcurICBox2 = overCurCBox;
            UITools.DriverForm2.overcurIDCBox2 = overCurIDCBox;
            UITools.DriverForm2.undercurIDCBox2 = underCurIDCBox;
            UITools.DriverForm2.undervoltVDCBox2 = undervoltVDCBox;
            UITools.DriverForm2.overvoltVDCBox2 = overVoltVDCBox;
            UITools.DriverForm2.underspeedBox2 = underspeedBox;
            UITools.DriverForm2.overspeedBox2 = overspeedBox;
            UITools.DriverForm2.overtempBox2 = overtempBox;
            UITools.DriverForm2.ISCFFlagBox2 = ISCFFlagBox;
            UITools.DriverForm2.pwmEnabledBox2 = pwmEnabledBox;
            UITools.DriverForm2.actualStatusLabel2 = actualStatusLabel;
            UITools.DriverForm2.temperatureLabel2 = temperatureLabel;
        }

        private void DriverForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion

        #region .. code for Flucuring ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
        private void DriverForm2_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(tableLayoutPanel2);
            SetDoubleBuffered(tableLayoutPanel3);
            SetDoubleBuffered(tableLayoutPanel4);
            SetDoubleBuffered(tableLayoutPanel5);
            SetDoubleBuffered(tableLayoutPanel6);
            SetDoubleBuffered(tableLayoutPanel7);
            SetDoubleBuffered(tableLayoutPanel8);
            SetDoubleBuffered(tableLayoutPanel9);
            SetDoubleBuffered(tableLayoutPanel10);
            SetDoubleBuffered(tableLayoutPanel11);
            SetDoubleBuffered(tableLayoutPanel12);
            SetDoubleBuffered(tableLayoutPanel13);
            SetDoubleBuffered(tableLayoutPanel14);
            SetDoubleBuffered(tableLayoutPanel15);
            SetDoubleBuffered(tableLayoutPanel16);
            SetDoubleBuffered(tableLayoutPanel17);
            SetDoubleBuffered(tableLayoutPanel18);
        }
    }
}
