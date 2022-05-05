using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telemetri.Variables;

namespace Telemetri.NewForms
{
    public partial class TestForm : Form
    {
        ComproUI comproo;

        private Random rnd = new Random();
        public List<byte> buffer = new List<byte>();

        public TestForm()
        {
            InitializeComponent();
            comproo = new ComproUI(0x31, ComproUI.UI, 23);
            UITools.TestForms.cozuldulyraBox = cozuldulyraBox;
            UITools.TestForms.cozulduvtiBox = cozulduvtiBox;
        }

        #region .. Double Buffered function ..

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion .. Double Buffered function ..

        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion .. code for Flucuring ..

        private void TestForm_Load(object sender, EventArgs e)
        {
            #region doubleBuffer

            SetDoubleBuffered(groupBox1);
            SetDoubleBuffered(groupBox2);
            SetDoubleBuffered(groupBox3);
            SetDoubleBuffered(groupBox4);

            #endregion doubleBuffer
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label31_Click(object sender, EventArgs e)
        {
        }

        private void CreatePack()
        {
            
            //VCU
            byte drive_commands = Convert.ToByte(this.drive_commands.Text);
            Int16 set_rpm = Convert.ToInt16(speed_set_rpm.Text);
            Int16 torque1 = Convert.ToInt16(torque_set_1.Text);
            Int16 torque2 = Convert.ToByte(this.torque_set_2.Text);
            byte torque_limit = Convert.ToByte(this.torque_limit.Text);
            byte steering_angle = Convert.ToByte(this.steering_angle.Text);
            
            //MCU
            //UInt16 ID_Actual        = (UInt16)(Convert.ToUInt16(textBox18.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 ID_Actual = (Int16)(float.Parse(act_id_current.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 IQ_Actual = (Int16)(float.Parse(act_iq_current.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 VD_Actual = (Int16)(float.Parse(vd.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 Vq_Actual = (Int16)(float.Parse(vq.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 ID_Set = (Int16)(float.Parse(set_id_current.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 IQ_Set = (Int16)(float.Parse(set_iq_current.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 Set_Torque = (Int16)(float.Parse(set_torque.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 IDC = (Int16)(float.Parse(i_dc.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 VDC = (Int16)(float.Parse(v_dc.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 Actual_Speed = (Int16)(float.Parse(act_speed.Text) * MACROS.FLOAT_CONVERTER_1);
            UInt16 Error_Status = Convert.ToUInt16(error_status.Text);
            byte Motor_Temp = Convert.ToByte(temperature.Text);
            byte Actual_Torque = Convert.ToByte(act_torque.Text);

            //CAN ERROR
            byte can_error = 0;

            //SD Result
            byte sd_result = 0;
            byte sd_result_write = 0;

            //BMS
            UInt16 Bat_Volt = (UInt16)(float.Parse(volt.Text) * MACROS.FLOAT_CONVERTER_2);
            Int16 Bat_Cur = (Int16)(float.Parse(cur.Text) * MACROS.FLOAT_CONVERTER_2);
            UInt16 Bat_cons = (UInt16)(float.Parse(cons.Text) * MACROS.FLOAT_CONVERTER_1);
            UInt16 Soc = (UInt16)(float.Parse(soc.Text) * MACROS.FLOAT_CONVERTER_2);
            UInt16 Worst_Cell_Voltage = (UInt16)(float.Parse(worst_cell_volt.Text) * MACROS.FLOAT_CONVERTER_1);
            byte BMS_Error = Convert.ToByte(error.Text);
            byte DC_Bus_State = Convert.ToByte(dc_bus_state.Text);
            byte Worst_Cell_Adress = Convert.ToByte(worst_cell_adress.Text);
            byte Temperature = Convert.ToByte(battery_temperature.Text);

            //GPS
            UInt32 latitude_u32 = (UInt32)(float.Parse(latitude.Text) * MACROS.GPS_DIVIDER);
            UInt32 longtitude_u32 = (UInt32)(float.Parse(longitude.Text) * MACROS.GPS_DIVIDER);
            byte gps_speed = Convert.ToByte(speed.Text);
            byte gps_satellite_num = Convert.ToByte(sattelite.Text);
            byte gps_efficiency = Convert.ToByte(efficiency.Text);

            //start
            switch ((ComproUI.MSG_ID)comproo.source_msg_id)
            {
                case ComproUI.MSG_ID.HP_UI_PACK:
                    {
                        //VCU
                        buffer.Add(drive_commands);  //drive commands
                        buffer.AddRange(BitConverter.GetBytes(set_rpm)); //set rpm
                        buffer.AddRange(BitConverter.GetBytes(torque1)); //set torque 1
                        buffer.AddRange(BitConverter.GetBytes(torque2)); //set torque 2
                        buffer.Add(torque_limit); //torque limit
                        buffer.Add(steering_angle); //steering angle

                        //MCU
                        buffer.AddRange(BitConverter.GetBytes(ID_Actual)); //ID_Act
                        buffer.AddRange(BitConverter.GetBytes(IQ_Actual)); //IQ_Act
                        buffer.AddRange(BitConverter.GetBytes(VD_Actual)); //Vd_Act
                        buffer.AddRange(BitConverter.GetBytes(Vq_Actual)); //Vq_Act
                        buffer.AddRange(BitConverter.GetBytes(ID_Set)); //ID_Set
                        buffer.AddRange(BitConverter.GetBytes(IQ_Set)); //IQ_Set
                        buffer.AddRange(BitConverter.GetBytes(Set_Torque)); //Set_torque
                        buffer.AddRange(BitConverter.GetBytes(IDC)); //IDC
                        buffer.AddRange(BitConverter.GetBytes(VDC)); //IDC
                        buffer.AddRange(BitConverter.GetBytes(Actual_Speed)); //Act_speed
                        buffer.Add(Motor_Temp); //Motor_temp
                        buffer.AddRange(BitConverter.GetBytes(Error_Status)); //Error_status
                        buffer.Add(Actual_Torque); //Act_torque

                        break;
                    }
                case ComproUI.MSG_ID.MP_UI_PACK:
                    {
                        //BMS
                        buffer.AddRange(BitConverter.GetBytes(Bat_Volt));           //Bat_Volt
                        buffer.AddRange(BitConverter.GetBytes(Bat_Cur));            //Bat_Cur
                        buffer.AddRange(BitConverter.GetBytes(Bat_cons));           //Bat_Cons
                        buffer.AddRange(BitConverter.GetBytes(Soc));                //Soc
                        buffer.AddRange(BitConverter.GetBytes(Worst_Cell_Voltage)); //Worst_Cell_Voltage
                        buffer.Add(BMS_Error); //BMS_error
                        buffer.Add(DC_Bus_State); //DC_Bus_State
                        buffer.Add(Worst_Cell_Adress); //Worst_Cell_Adress
                        buffer.Add(Temperature); //Temperature

                        //CAN ERROR
                        buffer.Add(can_error);                                  //CAN_Error

                        //SD Result
                        buffer.Add(sd_result);
                        buffer.Add(sd_result_write);

                        break;
                    }
                case ComproUI.MSG_ID.LP_UI_PACK:
                    {
                        //TCU minute
                        buffer.Add(10);
                        buffer.Add(10);
                        buffer.Add(10);

                        //GPS
                        buffer.AddRange(BitConverter.GetBytes(latitude_u32));   //Lattitude
                        buffer.AddRange(BitConverter.GetBytes(longtitude_u32)); //Longtitude
                        buffer.Add(gps_speed);                                  //GPS_Speed
                        buffer.Add(gps_satellite_num);                          //GPS_Satellite_num
                        buffer.Add(gps_efficiency);                             //GPS_Efficiency

                        //CELLS
                        for (int i = 0; i < 28; i++)
                        {
                            buffer.Add((byte)4.2); //Cell_Voltage[i]
                        }

                        //CELL TEMPS
                        for (int i = 0; i < 7; i++)
                        {
                            buffer.Add(20); //Cell_Temp[i] 50
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            //end
            
            /*
            for (int i = 0; i < 28; i++)
            {
                buffer.Add(50); // Cell_SoC[i] 100
            }
            */
        }

        private void startSendBtn_Click(object sender, EventArgs e)
        {
            testTimer.Interval = (int)testTimerInterval.Value;
            if (Anasayfa.mqttobj.connected_flag == true && (lowbutton.Enabled == false || highbutton.Enabled == false || mediumbutton.Enabled == false))
            {
                testTimer.Start();
                startSendBtn.Enabled = false;
                stpBtn.Enabled = true;
                sendOnceBtn.Enabled = false;
            }
            else if (Anasayfa.mqttobj.connected_flag == true)
            {
                MessageBox.Show("Priority Unknown");
            }
            else
            {
                MessageBox.Show("MQTT Bağlantısı Yok!");
            }
        }

        private void stpBtn_Click(object sender, EventArgs e)
        {
            testTimer.Stop();
            startSendBtn.Enabled = true;
            stpBtn.Enabled = false;
            sendOnceBtn.Enabled = true;
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            CreatePack();
            comproo.message = buffer.ToArray();
            comproo.msg_size = (byte)buffer.Count;
            comproo.CreateBuffer();
            comproo.msg_index++;
            Anasayfa.mqttobj.client.Publish("vehicle_to_interface", comproo.buffer);
            buffer.Clear();
        }

        private void sendOnceBtn_Click(object sender, EventArgs e)
        {
            if (Anasayfa.mqttobj.connected_flag == true && (lowbutton.Enabled == false || highbutton.Enabled == false || mediumbutton.Enabled == false))
            {
                CreatePack();
                comproo.message = buffer.ToArray();
                comproo.msg_size = (byte)buffer.Count;
                comproo.CreateBuffer();
                comproo.msg_index++;
                Anasayfa.mqttobj.client.Publish("vehicle_to_interface", comproo.buffer);
                buffer.Clear();
            }
            else if (Anasayfa.mqttobj.connected_flag == true)
            {
                MessageBox.Show("Priority Unknown");
            }
            else
            {
                MessageBox.Show("MQTT Bağlantısı Yok!");
            }
        }

        private void sendOnceNC_Click(object sender, EventArgs e)
        {
            if (Anasayfa.mqttobj.connected_flag == true)
            {
                CreatePack();
                Anasayfa.mqttobj.client.Publish("vehicle_to_interface", buffer.ToArray());
                buffer.Clear();
            }
            else
            {
                MessageBox.Show("MQTT Bağlantısı Yok!");
            }
        }

        private void stopSendNC_Click(object sender, EventArgs e)
        {
            testTimerNC.Stop();
            startSendNC.Enabled = true;
            stopSendNC.Enabled = false;
            sendOnceNC.Enabled = true;
        }

        private void startSendNC_Click(object sender, EventArgs e)
        {
            testTimerNC.Interval = (int)testTimerInterval.Value;
            if (Anasayfa.mqttobj.connected_flag == true)
            {
                testTimerNC.Start();
                startSendNC.Enabled = false;
                stopSendNC.Enabled = true;
                sendOnceNC.Enabled = false;
            }
            else
            {
                MessageBox.Show("MQTT Bağlantısı Yok!");
            }
        }

        private void testTimerNC_Tick(object sender, EventArgs e)
        {
            CreatePack();
            Anasayfa.mqttobj.client.Publish("LYRADATA", buffer.ToArray());
            buffer.Clear();
        }

        private void lowbutton_Click(object sender, EventArgs e)
        {
            lowbutton.Enabled = false;
            mediumbutton.Enabled = true;
            highbutton.Enabled = true;
            comproo.source_msg_id = (byte)ComproUI.MSG_ID.LP_UI_PACK;
        }

        private void mediumbutton_Click(object sender, EventArgs e)
        {
            lowbutton.Enabled = true;
            mediumbutton.Enabled = false;
            highbutton.Enabled = true;
            comproo.source_msg_id = (byte)ComproUI.MSG_ID.MP_UI_PACK;
        }

        private void highbutton_Click(object sender, EventArgs e)
        {
            lowbutton.Enabled = true;
            mediumbutton.Enabled = true;
            highbutton.Enabled = false;
            comproo.source_msg_id = (byte)ComproUI.MSG_ID.HP_UI_PACK;
        }
    }
}