using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            UITools.PIDForm.sendButton = sendButton;
            UITools.PIDForm.queryButton = queryButton;
            UITools.PIDForm.logBox = logBox;
            UITools.PIDForm.logWriter = new ConsoleTextBoxWriter(logBox);
        }

        private void PIDTuningForm_Load(object sender, EventArgs e)
        {
            
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

        private void sendButton_Click(object sender, EventArgs e)
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
            UITools.PIDForm.logWriter.WriteLine("PID sent");

        }

        private void queryButton_Click(object sender, EventArgs e)
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
            UITools.PIDForm.logWriter.WriteLine("Query sent");
        }
    }
}
