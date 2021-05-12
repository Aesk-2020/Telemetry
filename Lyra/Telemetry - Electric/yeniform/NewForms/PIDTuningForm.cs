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
            comproUI.message = Encoding.UTF8.GetBytes(textBox1.Text);
            comproUI.msg_size = (byte)textBox1.Text.Length;
            comproUI.source_msg_id = 5;
            comproUI.vehicle_id = 0x31;
            comproUI.source_msg_id = 1;
            comproUI.CreateBuffer();
            //Anasayfa.mqttobj.client.Publish("interface_to_vehicle", comproUI.buffer);
            Anasayfa.serialPortCOMRF.write(comproUI.buffer);
        }
    }
}
