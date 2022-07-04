using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using Telemetri.NewForms;

namespace Telemetri.Variables
{
    public class SerialRF
    {
        private SerialPort _serialPort;
        private int _packLength;
        private int BALONSAYACSIL = 0;
        private int BALONSAYACSIL2 = 0;
        private uint _dataCounter;
        private byte[] _recieveData = new byte[255];
        private ushort crcCalculated, crcIncoming;
        public byte SyncChar { get; set; }

        private enum ReceiveDataStates
        {
            CatchHeader = 0,
            MsgIdCheck = 1,
            MsgSizeCheck = 2,
            AddBuffer = 3,
            CrcLCheck = 4,
            CrcHCheck = 5,

        }
        private ReceiveDataStates _state = ReceiveDataStates.CatchHeader;

        public bool Connect(string portName, int baudRate)
        {
            _serialPort = new SerialPort(portName, baudRate);
            _serialPort.DataReceived += _serialPort_DataReceived;
            try
            {
                _serialPort.Open();
                AFront.ThreadStart();
                UITools.Telemetry2021.activeChannelLabel.Text = "RF";
                UITools.PIDForm.queryButton.Enabled = true;
                UITools.PIDForm.sendButton.Enabled = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Disconnect()
        {
            _serialPort.DataReceived -= _serialPort_DataReceived;
            _serialPort.Close();
            AFront.ThreadStop();
        }
        public void SendData(List<byte> buffer, int length, byte msgId)
        {
            byte mehceAglamasiLength = (byte)buffer.Count(); //Değişkene saçma bi isim koyacaktım mehçe ağladığı için ona atıfta bulundum.
            buffer.Insert(0, 0xAB);
            buffer.Insert(1, msgId);
            buffer.Insert(2, mehceAglamasiLength);
            if (_serialPort != null)
            {
                _serialPort.Write(buffer.ToArray(), 0, length);
            }
        }
        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytes = 0;
                byte[] buffer = new byte[200];
                int all = 0, atleast = 0;
                while (all <= 6)
                {
                    if (_serialPort.IsOpen)
                        bytes = _serialPort.BytesToRead;
                    if (bytes > 0)
                        _serialPort.Read(buffer, all, bytes);
                    all += bytes;
                }
                if (buffer[5] == 27)
                {
                    atleast = 44;
                }
                else if (buffer[5] == 28)
                {
                    atleast = 28;
                }
                else if (buffer[5] == 29)
                {
                    atleast = 60;
                }
                while (all < atleast)
                {
                    bytes = _serialPort.BytesToRead;
                    if (bytes > 0)
                        _serialPort.Read(buffer, all, bytes);
                    all += bytes;
                }
                byte[] buf2 = new byte[atleast];
                for (int i = 0; i < atleast; i++)
                {
                    buf2[i] = buffer[i];
                }
                if (all > 0)
                {
                    if (Anasayfa.mqttobj.client != null)
                    {
                        Anasayfa.mqttobj.client.Publish("vehicle_to_interface", buf2);
                    }
                    else
                    {
                        ComproUI pack = new ComproUI();
                        UITools.TestForms.vtico++;
                        UITools.TestForms.cozulduvtiBox.Text = UITools.TestForms.vtico.ToString();
                        pack.ComproUnpack(buf2);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
