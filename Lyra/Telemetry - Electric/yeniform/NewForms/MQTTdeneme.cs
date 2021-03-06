﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.Variables;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Telemetri.NewForms
{
    public partial class MQTTdeneme : Form
    {
        public MQTTdeneme()
        {
            InitializeComponent();
        }

        static MqttClient Client;
        bool connectedFlag = false;
        byte wakeupc;
        byte drivecom;
        byte setvelo;

        private void MQTTdeneme_Load(object sender, EventArgs e)
        {
            Client = new MqttClient("test.mosquitto.org");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            byte code = Client.Connect(Guid.NewGuid().ToString(), MACROS.MQTT_username, MACROS.MQTT_password);
            if (code == 0x00)
            {
                //Connected
                connectedFlag = true;
                panel2.BackColor = Color.LimeGreen;
                Client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                try
                {
                    Client.Subscribe(new string[] { "vehicle_to_interface" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                }
                catch (Exception ed)
                {
                    MessageBox.Show(ed.Message);
                }
            }
            else
            {
                panel2.BackColor = Color.DarkRed;
            }
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //MESAJ GELDİ HOCAM
            //GELEN MESAJ 3 BYTE
            wakeupc = Convert.ToByte(e.Message[0]);
            drivecom = Convert.ToByte(e.Message[1]);
            setvelo = Convert.ToByte(e.Message[2]);

            wakeupLabel.Text = wakeupc.ToString();
            drivecomLabel.Text = drivecom.ToString();
            setveloLabel.Text = setvelo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(connectedFlag == true)
            {
                try
                {
                    Client.Publish("interface_to_vehicle", new byte[] { 172 }, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, false);
                }
                catch (Exception ert)
                {
                    MessageBox.Show(ert.Message);
                    throw;
                }
            }
        }
    }
}
