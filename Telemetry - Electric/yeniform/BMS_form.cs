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
                                        DisplayGeneralState();
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
                bmsUI.cells_voltage[i] = Convert.ToUInt16(bmsUI.captured_data[i + 2]); //bu bitconverter ile değişecek

                if (bmsUI.cells_voltage[i] >= 200)
                    bmsUI.imgArray[i].Image = cell_images.Images[4];
                else if (bmsUI.cells_voltage[i] < 200 && bmsUI.cells_voltage[i] >= 100)
                    bmsUI.imgArray[i].Image = cell_images.Images[3];
                else if (bmsUI.cells_voltage[i] < 100 && bmsUI.cells_voltage[i] >= 50)
                    bmsUI.imgArray[i].Image = cell_images.Images[2];
                else if (bmsUI.cells_voltage[i] < 50 && bmsUI.cells_voltage[i] >= 25)
                    bmsUI.imgArray[i].Image = cell_images.Images[1];
                else
                    bmsUI.imgArray[i].Image = cell_images.Images[0];
            }

            for (int i = 0; i < bmsUI.voltageLabelsArray.Length; i++)
            {
                bmsUI.voltageLabelsArray[i].Text = Convert.ToString(bmsUI.cells_voltage[i]);
            }

            //kullanım dışı
            #region gerilimden-ekrana
            /*
            cell1_voltage.Text = Convert.ToString(bmsUI.cells_voltage[0]);
            cell2_voltage.Text = Convert.ToString(bmsUI.cells_voltage[1]);
            cell3_voltage.Text = Convert.ToString(bmsUI.cells_voltage[2]);
            cell4_voltage.Text = Convert.ToString(bmsUI.cells_voltage[3]);
            cell5_voltage.Text = Convert.ToString(bmsUI.cells_voltage[4]);
            cell6_voltage.Text = Convert.ToString(bmsUI.cells_voltage[5]);
            cell7_voltage.Text = Convert.ToString(bmsUI.cells_voltage[6]);
            cell8_voltage.Text = Convert.ToString(bmsUI.cells_voltage[7]);
            cell9_voltage.Text = Convert.ToString(bmsUI.cells_voltage[8]);
            cell10_voltage.Text = Convert.ToString(bmsUI.cells_voltage[9]);
            cell11_voltage.Text = Convert.ToString(bmsUI.cells_voltage[10]);
            cell12_voltage.Text = Convert.ToString(bmsUI.cells_voltage[11]);
            cell13_voltage.Text = Convert.ToString(bmsUI.cells_voltage[12]);
            cell14_voltage.Text = Convert.ToString(bmsUI.cells_voltage[13]);
            cell15_voltage.Text = Convert.ToString(bmsUI.cells_voltage[14]);
            cell16_voltage.Text = Convert.ToString(bmsUI.cells_voltage[15]);
            cell17_voltage.Text = Convert.ToString(bmsUI.cells_voltage[16]);
            cell18_voltage.Text = Convert.ToString(bmsUI.cells_voltage[17]);
            cell19_voltage.Text = Convert.ToString(bmsUI.cells_voltage[18]);
            cell20_voltage.Text = Convert.ToString(bmsUI.cells_voltage[19]);
            cell21_voltage.Text = Convert.ToString(bmsUI.cells_voltage[20]);
            cell22_voltage.Text = Convert.ToString(bmsUI.cells_voltage[21]);
            cell23_voltage.Text = Convert.ToString(bmsUI.cells_voltage[22]);
            cell24_voltage.Text = Convert.ToString(bmsUI.cells_voltage[23]);
            cell25_voltage.Text = Convert.ToString(bmsUI.cells_voltage[24]);
            cell26_voltage.Text = Convert.ToString(bmsUI.cells_voltage[25]);
            cell27_voltage.Text = Convert.ToString(bmsUI.cells_voltage[26]);
            cell28_voltage.Text = Convert.ToString(bmsUI.cells_voltage[27]);
            */        
            #endregion
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

            //kullanım dışı
            #region sıcaklıktan-ekrana
            /*
            cell1_temp.Text = Convert.ToString(cells_temprature[0]);
            cell2_temp.Text = Convert.ToString(cells_temprature[1]);
            cell3_temp.Text = Convert.ToString(cells_temprature[2]);
            cell4_temp.Text = Convert.ToString(cells_temprature[3]);
            cell5_temp.Text = Convert.ToString(cells_temprature[4]);
            cell6_temp.Text = Convert.ToString(cells_temprature[5]);
            cell7_temp.Text = Convert.ToString(cells_temprature[6]);
            cell8_temp.Text = Convert.ToString(cells_temprature[7]);
            cell9_temp.Text = Convert.ToString(cells_temprature[8]);
            cell10_temp.Text = Convert.ToString(cells_temprature[9]);
            cell11_temp.Text = Convert.ToString(cells_temprature[10]);
            cell12_temp.Text = Convert.ToString(cells_temprature[11]);
            cell13_temp.Text = Convert.ToString(cells_temprature[12]);
            cell14_temp.Text = Convert.ToString(cells_temprature[13]);
            cell15_temp.Text = Convert.ToString(cells_temprature[14]);
            cell16_temp.Text = Convert.ToString(cells_temprature[15]);
            cell17_temp.Text = Convert.ToString(cells_temprature[16]);
            cell18_temp.Text = Convert.ToString(cells_temprature[17]);
            cell19_temp.Text = Convert.ToString(cells_temprature[18]);
            cell20_temp.Text = Convert.ToString(cells_temprature[19]);
            cell21_temp.Text = Convert.ToString(cells_temprature[20]);
            cell22_temp.Text = Convert.ToString(cells_temprature[21]);
            cell23_temp.Text = Convert.ToString(cells_temprature[22]);
            cell24_temp.Text = Convert.ToString(cells_temprature[23]);
            cell25_temp.Text = Convert.ToString(cells_temprature[24]);
            cell26_temp.Text = Convert.ToString(cells_temprature[25]);
            cell27_temp.Text = Convert.ToString(cells_temprature[26]);
            cell28_temp.Text = Convert.ToString(cells_temprature[27]);
            */
            #endregion
        }
        private void DisplayGeneralState()
        {

        }
    }
}
