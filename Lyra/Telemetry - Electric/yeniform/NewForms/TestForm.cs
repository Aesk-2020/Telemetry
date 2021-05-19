using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.Variables;

namespace Telemetri.NewForms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        public List<byte> buffer = new List<byte>();

        private void TestForm_Load(object sender, EventArgs e)
        {

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

        private void startSendBtn_Click(object sender, EventArgs e)
        {
            testTimer.Interval = (int)testTimerInterval.Value;
            CreatePack();
            testTimer.Start();
        }

        private void stpBtn_Click(object sender, EventArgs e)
        {
            testTimer.Stop();
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            Anasayfa.mqttobj.client.Publish("interface_to_vehicle", buffer.ToArray());
            buffer.Clear();
        }
        private void CreatePack()
        {
            
            //VCU
            UInt16 set_rpm          = Convert.ToUInt16(textBox2.Text);
            UInt16 speed_limit      = Convert.ToByte(textBox4.Text);
            byte drive_commands     = Convert.ToByte(textBox1.Text);
            byte torque             = Convert.ToByte(textBox3.Text);
            byte torque_limit       = Convert.ToByte(textBox5.Text);

            buffer.Add(drive_commands);  //drive commands
            buffer.AddRange(BitConverter.GetBytes(set_rpm)); //set rpm
            buffer.Add(torque); //set torque
            buffer.AddRange(BitConverter.GetBytes(speed_limit)); //speed limit
            buffer.Add(torque_limit); //torque limit

            //MCU
            UInt16 ID_Actual        = Convert.ToUInt16(textBox18.Text);
            UInt16 IQ_Actual        = Convert.ToUInt16(textBox17.Text);
            UInt16 VD_Actual        = Convert.ToUInt16(textBox16.Text);
            UInt16 Vq_Actual        = Convert.ToUInt16(textBox15.Text);
            UInt16 ID_Set           = Convert.ToUInt16(textBox14.Text);
            UInt16 IQ_Set           = Convert.ToUInt16(textBox13.Text);
            UInt16 Set_Torque       = Convert.ToUInt16(textBox26.Text);
            UInt16 IDC              = Convert.ToUInt16(textBox27.Text);
            UInt16 Actual_Speed     = Convert.ToUInt16(textBox28.Text);
            UInt16 Error_Status     = Convert.ToUInt16(textBox30.Text);
            byte Motor_Temp         = Convert.ToByte(textBox29);
            byte Actual_Torque      = Convert.ToByte(textBox31);


            buffer.AddRange(BitConverter.GetBytes(ID_Actual)); //ID_Act
            buffer.AddRange(BitConverter.GetBytes(IQ_Actual)); //IQ_Act
            buffer.AddRange(BitConverter.GetBytes(VD_Actual)); //Vd_Act
            buffer.AddRange(BitConverter.GetBytes(Vq_Actual)); //Vq_Act
            buffer.AddRange(BitConverter.GetBytes(ID_Set)); //ID_Set
            buffer.AddRange(BitConverter.GetBytes(IQ_Set)); //IQ_Set
            buffer.AddRange(BitConverter.GetBytes(Set_Torque)); //Set_torque
            buffer.AddRange(BitConverter.GetBytes(IDC)); //IDC
            buffer.AddRange(BitConverter.GetBytes(Actual_Speed)); //Act_speed
            buffer.Add(Motor_Temp); //Motor_temp
            buffer.AddRange(BitConverter.GetBytes(Error_Status)); //Error_status
            buffer.Add(Actual_Torque); //Act_torque

            //BMS

            UInt16 Bat_Volt             = (UInt16)(Convert.ToSingle(textBox12.Text) * MACROS.FLOAT_CONVERTER_2);
            UInt16 Bat_Cur              = (UInt16)(Convert.ToSingle(textBox11.Text) * MACROS.FLOAT_CONVERTER_2);
            UInt16 Bat_cons             = (UInt16)(Convert.ToSingle(textBox10.Text) * MACROS.FLOAT_CONVERTER_1);
            UInt16 Soc                  = (UInt16)(Convert.ToSingle(textBox9.Text) * MACROS.FLOAT_CONVERTER_2);
            UInt16 Worst_Cell_Voltage   = (UInt16)(Convert.ToSingle(textBox8.Text) * MACROS.FLOAT_CONVERTER_1);
            byte BMS_Error              = Convert.ToByte(textBox7.Text);
            byte DC_Bus_State           = Convert.ToByte(textBox6.Text);
            byte Worst_Cell_Adress      = Convert.ToByte(textBox19.Text);
            byte Temperature            = Convert.ToByte(textBox20.Text);

            buffer.AddRange(BitConverter.GetBytes(Bat_Volt));           //Bat_Volt
            buffer.AddRange(BitConverter.GetBytes(Bat_Cur));            //Bat_Cur
            buffer.AddRange(BitConverter.GetBytes(Bat_cons));           //Bat_Cons
            buffer.AddRange(BitConverter.GetBytes(Soc));                //Soc
            buffer.AddRange(BitConverter.GetBytes(Worst_Cell_Voltage)); //Worst_Cell_Voltage
            buffer.Add(BMS_Error); //BMS_error
            buffer.Add(DC_Bus_State); //DC_Bus_State
            buffer.Add(Worst_Cell_Adress); //Worst_Cell_Adress
            buffer.Add(Temperature); //Temperature

            //GPS
            UInt32 latitude_u32         = (UInt16)(Convert.ToSingle(textBox25.Text) * MACROS.GPS_DIVIDER);
            UInt32 longtitude_u32       = (UInt16)(Convert.ToSingle(textBox24.Text) * MACROS.GPS_DIVIDER);
            byte gps_speed              = Convert.ToByte(textBox21);
            byte gps_satellite_num      = Convert.ToByte(textBox22);
            byte gps_efficiency         = Convert.ToByte(textBox23);

            buffer.AddRange(BitConverter.GetBytes(latitude_u32));   //Lattitude
            buffer.AddRange(BitConverter.GetBytes(longtitude_u32)); //Longtitude
            buffer.Add(gps_speed);                                  //GPS_Speed
            buffer.Add(gps_satellite_num);                          //GPS_Satellite_num
            buffer.Add(gps_efficiency);                             //GPS_Efficiency

            //CAN ERROR
            byte can_error = 0;
            buffer.Add(can_error);                                  //CAN_Error

            //CELLS
            for (int i = 0; i < 28; i++)
            {
                buffer.Add(13); //Cell_Voltage[i]
            }

            //CELL TEMPS
            for (int i = 0; i < 28; i++)
            {
                buffer.Add(33); //Cell_Temp[i]
            }

        }
    }
}
