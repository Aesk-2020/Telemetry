using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.NewForms;

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
        public const byte UI = 64;

        private byte HEADER1 = MACROS.SYNC1;
        private byte HEADER2 = MACROS.SYNC2;
        public byte vehicle_id = MACROS.VEHICLE_ID;
        public byte target_id = TELEMETRI;
        public byte source_id = UI;
        public byte source_msg_id;
        public byte msg_size;
        public ushort msg_index = 0;
        public byte[] message;
        private ushort crc;
        private List<byte> listbuffer = new List<byte>();

        public byte[] buffer = new byte[200];

        public enum MSG_ID
        {
            WAKEUP_COMMANDS = 0,
            VELOCITY = 1,
            MCU_ID_IQ_VD_VQ = 2,
            MCU_STATE_AREA = 3,
            BMS_MEASUREMENTS = 4,
            BMS_STATE_DATA = 5,
            EMS_CURRENT = 6,
            EMS_VOLTAGE = 7,
            EMS_CONSUMPTION = 8,
            EMS_STATE_DATA = 9,
            BMS_CELLS_1 = 10,
            BMS_CELLS_2 = 11,
            BMS_CELLS_3 = 12,
            BMS_CELLS_4 = 13,
            BMS_SOC_1 = 14,
            BMS_SOC_2 = 15,
            BMS_SOC_3 = 16,
            BMS_SOC_4 = 17,
            BMS_TO_CHARGER = 18,
            BMS_SOH = 19,
            PID_TUNNING = 20,
            PID_QUERY = 21,
            PID_QUERY_ANSWER = 22,
            RESET_TELEMETRY = 23,
            UI_PACK = 24,
            COMM_QUERY = 25,
            MSG_ID_COUNT = 26,
        }

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
        public ComproUI(byte _vehicle_id, byte _target_id, byte _source_msg_id)
        {
            vehicle_id = _vehicle_id;
            target_id = _target_id;
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
            listbuffer.Clear();
        }

        public void ComproUnpack(byte[] received_data)
        {
            List<byte> worked_data = new List<byte>();
            ushort incom_index = 0;

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
                            try
                            {
                                this.message[msg_index++] = received_data[i];
                                if (msg_index >= this.msg_size)
                                {
                                    steppo = step.CatchMsgIndexL;
                                    msg_index = 0;
                                }
                            }
                            catch (Exception)
                            {
                                
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
                            incom_index = (byte)(this.msg_index | (received_data[i] << 8));
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
                                dataConvertCompro(worked_data.ToArray(), this.source_msg_id);
                                AFront.ChangeUI();
                                //BURAYA İNDEX EKLENECEK
                                /*if(IndexControl(incom_index) == true)
                                {
                                    
                                }
                                else
                                {
                                    //HABERLEŞME HATALARINI DOLDUR BURAYA
                                }*/
                            }
                            steppo = step.CatchHeader1;

                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private bool IndexControl(ushort incoming_index)
        {
            var difference = incoming_index - this.msg_index; // Gelen index bilgisiyle elimizdekinin farkı alınır.
            /*
             * Bu fark 0 ile -10 arasındaysa gelen mesaj daha önce elimize ulaşmış bir mesajdır.
             * Çünkü mesaj gönderilirken aynı kod bloğunda (scope) gönderilmektedir. Bu durumda mesajı
             * çözmemizin bir anlamı yoktur, çünkü bu mesaj elimize önceden ulaşmıştır ve eski bir bilgiyi
             * taşımaktadır.
             */
            if (difference <= 0 && difference >= -10)
            {
                return false;
            }

            /*
             * Eğer fark -10'dan küçükse bilgi kaynağı reset yemiş kabul edilir. 0'dan büyükse de gelen indeks
             * daha yeni bir indeks olacağından paketin çözülmesi gerekir. Bu aşamada nesneye ait indeks
             * bilgisi de güncellenir.
             */
            else
            {
                this.msg_index = incoming_index;
                return true;
            }
        }

        void dataConvertCompro(byte[] receiveBuffer, byte source_msg_id)
        {
            
            switch ((MSG_ID)source_msg_id)
            {
                case MSG_ID.UI_PACK:
                    {
                        //VCU
                        int startIndex = 7;
                        DataVCU.drive_commands_u8       = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        DataVCU.speed_set_rpm_s16       = (short)Math.Round(BitConverter.ToInt16(receiveBuffer, startIndex) * 0.105183); startIndex += 2;
                        DataVCU.torque_set_s16          = BitConverter.ToInt16(receiveBuffer, startIndex); startIndex += 2;
                        DataVCU.speed_limit_u16         = BitConverter.ToUInt16(receiveBuffer, startIndex); startIndex += 2;
                        DataVCU.torque_limit_u8         = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

                        //MCU
                        DataMCU.act_id_current_s16      = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.act_iq_current_s16      = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.vd_s16                  = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.vq_s16                  = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.set_id_current_s16      = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.set_iq_current_s16      = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.set_torque_s16          = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.i_dc_s16                = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.v_dc_s16                = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataMCU.act_speed_s16           = (short)Math.Round(BitConverter.ToInt16(receiveBuffer, startIndex) * 0.105183 / 10); startIndex += 2;
                        DataMCU.temperature_u8          = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        DataMCU.error_status_u16        = BitConverter.ToUInt16(receiveBuffer, startIndex); startIndex += 2;
                        DataMCU.act_torque_s8           = (sbyte)receiveBuffer[startIndex++]; DataMCU.act_torque_s8 -= 100;

                        //BMS
                        DataBMS.volt_u16                = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataBMS.cur_s16                 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataBMS.cons_u16                = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 10; startIndex += 2;
                        DataBMS.soc_u16                 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        DataBMS.worst_cell_volt_u16     = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 10; startIndex += 2;
                        DataBMS.error_u8                = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        DataBMS.dc_bus_state_u8         = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        DataBMS.worst_cell_address_u8   = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        DataBMS.temperature_u8          = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

                        //GPS
                        DataGPS.latitude_f32            = BitConverter.ToUInt32(receiveBuffer, startIndex) / MACROS.GPS_DIVIDER; startIndex += 4;
                        DataGPS.longtitude_f32          = BitConverter.ToUInt32(receiveBuffer, startIndex) / MACROS.GPS_DIVIDER; startIndex += 4;
                        DataGPS.speed_u8                = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        DataGPS.sattelite_u8            = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        DataGPS.efficiency_u8           = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        /*
                        //CAN Error
                        DataVCU.can_error_u8            = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

                        //Cells
                        for (int i = 0; i < 28; i++)
                        {
                            DataBMS.Cell cell = new DataBMS.Cell();
                            cell.voltage_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                            DataBMS.cells.Add(cell);
                        }
                        List<char> temps = new List<char>();
                        int count = 0;
                        for (int i = 0; i < 7; i++) // Total temperature sensor count. 
                        {
                            temps.Add(BitConverter.ToChar(receiveBuffer, startIndex)); startIndex++;
                        }
                        for (int i = 0; i < 28; i++) 
                        {
                            DataBMS.cells[i].temperature_u8 = (byte)temps[count++];
                            if(count == 4)
                            {
                                count = 0;
                            }
                        }
                        for (int i = 0; i < 28; i++)
                        {
                            DataBMS.cells[i].soc_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                        }
                        */
                        break;
                    }
                case MSG_ID.PID_QUERY_ANSWER:
                    {
                        int startIndex = 7;
                        float kp;
                        float kd;
                        float ki;
                        float kr;
                        kp = BitConverter.ToSingle(receiveBuffer, startIndex); startIndex += 4;
                        ki = BitConverter.ToSingle(receiveBuffer, startIndex); startIndex += 4;
                        kd = BitConverter.ToSingle(receiveBuffer, startIndex); startIndex += 4;
                        kr = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
                        MessageBox.Show("Kp: " + kp.ToString() + "\n" + "Ki: " + ki.ToString() + "\n" + "Kd: " + kd.ToString() + "\n" + "Kr:" + kr.ToString() + "\n");
                        DataVCU.kp = kp;
                        DataVCU.ki = ki;
                        DataVCU.kd = kd;
                        DataVCU.kr = kr;
                        break;
                    }
                default:
                    {
                        UITools.PIDForm.logWriter.WriteLine("HATALI PAKET");
                    }
                    break;
            }

        }

    }
}
