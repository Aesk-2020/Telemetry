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

        public Driver_Form()
        {
            InitializeComponent();
            graphicsButton.Dock = DockStyle.Bottom;
        }

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
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
        }

        private void phaseBGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.phaseBCur;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
        }

        private void dcBusVoltGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.dcBusVolt;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
        }

        private void dcBusCurGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.dcBusCur;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
        }

        private void idGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.id;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
        }

        private void iqGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.iq;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
        }

        private void iarmsGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.iarms;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
        }

        private void torqueGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.torque;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
        }
    }
}
