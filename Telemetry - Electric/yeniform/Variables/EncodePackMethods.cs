using System;
using UINT8 = System.Byte;
using INT8 = System.Byte;
namespace yeniform.Variables
{
    
    static class EncodePackMethods
    {
        
        public static UINT8 DataConverterU8(byte[] receiveBuffer, ref int startIndex)
        {
            UINT8 data;
            data = (UINT8)BitConverter.ToChar(receiveBuffer, startIndex);
            startIndex = startIndex + sizeof(UINT8);
            return data;
        }

        public static INT8 DataConverterS8(byte[] receiveBuffer, ref int startIndex)
        {
            INT8 data;
            data = (INT8)BitConverter.ToChar(receiveBuffer, startIndex);
            startIndex = startIndex + sizeof(INT8);
            return data;
        }

        public static UInt16 DataConverterU16(byte[] receiveBuffer, ref int startIndex)
        {
            UInt16 data;
            data = BitConverter.ToUInt16(receiveBuffer, startIndex);
            startIndex = startIndex + sizeof(UInt16);
            return data;
        }

        public static Int16 DataConverterS16(byte[] receiveBuffer, ref int startIndex)
        {
            Int16 data;
            data = BitConverter.ToInt16(receiveBuffer, startIndex);
            startIndex = startIndex + sizeof(Int16);
            return data;
        }

        public static UInt32 DataConverterU32(byte[] receiveBuffer, ref int startIndex)
        {
            UInt32 data;
            data = BitConverter.ToUInt32(receiveBuffer, startIndex);
            startIndex = startIndex + sizeof(UInt32);
            return data;
        }

        public static Int32 DataConverterS32(byte[] receiveBuffer, ref int startIndex)
        {
            Int32 data;
            data = BitConverter.ToInt32(receiveBuffer, startIndex);
            startIndex = startIndex + sizeof(Int32);
            return data;
        }
    }
}
