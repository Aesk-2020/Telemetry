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
    public partial class PIDTuningForm : Form
    {
        public PIDTuningForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComproUI comproUI;
            float kp = float.Parse(kpBox.Text);
            float ki = float.Parse(kiBox.Text);
            float kd = float.Parse(kdBox.Text);
            List<byte> newlist = new List<byte>();
            newlist.AddRange(BitConverter.GetBytes(kp));
            newlist.AddRange(BitConverter.GetBytes(kd));
            newlist.AddRange(BitConverter.GetBytes(ki));

            comproUI = new ComproUI(0x31, ComproUI.VCU | ComproUI.TELEMETRI, newlist.ToArray(), (byte)newlist.Count, 19);
            comproUI.msg_index++;
            comproUI.CreateBuffer();
            
            Anasayfa.mqttobj.client.Publish("interface_to_vehicle", comproUI.buffer);
            //Anasayfa.serialPortCOMRF.write(comproUI.buffer);
        }

        private void PIDTuningForm_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComproUI comproUII = new ComproUI(0x31, ComproUI.VCU | ComproUI.TELEMETRI, new byte[] { 0 }, 1, 20);
            List<byte> listo = new List<byte>();
            listo.Add(0);
            comproUII.message = listo.ToArray();
            comproUII.msg_size = (byte)comproUII.message.Length;
            comproUII.vehicle_id = 0x31;
            comproUII.source_msg_id = 20;
            comproUII.msg_index++;
            comproUII.CreateBuffer();
            Anasayfa.mqttobj.client.Publish("interface_to_vehicle", comproUII.buffer);
        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            kpBox.Text = ((float) macTrackBar1.Value / 100).ToString("0.00");
        }

        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            kiBox.Text = ((float)macTrackBar2.Value / 100).ToString("0.00");
        }

        private void macTrackBar3_ValueChanged(object sender, decimal value)
        {
            kdBox.Text = ((float)macTrackBar3.Value / 100).ToString("0.00");
        }
    }
}
