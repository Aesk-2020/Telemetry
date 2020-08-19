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
using telemetry_hydro.Variables;
namespace telemetry_hydro
{
    public partial class BMS_form : Form
    {
        public BMS_form()
        {
            InitializeComponent();
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
            for (int i = 0; i < 16; i++)
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

            for (int i = 0; i < 16; i++)
            {
                bmsUI.voltageLabelsArray[i].Text = Convert.ToString(BMS.bms_cells[i]);
            }

            if (BMS.soc_f32 > 80.0)
            {
                flower_box.Image = socList.Images[4];
            }
            else if (BMS.soc_f32 > 60 && BMS.soc_f32 < 80)
            {
                flower_box.Image = socList.Images[3];
            }

            else if (BMS.soc_f32 < 60 && BMS.soc_f32 > 40)
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

        }
        private void DisplayTemprature()
        {
            int counter = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bmsUI.cells_temprature[counter] = Convert.ToUInt16(bmsUI.captured_data[i]);
                    counter++;
                }
            }

            for (int i = 0; i < bmsUI.tempLabelsArray.Length; i++)
            {
                bmsUI.tempLabelsArray[i].Text = Convert.ToString(bmsUI.cells_temprature[i]);
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DisplayVoltage();
        }
    }
}
