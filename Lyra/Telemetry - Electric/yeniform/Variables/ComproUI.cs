using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private const byte  HEADER1 = 0x14;
        private const byte  HEADER2 = 0x04;
        public byte         vehicle_id;
        public byte         target_id = 4;
        private byte        source_id = 17;
        public byte         source_msg_id;
        public byte         msg_size;
        public UInt16       msg_index = 0;
        private byte        msg_index_l;
        private byte        msg_index_h;
        public byte[]       message;
        private byte         CRC_L;
        private byte         CRC_H;

        public byte[] buffer = new byte[20];


        public ComproUI()
        {

        }
        public ComproUI(byte _vehicle_id, byte _target_id, byte _source_id, byte _msg_size, byte _source_msg_id, byte[] _message, UInt16 _msg_index)
        {
            vehicle_id = _vehicle_id;
            target_id = _target_id;
            source_id = _source_id;
            msg_size = _msg_size;
            message = _message;
            source_msg_id = _source_msg_id;
            byte[] mesajindeks = BitConverter.GetBytes(_msg_index);
            msg_index_l = mesajindeks[0]; msg_index_h = mesajindeks[1];
        }

        public void CreateBuffer()
        {
            int index = 0;
            this.buffer[index++] = HEADER1;
            this.buffer[index++] = HEADER2;
            this.buffer[index++] = vehicle_id;
            this.buffer[index++] = target_id;
            this.buffer[index++] = source_id;
            this.buffer[index++] = source_msg_id;
            this.buffer[index++] = msg_size;
            for (int i = 0; i < msg_size; i++)
            {
                buffer[index + i] = message[i];
            }
            index += msg_size;
            ushort CRC = MACROS.AeskCRCCalculate(buffer, (uint)(7 + msg_size));
            byte[] CRCLH = BitConverter.GetBytes(CRC);

            this.buffer[index++] = msg_index_l;
            this.buffer[index++] = msg_index_h;
            buffer[index++] = CRCLH[0];
            buffer[index] = CRCLH[1];
        }
    }
}
