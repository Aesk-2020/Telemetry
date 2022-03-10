using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telemetri.Variables
{
    class BmsUI
    {
        public ushort[] cells_voltage = new UInt16[28];
        public ushort[] cells_temprature = new UInt16[28];
        public PictureBox[] imgArray = new PictureBox[28];
        public CheckBox[] checkboxArray = new CheckBox[28];
        public Label[] voltageLabelsArray = new Label[28];
        public Label[] tempLabelsArray = new Label[28];
        public byte[] captured_data = new byte[60];

        public ushort gelen_crc { get; set; }
        public int data_type { get; set; }
        public int message_length { get; set; }

        public int ExtractType(byte data)
        {
            return data >> 6;
        }
        public int ExtractMessageLength(byte data)
        {
            return data & 0b00111111;
        }
        public ushort ExtractCRC(ushort data1, ushort data2)
        {
            return (Convert.ToUInt16((data1 << 8) | (data2)));
        }
       
        public ushort aeskCRCCalculate(byte[] frame, uint framesize)
        {
            ushort crc16_data = 0;
            byte data = 0;
            for (byte mlen = 0; mlen < framesize; mlen++)
            {
                data = Convert.ToByte(((byte)frame[mlen] ^ Convert.ToByte(((crc16_data) & (0xFF)))));
                Console.WriteLine(data);
                data = (byte)((byte)data ^ (byte)(data << 4));
                crc16_data = (ushort)((((ushort)data << 8) | ((crc16_data & 0xFF00) >> 8)) ^ (byte)(data >> 4) ^ ((ushort)data << 3));
            }
            return (crc16_data);
        }

    }
}
