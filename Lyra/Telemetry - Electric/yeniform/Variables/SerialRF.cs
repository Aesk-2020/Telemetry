using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

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

        public void Connect(string portName, int baudRate, int packLength)
        {
            _serialPort = new SerialPort(portName, baudRate);
            _packLength = packLength;
            _serialPort.DataReceived += _serialPort_DataReceived;
            try
            {
                _serialPort.Open();
                UITools.PIDForm.queryButton.Enabled = true;
                UITools.PIDForm.sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Connect(string portName, int baudRate)
        {
            _serialPort = new SerialPort(portName, baudRate);
            _serialPort.DataReceived += _serialPort_DataReceived;
            try
            {
                _serialPort.Open();
                UITools.Telemetry2021.activeChannelLabel.Text = "RF";
                UITools.PIDForm.queryButton.Enabled = true;
                UITools.PIDForm.sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Disconnect()
        {
            _serialPort.DataReceived -= _serialPort_DataReceived;
            _serialPort.Close();
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
        public void SendData(List<byte> buffer, int length)
        {
            buffer.Insert(0, 0xAB);
            if(_serialPort.IsOpen)
            {
                _serialPort.Write(buffer.ToArray(), 0, length);
            }
        }
        public void SendData(byte[] buffer, int length)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Write(buffer.ToArray(), 0, length);
            }
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = _serialPort.BytesToRead;
            byte[] buffer = new byte[bytes];
            _serialPort.Read(buffer, 0, bytes);
            for (int i = 0; i < bytes; i++)
            {
                switch (_state)
                {
                    case ReceiveDataStates.CatchHeader:
                        if(buffer[i] == SyncChar)
                        {
                            _state = ReceiveDataStates.MsgIdCheck;
                            _recieveData[_dataCounter++] = buffer[i];
                        }
                        else
                        {
                            //sync char error
                        }
                        break;
                    case ReceiveDataStates.MsgIdCheck:
                        _recieveData[_dataCounter++] = buffer[i];
                        switch (buffer[i])
                        {
                            case (byte)ComproUI.MSG_ID.PID_QUERY_ANSWER:

                                break;
                            case (byte)ComproUI.MSG_ID.UI_PACK:
                                
                                break;
                            default:
                                break;
                        }
                        _state = ReceiveDataStates.MsgSizeCheck;
                        break;
                    case ReceiveDataStates.MsgSizeCheck:
                        _recieveData[_dataCounter++] = buffer[i];
                        _packLength = buffer[i];
                        _state = ReceiveDataStates.AddBuffer;
                        break;
                    case ReceiveDataStates.AddBuffer:
                        _recieveData[_dataCounter++] = buffer[i];
                        if(_dataCounter == _packLength + 1)
                        {
                            _state = ReceiveDataStates.CrcLCheck;
                        }
                        break;
                    case ReceiveDataStates.CrcLCheck:
                        {
                            crcCalculated = MACROS.AeskCRCCalculate(_recieveData, _dataCounter);
                            _recieveData[_dataCounter++] = buffer[i];
                            _state = ReceiveDataStates.CrcHCheck;
                        }
                        break;
                    case ReceiveDataStates.CrcHCheck:
                        {
                            _recieveData[_dataCounter++] = buffer[i];
                            crcIncoming = BitConverter.ToUInt16(_recieveData, (int)_dataCounter - 2);
                            if(crcIncoming == crcCalculated)
                            {
                                BALONSAYACSIL++;
                                UITools.Anasayfa.actVelocityLabel.Text = BALONSAYACSIL.ToString();
                                //pack solved
                                //convert the data
                            }
                            else
                            {
                                BALONSAYACSIL2++;
                                UITools.Anasayfa.setVelocityLabel.Text = BALONSAYACSIL2.ToString();
                            }
                            _dataCounter = 0;
                            _state = ReceiveDataStates.CatchHeader;
                        }    
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
