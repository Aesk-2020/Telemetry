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
            UITools.DriverForm.dcBusCurLabel = dcBusCurLabel;
            UITools.DriverForm.dcBusVoltLabel = dcBusVoltLabel;
            UITools.DriverForm.IArmsLabel = IArmsLabel;
            UITools.DriverForm.IdLabel = IdLabel;
            UITools.DriverForm.IqLabel = IqLabel;
            UITools.DriverForm.phaseALabel = phaseALabel;
            UITools.DriverForm.phaseBLabel = phaseBLabel;
            UITools.DriverForm.TorqueLabel = TorqueLabel;
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
            SetDoubleBuffered(dcBusCurGraphBtn);
            SetDoubleBuffered(dcBusVoltGraphBtn);
            SetDoubleBuffered(iarmsGraphBtn);
            SetDoubleBuffered(idGraphBtn);
            SetDoubleBuffered(iqGraphBtn);
            SetDoubleBuffered(phaseAGraphBtn);
            SetDoubleBuffered(phaseBGraphBtn);
            SetDoubleBuffered(torqueGraphBtn);
            #endregion
        }

        private void graphicsButton_Click(object sender, EventArgs e)
        {
            if (graphicsButton.Dock == DockStyle.Bottom)
            {
                graphicsButton.Dock = DockStyle.Top;
                phaseAGraphBtn.Visible = true;
                phaseBGraphBtn.Visible = true;
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
                phaseAGraphBtn.Visible = false;
                phaseBGraphBtn.Visible = false;
                dcBusCurGraphBtn.Visible = false;
                dcBusVoltGraphBtn.Visible = false;
                idGraphBtn.Visible = false;
                iqGraphBtn.Visible = false;
                iarmsGraphBtn.Visible = false;
                torqueGraphBtn.Visible = false;
            }
        }

        private void phaseAGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.phaseACur;
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

        private void phaseBGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.phaseBCur;
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
            graphType = Graphics.graphs.iq;
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
    }
}
