using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.NewForms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Telemetri.Variables
{
    public class NewMQTT
    {
        private string _username = "aesk";
        private string _password = "1234";
        public string topic;
        public string topic2;
        public string broker;
        public MqttClient client;
        public bool connected_flag = false;
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

        public NewMQTT(string _topic, string _topic2, string _broker)
        {
            topic = _topic;
            topic2 = _topic2;
            broker = _broker;
        }

        public NewMQTT()
        {

        }
        public bool ConnectSubscribe()
        {
            if (connected_flag == false)
            {
                this.client = new MqttClient(this.broker);
                byte code = this.client.Connect(Guid.NewGuid().ToString(), _username, _password);
                if (code == 0x00)
                {
                    try
                    {
                        this.client.Subscribe(new string[] { this.topic, this.topic2 }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                        this.client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                        connected_flag = true;
                        UITools.PIDForm.queryButton.Enabled = true;
                        UITools.PIDForm.sendButton.Enabled = true;
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show(exce.Message);
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show($"Sunucuya bağlanılamadı. Hata kodu: {code}");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Zaten bağlısınız");
                return true;
            }
        }
        public void Disconnect()
        {
            if (connected_flag == true)
            {
                this.client.Disconnect();
                this.client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
                connected_flag = false;
            }
            else
            {
                MessageBox.Show("Zaten bağlı değilsiniz");
            }
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            ComproUI compro = new ComproUI();

            //compro.ComproUnpack(e.Message);
            YedekUnpack(e.Message);
            AFront.ChangeUI();
        }

        public void YedekUnpack(byte[] receiveBuffer)
        {
            int startIndex = 0;
            DataVCU.drive_commands_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataVCU.speed_set_rpm_s16 = BitConverter.ToInt16(receiveBuffer, startIndex); startIndex += 2;
            DataVCU.torque_set_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataVCU.speed_limit_u16 = BitConverter.ToUInt16(receiveBuffer, startIndex); startIndex += 2;
            DataVCU.torque_limit_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            //MCU
            DataMCU.act_id_current_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.act_iq_current_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.vd_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.vq_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.set_id_current_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.set_iq_current_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.set_torque_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.i_dc_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.v_dc_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataMCU.act_speed_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 10; startIndex += 2;
            DataMCU.temperature_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataMCU.error_status_u16 = BitConverter.ToUInt16(receiveBuffer, startIndex); startIndex += 2;
            DataMCU.act_torque_s8 = (sbyte)receiveBuffer[startIndex++]; DataMCU.act_torque_s8 -= 100;

            //BMS
            DataBMS.volt_u16 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataBMS.cur_s16 = (float)BitConverter.ToInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataBMS.cons_u16 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 10; startIndex += 2;
            DataBMS.soc_u16 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 100; startIndex += 2;
            DataBMS.worst_cell_volt_u16 = (float)BitConverter.ToUInt16(receiveBuffer, startIndex) / 10; startIndex += 2;
            DataBMS.error_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataBMS.dc_bus_state_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataBMS.worst_cell_address_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataBMS.temperature_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            //GPS
            DataGPS.latitude_f32 = BitConverter.ToUInt32(receiveBuffer, startIndex) / MACROS.GPS_DIVIDER; startIndex += 4;
            DataGPS.longtitude_f32 = BitConverter.ToUInt32(receiveBuffer, startIndex) / MACROS.GPS_DIVIDER; startIndex += 4;
            DataGPS.speed_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataGPS.sattelite_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataGPS.efficiency_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            //CAN Error
            DataVCU.can_error_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

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
                if (count == 4)
                {
                    count = 0;
                }
            }
            for (int i = 0; i < 28; i++)
            {
                //DataBMS.cells[i].soc_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            }
        }

    }
}
