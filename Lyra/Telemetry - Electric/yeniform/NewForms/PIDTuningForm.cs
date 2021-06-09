﻿using System;
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
        ComproUI comproUI;
        ComproUI comproUII;

        public PIDTuningForm()
        {
            InitializeComponent();
            UITools.PIDForm.sendButton = sendButton;
            UITools.PIDForm.queryButton = queryButton;
            UITools.PIDForm.logBox = logBox;
            UITools.PIDForm.logWriter = new ConsoleTextBoxWriter(logBox);
            comproUI = new ComproUI(0x31, ComproUI.VCU | ComproUI.TELEMETRI, 19); //, newlist.ToArray(), (byte)newlist.Count, 19);
            comproUII = new ComproUI(0x31, ComproUI.VCU | ComproUI.TELEMETRI, 20);
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
        private void PIDTuningForm_Load(object sender, EventArgs e)
        {
            #region doubleBuffer
            SetDoubleBuffered(tableLayoutPanel1);
            #endregion
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
            
            DataVCU.kp = float.Parse(kpBox.Text);
            DataVCU.ki = float.Parse(kiBox.Text);
            DataVCU.kd = float.Parse(kdBox.Text);
            List<byte> newlist = new List<byte>();
            newlist.AddRange(BitConverter.GetBytes(DataVCU.kp));
            newlist.AddRange(BitConverter.GetBytes(DataVCU.ki));
            newlist.AddRange(BitConverter.GetBytes(DataVCU.kd));
            comproUI.message = newlist.ToArray();
            comproUI.msg_size = (byte)newlist.Count;
            comproUI.msg_index++;
            comproUI.CreateBuffer();
            Anasayfa.mqttobj.client.Publish("interface_to_vehicle", comproUI.buffer);
            UITools.PIDForm.logWriter.WriteLine("PID sent");

        }

        private void queryButton_Click(object sender, EventArgs e)
        {
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
