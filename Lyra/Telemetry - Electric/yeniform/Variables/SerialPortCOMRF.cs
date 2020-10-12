using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace yeniform.Variables
{
    public delegate void LogRFDelegate();
    public class SerialPortCOMRF
    {
        public event LogRFDelegate LogRFEvent;
        private enum receiveDataStates
        {
            CatchHeader = 0,
            AddBuffer = 1
        }
        public string portname;
        public SerialPort _serialPort;
        public uint _receiveDataBufferLength;
        public byte _Header;
        public UInt32 GL_gelen_bayt_u32;
        public UInt32 GL_baslik_hatali_u32;
        public UInt32 GL_cozulen_paket_u32;
        public UInt32 GL_crc_hatali_u32;
        public float GL_rf_efficiency_f32;
        private receiveDataStates state = receiveDataStates.CatchHeader;
        public int data_counter = 0;
        byte[] receiveDataBuffer;


        public SerialPortCOMRF(uint receiveDataBufferLength, byte Header)
        {
            _receiveDataBufferLength = receiveDataBufferLength;
            _Header = Header;
            receiveDataBuffer = new byte[_receiveDataBufferLength];
        }

        public void SerialPortInit(SerialPort serialPort)
        {
            _serialPort = serialPort;
        }

        public SerialPortCOMRF()
        {
          
        }

        public void ConnectSerialPort(string PortName)
        {
            try
            {
                if (_serialPort.IsOpen == false)
                {
                    _serialPort.PortName = PortName;
                    _serialPort.BaudRate = 9600;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    _serialPort.Open();
                }
                else
                {
                    _serialPort.Close();
                }
            }

            catch
            {
                MessageBox.Show("Bağlantı açılamadı!");
            }
        }

        public void DisconnectSerialPort(string PortName)
        {
            _serialPort.Close();
            _serialPort.DataReceived -= new SerialDataReceivedEventHandler(sp_DataReceived);
        }

        private void dataConvert(byte[] receiveBuffer)
        {
            int startIndex = 1;
            VCU.wake_up_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            VCU.set_velocity_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            Driver.phase_a_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.phase_b_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.dc_bus_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.dc_bus_voltage_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            Driver.id_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.iq_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.IArms_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.Torque_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            Driver.drive_status_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            Driver.driver_error_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            Driver.odometer_u32 = EncodePackMethods.DataConverterU32(receiveBuffer, ref startIndex);
            Driver.motor_temperature_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            Driver.actual_velocity_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.bat_volt_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            BMS.bat_current_f32 = (float)EncodePackMethods.DataConverterS16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            BMS.bat_cons_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            BMS.soc_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_2;
            BMS.bms_error_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.dc_bus_state_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.worst_cell_voltage_f32 = (float)EncodePackMethods.DataConverterU16(receiveBuffer, ref startIndex) / MACROS.FLOAT_CONVERTER_1;
            BMS.worst_cell_address_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            BMS.temp_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            if (!MACROS.mouse_mod)
            {
                GpsTracker.gps_latitude_f64 = (double)EncodePackMethods.DataConverterU32(receiveBuffer, ref startIndex) / MACROS.GPS_DIVIDER;
                GpsTracker.gps_longtitude_f64 = (double)EncodePackMethods.DataConverterU32(receiveBuffer, ref startIndex) / MACROS.GPS_DIVIDER;
            }

            else
            {
                startIndex += 8;
            }
            GpsTracker.gps_velocity_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            GpsTracker.gps_sattelite_number_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            GpsTracker.gps_efficiency_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            VCU.can_error_u8 = EncodePackMethods.DataConverterU8(receiveBuffer, ref startIndex);
            LogRFEvent();
        }

        private ushort aeskCRCCalculate(byte[] frame, uint framesize)
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

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = _serialPort.BytesToRead;
            byte[] buffer = new byte[bytes];
            _serialPort.Read(buffer, 0, bytes);
            GL_gelen_bayt_u32 += (UInt32)bytes;
            for (int i = 0; i < bytes; i++)
            {
                switch (state)
                {
                    case receiveDataStates.CatchHeader:
                        {
                            if (buffer[i] == _Header)
                            {

                                state = receiveDataStates.AddBuffer;
                                receiveDataBuffer[data_counter++] = buffer[i];
                            }
                            else
                            { 
                                GL_baslik_hatali_u32++;
                                state = receiveDataStates.CatchHeader;
                            }
                            break;
                        }
                    case receiveDataStates.AddBuffer:
                        {
                            receiveDataBuffer[data_counter++] = buffer[i];
                            if (data_counter >= _receiveDataBufferLength)
                            {
                                int index = 0;
                                byte[] crcBuffer = new byte[2] {receiveDataBuffer[_receiveDataBufferLength - 2], receiveDataBuffer[_receiveDataBufferLength - 1]};
                                int calculate_crc = EncodePackMethods.DataConverterU16(crcBuffer, ref index);
                                ushort buffer_crc = aeskCRCCalculate(receiveDataBuffer, _receiveDataBufferLength - 2);
                                data_counter = 0;
                                if (calculate_crc == buffer_crc)
                                {
                                    GL_cozulen_paket_u32++;
                                    dataConvert(receiveDataBuffer);
                                }

                                else
                                {
                                    GL_crc_hatali_u32++;
                                }
                                GL_rf_efficiency_f32 = ((float)(GL_cozulen_paket_u32 * _receiveDataBufferLength) / (GL_gelen_bayt_u32));
                                state = receiveDataStates.CatchHeader;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        public void write(byte[] buffer)
        {
            _serialPort.Write(buffer, 0, buffer.Length);
        }
    }
}
