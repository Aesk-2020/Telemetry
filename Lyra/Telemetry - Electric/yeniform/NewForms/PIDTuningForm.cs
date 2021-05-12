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
        ComproUI comproUI = new ComproUI();

        public PIDTuningForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "MCU":
                    comproUI.target_id |= ComproUI.MCU;
                    break;
                case "VCU":
                    comproUI.target_id |= ComproUI.VCU;
                    break;
                case "BMS":
                    comproUI.target_id |= ComproUI.BMS;
                    break;
                case "CHARGER":
                    comproUI.target_id |= ComproUI.CHARGER;
                    break;
                default:
                    break;
            }
            comproUI.msg_index++;
            float kp = float.Parse(kpBox.Text);
            float ki = float.Parse(kiBox.Text);
            float kd = float.Parse(kdBox.Text);
            List<byte> newlist = new List<byte>();
            newlist.AddRange(BitConverter.GetBytes(kp));
            newlist.AddRange(BitConverter.GetBytes(kd));
            newlist.AddRange(BitConverter.GetBytes(ki));
            comproUI.message = newlist.ToArray();
            comproUI.msg_size = (byte)comproUI.message.Length;
            comproUI.vehicle_id = 0x31;
            comproUI.source_msg_id = 19;
            comproUI.CreateBuffer();
            Anasayfa.mqttobj.client.Publish("interface_to_vehicle", comproUI.buffer);
            //Anasayfa.serialPortCOMRF.write(comproUI.buffer);
        }

        private void PIDTuningForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<byte> listo = new List<byte>();
            listo.Add(0);
            comproUI.message = listo.ToArray();
            comproUI.msg_size = (byte)comproUI.message.Length;
            comproUI.source_msg_id = 20;
            comproUI.msg_index++;
            comproUI.CreateBuffer();
            Anasayfa.mqttobj.client.Publish("interface_to_vehicle", comproUI.buffer);
        }
    }
}
