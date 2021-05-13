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
        Graphics.graphs graphType = new Graphics.graphs();

        public BMS_Form()
        {
            InitializeComponent();
            graphicsButton.Dock = DockStyle.Bottom;

            TextBox[] textBoxs = {voltageTextBox, consTextBox, tempTextBox,
                currentTextBox, socTextBox };
            UITools.BMSForm.consTextBox = consTextBox;
            UITools.BMSForm.curTextBox = currentTextBox;
            UITools.BMSForm.socTextBox = socTextBox;
            UITools.BMSForm.tempTextBox = tempTextBox;
            UITools.BMSForm.voltageTextBox = voltageTextBox;
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
            SetDoubleBuffered(batConsGraphBtn);
            SetDoubleBuffered(batCurGraphBtn);
            SetDoubleBuffered(batTempGraphBtn);
            SetDoubleBuffered(batVoltGraphBtn);
            #endregion
        }

        private void graphicsButton_Click(object sender, EventArgs e)
        {
            if(graphicsButton.Dock == DockStyle.Bottom)
            {
                graphicsButton.Dock = DockStyle.Top;
                batConsGraphBtn.Visible = true;
                batCurGraphBtn.Visible = true;
                batVoltGraphBtn.Visible = true;
                batTempGraphBtn.Visible = true;
            }
            else
            {
                graphicsButton.Dock = DockStyle.Bottom;
                batConsGraphBtn.Visible = false;
                batCurGraphBtn.Visible = false;
                batVoltGraphBtn.Visible = false;
                batTempGraphBtn.Visible = false;
            }
        }

        private void batVoltGraphBtn_Click(object sender, EventArgs e)
        {
            
            graphType = Graphics.graphs.batVolt;
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
            
            //graphics.changeGraph(time)    BURADA GRAFİĞİ GÜNCELLEYEN TIMER BAŞLATILACAK
        }

        private void batCurGraphBtn_Click(object sender, EventArgs e)
        {

            graphType = Graphics.graphs.batCur;
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
            //graphics.changeGraph(time)    BURADA GRAFİĞİ GÜNCELLEYEN TIMER BAŞLATILACAK
        }

        private void batTempGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.batTemp;
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
            //graphics.changeGraph(time)    BURADA GRAFİĞİ GÜNCELLEYEN TIMER BAŞLATILACAK
        }

        private void batConsGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.batCons;
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
            //graphics.changeGraph(time)    BURADA GRAFİĞİ GÜNCELLEYEN TIMER BAŞLATILACAK
        }
    }
}
