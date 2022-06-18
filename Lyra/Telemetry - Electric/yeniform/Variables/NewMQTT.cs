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
        public DateTime lastResponse;
        public DateTime Response;
        public int al = 0;
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
                try
                {
                    this.client = new MqttClient(this.broker);
                    byte code = this.client.Connect(Guid.NewGuid().ToString(), _username, _password);
                    if (code == 0x00)
                    {
                        try
                        {
                            this.client.Subscribe(new string[] { this.topic, this.topic2 }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                            this.client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                            this.client.ConnectionClosed += Client_MqttConnectionClosed;
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
                catch (Exception e)
                {
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol edin\n" + e.Message);
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
                AFront.ThreadStop();
                al = 0;
                // Thread abort eklenicek
            }
            else
            {
                MessageBox.Show("Zaten bağlı değilsiniz");
            }
        }
        private void Client_MqttConnectionClosed(object sender, EventArgs e)
        {
            this.client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
            this.client.ConnectionClosed -= Client_MqttConnectionClosed;
            connected_flag = false;

            UITools.Anasayfa.mqttConnectBtn.Enabled = true;
            UITools.Anasayfa.mqttDisconnectBtn.Enabled = false;
            UITools.Anasayfa.startLogBtn.Enabled = false;
            UITools.Anasayfa.resetBoardBtn.Enabled = false;
            UITools.Anasayfa.portConnectBtn.Enabled = true;
            UITools.Telemetry2021.activeChannelLabel.Text = "None";
            UITools.Telemetry2021.graphTimer.Stop();
        }


        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            lastResponse = Response;
            Response = DateTime.Now;

            ComproUI compro = new ComproUI();

            //compro.ComproUnpack(e.Message);
            if(e.Topic == "LYRADATA")
            {
                if(e.Retain == false)
                {
                    if(e.Message.Length != 0)
                    {
                        YedekUnpack(e.Message);
                        UITools.TestForms.lyraco++;
                        UITools.TestForms.cozuldulyraBox.Text = UITools.TestForms.lyraco.ToString();
                    }
                }
            }
            else if(e.Topic == "vehicle_to_interface")
            {
                ComproUI pack = new ComproUI();
                UITools.TestForms.vtico++;
                UITools.TestForms.cozulduvtiBox.Text = UITools.TestForms.vtico.ToString();
                pack.ComproUnpack(e.Message);
            }
        }

        public void YedekUnpack(byte[] receiveBuffer)
        {
            int startIndex = 0;
            DataVCU.drive_commands_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            DataVCU.speed_set_rpm_s16 = (short)Math.Round(BitConverter.ToInt16(receiveBuffer, startIndex) * 0.105183); startIndex += 2; //0.105183 rpm to kmh rate
            DataVCU.torque_set_s16    = BitConverter.ToInt16(receiveBuffer, startIndex); startIndex += 2;
            DataVCU.torque_set_2_s16   = BitConverter.ToInt16(receiveBuffer, startIndex); startIndex += 2;
            DataVCU.torque_limit_u8   = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

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
            DataMCU.act_speed_s16 = (short)Math.Round(BitConverter.ToInt16(receiveBuffer, startIndex) * 0.105183 / 10); startIndex += 2;
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

            //SD result
            DataVCU.SD_result_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            //TCU minute
            DataVCU.TCU_minute_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;

            for (int i = 0; i < DataBMS.cells.Count; i++)
            {

                DataBMS.cells[i].voltage_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            }

            int counterr = 0;
            for (int i = 0; i < DataBMS.cells.Count / 4; i++)
            {
                byte temperatureBuffer = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
                for (int j = 0; j < 4; j++)
                {
                    DataBMS.cells[counterr++].temperature_u8 = temperatureBuffer;
                }
            }
            // 0 1 2 3
            // 4 5 6 7
            // 8 9 10 11
            // 12 13 14 15
            // 14 15 16 17
            // 18 19 20 21
            // 21 22 23 24
            // 25 26 27 28

            /*for (int i = 0; i < DataBMS.cells.Count; i++)
            {
                DataBMS.cells[0].soc_u8 = (byte)BitConverter.ToChar(receiveBuffer, startIndex); startIndex++;
            }*/
        }

    }
}
