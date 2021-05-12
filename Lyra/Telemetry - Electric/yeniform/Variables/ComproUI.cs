using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telemetri.Variables
{
    public class ComproUI
    {
        public const byte MCU = 1;
        public const byte VCU = 2;
        public const byte TELEMETRI = 4;
        public const byte BMS = 8;
        public const byte EYS = 16;
        public const byte CHARGER = 32;

        private byte        HEADER1 = 0x14;
        private byte        HEADER2 = 0x04;
        public byte         vehicle_id = 0x31;
        public byte         target_id = 4;
        public byte         source_id = 17;
        public byte         source_msg_id;
        public byte         msg_size;
        public UInt16       msg_index = 0;
        public byte[]       message;
        private UInt16      crc;
        private List<byte> listbuffer = new List<byte>();

        public byte[] buffer = new byte[20];

        private enum step
        {
            CatchHeader1 = 0,
            CatchHeader2 = 1,
            CatchVehicleId = 3,
            CatchTargetId = 4,
            CatchSourceId = 5,
            CatchSourceMsgId = 6,
            CatchMsgSize = 7,
            CatchMsg = 8,
            CatchMsgIndexL = 9,
            CatchMsgIndexH = 10,
            CatchCrcL = 11,
            CatchCrcH = 12,

        }
        private step steppo = step.CatchHeader1;

        public ComproUI()
        {

        }
        public ComproUI(byte _vehicle_id, byte _target_id, byte[] _message, byte _msg_size, byte _source_msg_id)
        {
            vehicle_id = _vehicle_id;
            target_id = _target_id;
            msg_size = _msg_size;
            source_msg_id = _source_msg_id;
            message = _message;
        }

        public void CreateBuffer()
        {
            listbuffer.Add(HEADER1);
            listbuffer.Add(HEADER2);
            listbuffer.Add(vehicle_id);
            listbuffer.Add(target_id);
            listbuffer.Add(source_id);
            listbuffer.Add(source_msg_id);
            listbuffer.Add(msg_size);
            listbuffer.AddRange(message);
            ushort CRC = MACROS.AeskCRCCalculate(listbuffer.ToArray(), (uint)(7 + msg_size));
            byte[] CRCLH = BitConverter.GetBytes(CRC);
            byte[] MSGLH = BitConverter.GetBytes(msg_index);
            listbuffer.AddRange(MSGLH);
            listbuffer.AddRange(CRCLH);
            buffer = listbuffer.ToArray();
        }

        public void ComproUnpack(byte[] received_data)
        {
            List<byte> worked_data = new List<byte>();

            for (int i = 0; i < received_data.Length; i++)
            {
                switch (steppo)
                {
                    case step.CatchHeader1:
                        {
                            if (received_data[i] == this.HEADER1)
                            {
                                worked_data.Add(received_data[i]);
                                steppo = step.CatchHeader2;
                            }
                            else
                            {
                                steppo = step.CatchHeader1;
                            }
                        }
                        break;
                    case step.CatchHeader2:
                        {
                            if (received_data[i] == this.HEADER2)
                            {
                                worked_data.Add(received_data[i]);
                                steppo = step.CatchVehicleId;
                            }
                            else
                            {
                                steppo = step.CatchHeader1;
                            }
                        }
                        break;
                    case step.CatchVehicleId:
                        {
                            if (received_data[i] == this.vehicle_id)
                            {
                                worked_data.Add(received_data[i]);
                                steppo = step.CatchTargetId;
                            }
                            else
                            {
                                steppo = step.CatchHeader1;
                            }
                        }
                        break;
                    case step.CatchTargetId:
                        {
                            this.target_id = received_data[i];
                            worked_data.Add(received_data[i]);
                            steppo = step.CatchSourceId;
                        }
                        break;
                    case step.CatchSourceId:
                        {
                            worked_data.Add(received_data[i]);
                            this.source_id = received_data[i];
                            steppo = step.CatchSourceMsgId;
                        }
                        break;
                    case step.CatchSourceMsgId:
                        {
                            worked_data.Add(received_data[i]);
                            this.source_msg_id = received_data[i];
                            steppo = step.CatchMsgSize;
                        }
                        break;
                    case step.CatchMsgSize:
                        {
                            worked_data.Add(received_data[i]);
                            this.msg_size = received_data[i];
                            steppo = step.CatchMsg;
                            this.message = new byte[this.msg_size];
                        }
                        break;
                    case step.CatchMsg:
                        {
                            worked_data.Add(received_data[i]);
                            this.message[msg_index++] = received_data[i];
                            if (msg_index >= this.msg_size)
                            {
                                steppo = step.CatchMsgIndexL;
                                msg_index = 0;
                            }
                        }
                        break;
                    case step.CatchMsgIndexL:
                        {
                            worked_data.Add(received_data[i]);
                            this.msg_index = received_data[i];
                            steppo = step.CatchMsgIndexH;
                        }
                        break;
                    case step.CatchMsgIndexH:
                        {
                            worked_data.Add(received_data[i]);
                            this.msg_index = (byte)(this.msg_index | (received_data[i] << 8));
                            steppo = step.CatchCrcL;
                        }

                        break;
                    case step.CatchCrcL:
                        {
                            this.crc = received_data[i];
                            steppo = step.CatchCrcH;
                        }
                        break;
                    case step.CatchCrcH:
                        {
                            this.crc = (ushort)(this.crc | (received_data[i] << 8));
                            UInt16 crc_calculated = MACROS.AeskCRCCalculate(worked_data.ToArray(), (uint)worked_data.Count - 2);
                            if (crc_calculated == this.crc)
                            {
                                dataConvertCompro(worked_data.ToArray());
                            }
                            steppo = step.CatchHeader1;

                        }
                        break;
                    default:
                        break;
                }
            }
        }
        void dataConvertCompro(byte[] receiveBuffer)
        {
            int startIndex = 7;
            float kp;
            float kd;
            float ki;
            kp = BitConverter.ToSingle(receiveBuffer, startIndex); startIndex += 4;
            kd = BitConverter.ToSingle(receiveBuffer, startIndex); startIndex += 4;
            ki = BitConverter.ToSingle(receiveBuffer, startIndex); startIndex += 4;
            MessageBox.Show("Kp: " + kp.ToString() + "\n" + "Kd: " + kd.ToString() + "\n" + "Ki: " + ki.ToString() + "\n");
        }

    }
}
