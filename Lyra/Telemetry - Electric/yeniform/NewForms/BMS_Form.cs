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
        }

        private void BMS_Load(object sender, EventArgs e)
        {
            UITools.BMSForm.consTextBox = consTextBox;
            UITools.BMSForm.curTextBox = currentTextBox;
            UITools.BMSForm.socTextBox = socTextBox;
            UITools.BMSForm.tempTextBox = tempTextBox;
            UITools.BMSForm.voltageTextBox = voltageTextBox;
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
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
            //graphics.changeGraph(time)    BURADA GRAFİĞİ GÜNCELLEYEN TIMER BAŞLATILACAK
        }

        private void batCurGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.batCur;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
            //graphics.changeGraph(time)    BURADA GRAFİĞİ GÜNCELLEYEN TIMER BAŞLATILACAK
        }

        private void batTempGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.batTemp;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
            //graphics.changeGraph(time)    BURADA GRAFİĞİ GÜNCELLEYEN TIMER BAŞLATILACAK
        }

        private void batConsGraphBtn_Click(object sender, EventArgs e)
        {
            graphType = Graphics.graphs.batCons;
            Graphics graphics = new Graphics(graphType);
            graphics.Show();
            //graphics.changeGraph(time)    BURADA GRAFİĞİ GÜNCELLEYEN TIMER BAŞLATILACAK
        }
    }
}
