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

        public byte         HEADER1 = 0x14;
        public byte         HEADER2 = 0x04;
        public byte         vehicle_id = 0x31;
        public byte         target_id = 4;
        public byte         source_id = 17;
        public byte         source_msg_id;
        public byte         msg_size;
        public UInt16       msg_index = 0;
        public byte[]       message;
        public UInt16       crc;
        private List<byte> listbuffer = new List<byte>();

        public byte[] buffer = new byte[20];


        public ComproUI()
        {

        }
        public ComproUI(byte _vehicle_id, byte _target_id, byte _source_id, byte _msg_size, byte _source_msg_id, UInt16 _msg_index)
        {
            vehicle_id = _vehicle_id;
            target_id = _target_id;
            source_id = _source_id;
            msg_size = _msg_size;
            source_msg_id = _source_msg_id;
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
    }
}
