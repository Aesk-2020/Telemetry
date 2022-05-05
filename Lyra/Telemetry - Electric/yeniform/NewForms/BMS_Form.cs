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
    public partial class BMS_Form : Form
    {
        //Graphics.graphs graphType = new Graphics.graphs();

        public BMS_Form()
        {
            InitializeComponent();

            UITools.BMSForm.consTextBox = consTextBox;
            UITools.BMSForm.curTextBox = currentTextBox;
            UITools.BMSForm.socTextBox = socTextBox;
            UITools.BMSForm.tempTextBox = tempTextBox;
            UITools.BMSForm.voltageTextBox = voltageTextBox;
            UITools.BMSForm.prechargeBox = prechargeBox;
            UITools.BMSForm.dischargeBox = dischargeBox;
            UITools.BMSForm.dcBusReadyBox = dcBusReadyBox;
            UITools.BMSForm.balancingBox = balancingBox;
            UITools.BMSForm.chargingBox = chragingBox;
            UITools.BMSForm.prechargeErrorBox = prechargeErrorBox;
            UITools.BMSForm.lattBox = lattBox;
            UITools.BMSForm.longtBox = longtBox;
            UITools.BMSForm.powerBox = powerBox;

            UITools.BMSForm.overcurBox = overcurBox;
            UITools.BMSForm.commsBox = commsBox;
            UITools.BMSForm.temperrBox = temperrBox;
            UITools.BMSForm.lowvoltageBox = lowvoltageBox;
            UITools.BMSForm.highvoltageBox = highvoltageBox;
            UITools.BMSForm.fatalBox = fatalBox;
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
        private void BMS_Load(object sender, EventArgs e)
        {
            #region doubleBuffer
            SetDoubleBuffered(tableLayoutPanel10);
            SetDoubleBuffered(tableLayoutPanel11);
            SetDoubleBuffered(tableLayoutPanel12);
            SetDoubleBuffered(tableLayoutPanel13);
            SetDoubleBuffered(tableLayoutPanel14);
            SetDoubleBuffered(tableLayoutPanel3);
            SetDoubleBuffered(tableLayoutPanel8);
            SetDoubleBuffered(tableLayoutPanel9);
            SetDoubleBuffered(tableLayoutPanel6);
            SetDoubleBuffered(tableLayoutPanel4);
            #endregion
        }
    }
}
