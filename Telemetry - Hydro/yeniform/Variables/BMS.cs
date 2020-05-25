using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace telemetry_hydro.Variables
{
    public class BMS
    {

        public static float bat_volt_f32; // bu graphda olacak
        public static float bat_current_f32; // bu da olacak
        public static float power_emitted => (bat_volt_f32 * bat_current_f32);
        // bi de bunlarin carpimlari
        
        public static float bat_cons_f32;
        public static float soc_f32;
        public static byte bms_error_u8;
        public static byte dc_bus_state_u8;
        public static float worst_cell_voltage_f32;
        public static byte worst_cell_address_u8;
        public static byte temp_u8;

        public static bool precharge_flag_u1 => Convert.ToBoolean(dc_bus_state_u8 & 0b00000001);
        public static bool discharge_flag_u1 => Convert.ToBoolean(dc_bus_state_u8 >> 1 & 0b00000001);
        public static bool dc_bus_ready_flag_u1 => Convert.ToBoolean(dc_bus_state_u8 >> 2 & 0b00000001);

        public static bool high_voltage_error_u1 => Convert.ToBoolean((bms_error_u8 & 0b00000001));
        public static bool low_voltage_u1 => Convert.ToBoolean((bms_error_u8 >> 1 & 0b00000001));
        public static bool bms_temp_error_u1 => Convert.ToBoolean((bms_error_u8 >> 2 & 0b00000001));
        public static bool comm_error_u1 => Convert.ToBoolean((bms_error_u8 >> 3 & 0b00000001));
        public static bool over_current_error_u1 => Convert.ToBoolean((bms_error_u8 >> 4 & 0b00000001));
        public static bool bms_fatal_error_u1 => Convert.ToBoolean((bms_error_u8 >> 5 & 0b00000001));

        public static string log_datas_bms => bat_volt_f32.ToString() + '$' + bat_current_f32.ToString() + '$' + bat_cons_f32.ToString()
                                              + '$' + soc_f32.ToString() + '$' + bms_error_u8.ToString() + '$' + dc_bus_state_u8.ToString()
                                              + '$' + worst_cell_voltage_f32.ToString() + '$' + worst_cell_address_u8.ToString()
                                              + '$' + temp_u8.ToString() + '$';
    
        private enum receiveDataStates
        {
            CatchHeader = 0,
            AddBuffer = 1
        }
        private SerialPort _serialPort;
        private uint _receiveDataBufferLength;
        private byte _Header;
        private receiveDataStates state = receiveDataStates.CatchHeader;
        private int data_counter = 0;
        private byte[] receiveDataBuffer;


        public BMS(SerialPort serialPort, uint receiveDataBufferLength, byte Header)
        {
            _serialPort = serialPort;
            _receiveDataBufferLength = receiveDataBufferLength;
            _Header = Header;
            receiveDataBuffer = new byte[_receiveDataBufferLength];
        }

        public BMS()
        {

        }



        public void ConnectSerialBMSPort(string PortName)
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

        public void DisconnectBMSSerialPort(string PortName)
        {
            _serialPort.Close();
            _serialPort.DataReceived -= new SerialDataReceivedEventHandler(sp_DataReceived);
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

        private void dataConvertBMS(byte[] receiveBuf)
        {



        }
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = _serialPort.BytesToRead;
            byte[] buffer = new byte[bytes];
            _serialPort.Read(buffer, 0, bytes);
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
                       
                                state = receiveDataStates.CatchHeader;
                            }
                            break;
                        }
                    case receiveDataStates.AddBuffer:
                        {
                            receiveDataBuffer[data_counter++] = buffer[i];
                            if (data_counter >= _receiveDataBufferLength)
                            {
                                int calculate_crc = (receiveDataBuffer[_receiveDataBufferLength - 2] << 8) | receiveDataBuffer[_receiveDataBufferLength - 1];
                                ushort buffer_crc = aeskCRCCalculate(receiveDataBuffer, _receiveDataBufferLength - 1);
                                data_counter = 0;
                                if (calculate_crc == buffer_crc)
                                {  
                                    dataConvertBMS(receiveDataBuffer);
                                }
                                state = receiveDataStates.CatchHeader;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }

        }
    }
}
