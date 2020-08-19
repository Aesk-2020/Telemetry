using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yeniform.Variables;
namespace yeniform
{
    public partial class BMS_form : Form
    {
        public BMS_form()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        BmsUI bmsUI = new BmsUI();
        string[] ports = SerialPort.GetPortNames();
        const int CatchHeader = 0;
        const int ExtractType = 1;
        const int AddBuffer = 2;

        private void BMS_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            #region CellPictures
            bmsUI.imgArray[0] = cell1_picture;
            bmsUI.imgArray[1] = cell2_picture;
            bmsUI.imgArray[2] = cell3_picture;
            bmsUI.imgArray[3] = cell4_picture;
            bmsUI.imgArray[4] = cell5_picture;
            bmsUI.imgArray[5] = cell6_picture;
            bmsUI.imgArray[6] = cell7_picture;
            bmsUI.imgArray[7] = cell8_picture;
            bmsUI.imgArray[8] = cell9_picture;
            bmsUI.imgArray[9] = cell10_picture;
            bmsUI.imgArray[10] = cell11_picture;
            bmsUI.imgArray[11] = cell12_picture;
            bmsUI.imgArray[12] = cell13_picture;
            bmsUI.imgArray[13] = cell14_picture;
            bmsUI.imgArray[14] = cell15_picture;
            bmsUI.imgArray[15] = cell16_picture;
            bmsUI.imgArray[16] = cell17_picture;
            bmsUI.imgArray[17] = cell18_picture;
            bmsUI.imgArray[18] = cell19_picture;
            bmsUI.imgArray[19] = cell20_picture;
            bmsUI.imgArray[20] = cell21_picture;
            bmsUI.imgArray[21] = cell22_picture;
            bmsUI.imgArray[22] = cell23_picture;
            bmsUI.imgArray[23] = cell24_picture;
            bmsUI.imgArray[24] = cell25_picture;
            bmsUI.imgArray[25] = cell26_picture;
            bmsUI.imgArray[26] = cell27_picture;
            bmsUI.imgArray[27] = cell28_picture;
            #endregion
            #region VoltageLabels
            bmsUI.voltageLabelsArray[0] = cell1_voltage;
            bmsUI.voltageLabelsArray[1] = cell2_voltage;
            bmsUI.voltageLabelsArray[2] = cell3_voltage;
            bmsUI.voltageLabelsArray[3] = cell4_voltage;
            bmsUI.voltageLabelsArray[4] = cell5_voltage;
            bmsUI.voltageLabelsArray[5] = cell6_voltage;
            bmsUI.voltageLabelsArray[6] = cell7_voltage;
            bmsUI.voltageLabelsArray[7] = cell8_voltage;
            bmsUI.voltageLabelsArray[8] = cell9_voltage;
            bmsUI.voltageLabelsArray[9] = cell10_voltage;
            bmsUI.voltageLabelsArray[10] = cell11_voltage;
            bmsUI.voltageLabelsArray[11] = cell12_voltage;
            bmsUI.voltageLabelsArray[12] = cell13_voltage;
            bmsUI.voltageLabelsArray[13] = cell14_voltage;
            bmsUI.voltageLabelsArray[14] = cell15_voltage;
            bmsUI.voltageLabelsArray[15] = cell16_voltage;
            bmsUI.voltageLabelsArray[16] = cell17_voltage;
            bmsUI.voltageLabelsArray[17] = cell18_voltage;
            bmsUI.voltageLabelsArray[18] = cell19_voltage;
            bmsUI.voltageLabelsArray[19] = cell20_voltage;
            bmsUI.voltageLabelsArray[20] = cell21_voltage;
            bmsUI.voltageLabelsArray[21] = cell22_voltage;
            bmsUI.voltageLabelsArray[22] = cell23_voltage;
            bmsUI.voltageLabelsArray[23] = cell24_voltage;
            bmsUI.voltageLabelsArray[24] = cell25_voltage;
            bmsUI.voltageLabelsArray[25] = cell26_voltage;
            bmsUI.voltageLabelsArray[26] = cell27_voltage;
            bmsUI.voltageLabelsArray[27] = cell28_voltage;
            #endregion
            #region TempratureLabels            
            bmsUI.tempLabelsArray[0] = cell1_temp;
            bmsUI.tempLabelsArray[1] = cell2_temp;
            bmsUI.tempLabelsArray[2] = cell3_temp;
            bmsUI.tempLabelsArray[3] = cell4_temp;
            bmsUI.tempLabelsArray[4] = cell5_temp;
            bmsUI.tempLabelsArray[5] = cell6_temp;
            bmsUI.tempLabelsArray[6] = cell7_temp;
            bmsUI.tempLabelsArray[7] = cell8_temp;
            bmsUI.tempLabelsArray[8] = cell9_temp;
            bmsUI.tempLabelsArray[9] = cell10_temp;
            bmsUI.tempLabelsArray[10] = cell11_temp;
            bmsUI.tempLabelsArray[11] = cell12_temp;
            bmsUI.tempLabelsArray[12] = cell13_temp;
            bmsUI.tempLabelsArray[13] = cell14_temp;
            bmsUI.tempLabelsArray[14] = cell15_temp;
            bmsUI.tempLabelsArray[15] = cell16_temp;
            bmsUI.tempLabelsArray[16] = cell17_temp;
            bmsUI.tempLabelsArray[17] = cell18_temp;
            bmsUI.tempLabelsArray[18] = cell19_temp;
            bmsUI.tempLabelsArray[19] = cell20_temp;
            bmsUI.tempLabelsArray[20] = cell21_temp;
            bmsUI.tempLabelsArray[21] = cell22_temp;
            bmsUI.tempLabelsArray[22] = cell23_temp;
            bmsUI.tempLabelsArray[23] = cell24_temp;
            bmsUI.tempLabelsArray[24] = cell25_temp;
            bmsUI.tempLabelsArray[25] = cell26_temp;
            bmsUI.tempLabelsArray[26] = cell27_temp;
            bmsUI.tempLabelsArray[27] = cell28_temp;
            #endregion

            foreach (string port in ports)
            {
                ports_list.Items.Add(port);
                ports_list.SelectedIndex = 0;
            }
            baudrates_list.Items.Add("2400");
            baudrates_list.Items.Add("4800");
            baudrates_list.Items.Add("9600");
            baudrates_list.Items.Add("19200");
            baudrates_list.Items.Add("115200");
            baudrates_list.SelectedIndex = 2;

        }

        private void tableLayoutPanel68_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = ports_list.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudrates_list.Text);
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    if (serialPort1.IsOpen == true)
                    {
                        connection_label.Text = "Bağlantı Açık";
                        connection_label.ForeColor = Color.Green;
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata:" + hata.Message);
                }
            }            
        }
        private void disconnect_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                connection_label.Text = "Bağlantı Kapalı";
                connection_label.ForeColor = Color.Red;
            }
        }

        static int step = 0;
        static int data_counter = 0;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytes];

            serialPort1.Read(buffer, 0, bytes);

            for (int i = 0; i < bytes; i++)
            {
                switch (step)
                {
                    case CatchHeader:
                        {
                            if (buffer[i] == 0xA0)
                            {
                                bmsUI.captured_data[data_counter] = buffer[i];
                                data_counter++;
                                step = ExtractType;
                            }
                            else
                            {
                                step = CatchHeader;
                            }
                            break;
                        }
                    case ExtractType:
                        {
                            bmsUI.captured_data[data_counter] = buffer[i];
                            data_counter++;
                            bmsUI.data_type = bmsUI.ExtractType(buffer[i]);
                            bmsUI.message_length = bmsUI.ExtractMessageLength(buffer[i]);
                            step = AddBuffer;
                            break;
                        }
                    case AddBuffer:
                        {
                            bmsUI.captured_data[data_counter] = buffer[i];
                            data_counter++;
                            if (data_counter >= bmsUI.message_length)
                            {
                                data_counter = 0;
                                step = CatchHeader;
                                bmsUI.gelen_crc = bmsUI.ExtractCRC(bmsUI.captured_data[bmsUI.message_length + 1], bmsUI.captured_data[bmsUI.message_length]);
                                ushort hesaplanan_crc = bmsUI.aeskCRCCalculate(bmsUI.captured_data, Convert.ToUInt16(bmsUI.message_length));
                                switch (bmsUI.data_type)
                                {
                                    case 1:
                                        DisplayVoltage();
                                        break;
                                    case 2:
                                        DisplayTemprature();
                                        break;
                                    case 3:
                                        break;
                                    default:
                                        break;
                                }
                            }
                            step = CatchHeader;
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private void DisplayVoltage()
        {
            for (int i = 0; i < 28; i++)
            {
                if (BMS.bms_cells[i] >= 4000)
                    bmsUI.imgArray[i].Image = cell_images.Images[4];
                else if (BMS.bms_cells[i] < 4000 && BMS.bms_cells[i] >= 3750)
                    bmsUI.imgArray[i].Image = cell_images.Images[3];
                else if (BMS.bms_cells[i] < 3750 && BMS.bms_cells[i] >= 3300)
                    bmsUI.imgArray[i].Image = cell_images.Images[2];
                else if (BMS.bms_cells[i] < 3300 && BMS.bms_cells[i] >= 2750)
                    bmsUI.imgArray[i].Image = cell_images.Images[1];
                else
                    bmsUI.imgArray[i].Image = cell_images.Images[0];
            }

            for (int i = 0; i < bmsUI.voltageLabelsArray.Length; i++)
            {
                bmsUI.voltageLabelsArray[i].Text = Convert.ToString(BMS.bms_cells[i]);
            }

            if(BMS.soc_f32 > 80.0)
            {
                flower_box.Image = socList.Images[4];
            }
            else if(BMS.soc_f32 > 60 && BMS.soc_f32 < 80)
            {
                flower_box.Image = socList.Images[3];
            }
            
            else if ( BMS.soc_f32 < 60 && BMS.soc_f32 > 40)
            {
                flower_box.Image = socList.Images[2];
            }

            else if (BMS.soc_f32 < 40 && BMS.soc_f32 > 20)
            {
                flower_box.Image = socList.Images[1];
            }

            else
            {
                flower_box.Image = socList.Images[0];
            }

            charge_state.BackColor = BMS.charging_u1 ? MACROS.AeskBlue : Color.Red;
            max_cell_temp.Text = BMS.temp_u8.ToString();
            SoC.Text = BMS.soc_f32.ToString();

            soc_1.Text = BMS.bms_soc[0].ToString();
            soc_2.Text = BMS.bms_soc[1].ToString();
            soc_3.Text = BMS.bms_soc[2].ToString();
            soc_4.Text = BMS.bms_soc[3].ToString();
            soc_5.Text = BMS.bms_soc[4].ToString();
            soc_6.Text = BMS.bms_soc[5].ToString();
            soc_7.Text = BMS.bms_soc[6].ToString();
            soc_8.Text = BMS.bms_soc[7].ToString();
            soc_9.Text = BMS.bms_soc[8].ToString();
            soc_10.Text = BMS.bms_soc[9].ToString();
            soc_11.Text = BMS.bms_soc[10].ToString();
            soc_12.Text = BMS.bms_soc[11].ToString();
            soc_13.Text = BMS.bms_soc[12].ToString();
            soc_14.Text = BMS.bms_soc[13].ToString();
            soc_15.Text = BMS.bms_soc[14].ToString();
            soc_16.Text = BMS.bms_soc[15].ToString();
            soc_17.Text = BMS.bms_soc[16].ToString();
            soc_18.Text = BMS.bms_soc[17].ToString();
            soc_19.Text = BMS.bms_soc[18].ToString();
            soc_20.Text = BMS.bms_soc[19].ToString();
            soc_21.Text = BMS.bms_soc[20].ToString();
            soc_22.Text = BMS.bms_soc[21].ToString();
            soc_23.Text = BMS.bms_soc[22].ToString();
            soc_24.Text = BMS.bms_soc[23].ToString();
            soc_25.Text = BMS.bms_soc[24].ToString();
            soc_26.Text = BMS.bms_soc[25].ToString();
            soc_27.Text = BMS.bms_soc[26].ToString();
            soc_28.Text = BMS.bms_soc[27].ToString();
        }
        private void DisplayTemprature()
        {
            cell1_temp.Text = BMS.temp1_u8.ToString();
            cell2_temp.Text = BMS.temp1_u8.ToString();
            cell3_temp.Text = BMS.temp1_u8.ToString();
            cell4_temp.Text = BMS.temp1_u8.ToString();

            cell5_temp.Text = BMS.temp2_u8.ToString();
            cell6_temp.Text = BMS.temp2_u8.ToString();
            cell7_temp.Text = BMS.temp2_u8.ToString();
            cell8_temp.Text = BMS.temp2_u8.ToString();

            cell9_temp.Text = BMS.temp3_u8.ToString();
            cell10_temp.Text = BMS.temp3_u8.ToString();
            cell11_temp.Text = BMS.temp3_u8.ToString();
            cell12_temp.Text = BMS.temp3_u8.ToString();

            cell13_temp.Text = BMS.temp4_u8.ToString();
            cell14_temp.Text = BMS.temp4_u8.ToString();
            cell15_temp.Text = BMS.temp4_u8.ToString();
            cell16_temp.Text = BMS.temp4_u8.ToString();

            cell17_temp.Text = BMS.temp5_u8.ToString();
            cell18_temp.Text = BMS.temp5_u8.ToString();
            cell19_temp.Text = BMS.temp5_u8.ToString();
            cell20_temp.Text = BMS.temp5_u8.ToString();

            cell21_temp.Text = BMS.temp6_u8.ToString();
            cell22_temp.Text = BMS.temp6_u8.ToString();
            cell23_temp.Text = BMS.temp6_u8.ToString();
            cell24_temp.Text = BMS.temp6_u8.ToString();

            cell25_temp.Text = BMS.temp7_u8.ToString();
            cell26_temp.Text = BMS.temp7_u8.ToString();
            cell27_temp.Text = BMS.temp7_u8.ToString();
            cell28_temp.Text = BMS.temp7_u8.ToString();
            karbon_ayak_izi.Text = (((BMS.bat_cons_f32 / 1000) * 0.283)).ToString("0.00");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayVoltage();
            DisplayTemprature();
        }
    }
}
