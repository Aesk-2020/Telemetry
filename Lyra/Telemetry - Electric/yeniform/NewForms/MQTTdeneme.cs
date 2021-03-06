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
    public partial class MQTTdeneme : Form
    {
        public MQTTdeneme()
        {
            InitializeComponent();
        }

        MQTT mqtt = new MQTT(MACROS.MQTT_username, MACROS.MQTT_password, MACROS.MQTT_topic);
        bool connectedFlag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            byte code = mqtt.ConnectRequestMQTT();
            if (code == 0x00)
            {
                //Connected
                connectedFlag = true;
            }
            else
            {
                
            }
        }
    }
}
