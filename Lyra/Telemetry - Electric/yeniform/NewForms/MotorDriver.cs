using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telemetri.NewForms
{
    public partial class MotorDriver : Form
    {
        public MotorDriver()
        {
            InitializeComponent();
        }

        private void MotorDriver_Load(object sender, EventArgs e)
        {
            mcuChart.Series[0].Points.AddXY(5, 5);
            mcuChart.Series[1].Points.AddXY(5, 5);
        }
    }
}
