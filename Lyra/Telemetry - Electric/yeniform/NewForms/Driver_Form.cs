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
    public partial class Driver_Form : Form
    {
        Graphics.graphs graphType = new Graphics.graphs();
        public static Form oldForm = null;
        public Driver_Form()
        {
            InitializeComponent();
            graphicsButton.Dock = DockStyle.Bottom;
            UITools.DriverForm.dcBusCurLabel        = dcBusCurLabel;
            UITools.DriverForm.dcBusVoltLabel       = dcBusVoltLabel;
            UITools.DriverForm.actIdLabel           = actIDLabel;
            UITools.DriverForm.actIqLabel           = actIQLabel;
            UITools.DriverForm.setIdLabel           = setIDLabel;
            UITools.DriverForm.setIqLabel           = setIQLabel;
            UITools.DriverForm.vdLabel              = vdLabel;
            UITools.DriverForm.vqLabel              = vqLabel;
            UITools.DriverForm.setTorqueLabel       = setTorqueLabel;
            UITools.DriverForm.actTorqueLabel       = actTorqueLabel;
            UITools.DriverForm.overcurIABox         = overCurABox;
            UITools.DriverForm.overcurIBBox         = overCurBBox;
            UITools.DriverForm.overcurICBox         = overCurCBox;
            UITools.DriverForm.overcurIDCBox        = overCurIDCBox;
            UITools.DriverForm.undercurIDCBox       = underCurIDCBox;
            UITools.DriverForm.undervoltVDCBox      = undervoltVDCBox;
            UITools.DriverForm.overvoltVDCBox       = overVoltVDCBox;
            UITools.DriverForm.underspeedBox        = underspeedBox;
            UITools.DriverForm.overspeedBox         = overspeedBox;
            UITools.DriverForm.overtempBox          = overtempBox;
            UITools.DriverForm.ISCFFlagBox          = ISCFFlagBox;
            UITools.DriverForm.pwmEnabledBox        = pwmEnabledBox;
            UITools.DriverForm.actualStatusLabel    = actualStatusLabel;
            UITools.DriverForm.temperatureLabel     = temperatureLabel;

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

        private void MotorDriver_Load(object sender, EventArgs e)
        {
            
            #region doubleBuffer
            SetDoubleBuffered(tableLayoutPanel1);
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
            SetDoubleBuffered(dcBusCurGraphBtn);
            SetDoubleBuffered(dcBusVoltGraphBtn);
            SetDoubleBuffered(iarmsGraphBtn);
            SetDoubleBuffered(idGraphBtn);
            SetDoubleBuffered(iqGraphBtn);
            SetDoubleBuffered(VDBtn);
            SetDoubleBuffered(VQBtn);
            SetDoubleBuffered(torqueGraphBtn);
            #endregion
        }

        private void graphicsButton_Click(object sender, EventArgs e)
        {
            if (graphicsButton.Dock == DockStyle.Bottom)
            {
                graphicsButton.Dock = DockStyle.Top;
                VDBtn.Visible = true;
                VQBtn.Visible = true;
                dcBusCurGraphBtn.Visible = true;
                dcBusVoltGraphBtn.Visible = true;
                idGraphBtn.Visible = true;
                iqGraphBtn.Visible = true;
                iarmsGraphBtn.Visible = true;
                torqueGraphBtn.Visible = true;
            }
            else
            {
                graphicsButton.Dock = DockStyle.Bottom;
                VDBtn.Visible = false;
                VQBtn.Visible = false;
                dcBusCurGraphBtn.Visible = false;
                dcBusVoltGraphBtn.Visible = false;
                idGraphBtn.Visible = false;
                iqGraphBtn.Visible = false;
                iarmsGraphBtn.Visible = false;
                torqueGraphBtn.Visible = false;
            }
        }

        private void dcBusVoltGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.dcBusVolt;
            Graphics.graphicsList.Add(new Graphics(graphType));
            if (Graphics.oldGraph != null)
            {
                Graphics.oldGraph.Close();
                Graphics.graphicsList.Remove(Graphics.graphicsList.Where(i => i.graphType == Graphics.oldGraph.graphType).ToList()[0]);
            }
            Graphics.oldGraph = Graphics.graphicsList.Last();
            Graphics.oldGraph.TopLevel = false;
            Graphics.oldGraph.FormBorderStyle = FormBorderStyle.None;
            Graphics.oldGraph.Dock = DockStyle.Fill;
            Graphics.oldGraph.AutoScroll = true;
            graphPanel.Controls.Add(Graphics.oldGraph);
            Graphics.oldGraph.Show();
        }

        private void dcBusCurGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.dcBusCur;
            Graphics.graphicsList.Add(new Graphics(graphType));
            if (Graphics.oldGraph != null)
            {
                Graphics.oldGraph.Close();
                Graphics.graphicsList.Remove(Graphics.graphicsList.Where(i => i.graphType == Graphics.oldGraph.graphType).ToList()[0]);
            }
            Graphics.oldGraph = Graphics.graphicsList.Last();
            Graphics.oldGraph.TopLevel = false;
            Graphics.oldGraph.FormBorderStyle = FormBorderStyle.None;
            Graphics.oldGraph.Dock = DockStyle.Fill;
            Graphics.oldGraph.AutoScroll = true;
            graphPanel.Controls.Add(Graphics.oldGraph);
            Graphics.oldGraph.Show();
        }

        private void idGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.id;
            Graphics.graphicsList.Add(new Graphics(graphType));
            if (Graphics.oldGraph != null)
            {
                Graphics.oldGraph.Close();
                Graphics.graphicsList.Remove(Graphics.graphicsList.Where(i => i.graphType == Graphics.oldGraph.graphType).ToList()[0]);
            }
            Graphics.oldGraph = Graphics.graphicsList.Last();
            Graphics.oldGraph.TopLevel = false;
            Graphics.oldGraph.FormBorderStyle = FormBorderStyle.None;
            Graphics.oldGraph.Dock = DockStyle.Fill;
            Graphics.oldGraph.AutoScroll = true;
            graphPanel.Controls.Add(Graphics.oldGraph);
            Graphics.oldGraph.Show();
        }

        private void iqGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.iqActIq;
            Graphics.graphicsList.Add(new Graphics(graphType));
            if (Graphics.oldGraph != null)
            {
                Graphics.oldGraph.Close();
                Graphics.graphicsList.Remove(Graphics.graphicsList.Where(i => i.graphType == Graphics.oldGraph.graphType).ToList()[0]);
            }
            Graphics.oldGraph = Graphics.graphicsList.Last();
            Graphics.oldGraph.TopLevel = false;
            Graphics.oldGraph.FormBorderStyle = FormBorderStyle.None;
            Graphics.oldGraph.Dock = DockStyle.Fill;
            Graphics.oldGraph.AutoScroll = true;
            graphPanel.Controls.Add(Graphics.oldGraph);
            Graphics.oldGraph.Show();
        }

        private void iarmsGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.iarms;
            Graphics.graphicsList.Add(new Graphics(graphType));
            if (Graphics.oldGraph != null)
            {
                Graphics.oldGraph.Close();
                Graphics.graphicsList.Remove(Graphics.graphicsList.Where(i => i.graphType == Graphics.oldGraph.graphType).ToList()[0]);
            }
            Graphics.oldGraph = Graphics.graphicsList.Last();
            Graphics.oldGraph.TopLevel = false;
            Graphics.oldGraph.FormBorderStyle = FormBorderStyle.None;
            Graphics.oldGraph.Dock = DockStyle.Fill;
            Graphics.oldGraph.AutoScroll = true;
            graphPanel.Controls.Add(Graphics.oldGraph);
            Graphics.oldGraph.Show();
        }

        private void torqueGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.torque;
            Graphics.graphicsList.Add(new Graphics(graphType));
            if (Graphics.oldGraph != null)
            {
                Graphics.oldGraph.Close();
                Graphics.graphicsList.Remove(Graphics.graphicsList.Where(i => i.graphType == Graphics.oldGraph.graphType).ToList()[0]);
            }
            Graphics.oldGraph = Graphics.graphicsList.Last();
            Graphics.oldGraph.TopLevel = false;
            Graphics.oldGraph.FormBorderStyle = FormBorderStyle.None;
            Graphics.oldGraph.Dock = DockStyle.Fill;
            Graphics.oldGraph.AutoScroll = true;
            graphPanel.Controls.Add(Graphics.oldGraph);
            Graphics.oldGraph.Show();
        }

        private void VDBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.VD;
            Graphics.graphicsList.Add(new Graphics(graphType));
            if (Graphics.oldGraph != null)
            {
                Graphics.oldGraph.Close();
                Graphics.graphicsList.Remove(Graphics.graphicsList.Where(i => i.graphType == Graphics.oldGraph.graphType).ToList()[0]);
            }
            Graphics.oldGraph = Graphics.graphicsList.Last();
            Graphics.oldGraph.TopLevel = false;
            Graphics.oldGraph.FormBorderStyle = FormBorderStyle.None;
            Graphics.oldGraph.Dock = DockStyle.Fill;
            Graphics.oldGraph.AutoScroll = true;
            graphPanel.Controls.Add(Graphics.oldGraph);
            Graphics.oldGraph.Show();
        }

        private void VQBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.VQ;
            Graphics.graphicsList.Add(new Graphics(graphType));
            if (Graphics.oldGraph != null)
            {
                Graphics.oldGraph.Close();
                Graphics.graphicsList.Remove(Graphics.graphicsList.Where(i => i.graphType == Graphics.oldGraph.graphType).ToList()[0]);
            }
            Graphics.oldGraph = Graphics.graphicsList.Last();
            Graphics.oldGraph.TopLevel = false;
            Graphics.oldGraph.FormBorderStyle = FormBorderStyle.None;
            Graphics.oldGraph.Dock = DockStyle.Fill;
            Graphics.oldGraph.AutoScroll = true;
            graphPanel.Controls.Add(Graphics.oldGraph);
            Graphics.oldGraph.Show();
        }
    }
}
