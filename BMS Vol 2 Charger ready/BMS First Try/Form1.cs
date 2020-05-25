using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Media;

namespace BMS_First_Try
{
    public partial class BMS : Form
    {
        

        string[] ports = SerialPort.GetPortNames();
        static readonly int max_incoming = 32;
        static int gelen_crc = 0;
        byte[] captured_data = new byte[max_incoming + 1];
        private Thread cpuThread;
        UInt16[] cells_voltage = new UInt16[28];
        UInt16[] cells_temprature = new UInt16[28];
        int data_type = 20; //00 ilk iki bit veri tipi (1 cell 2 gerilim 3 genel durum)
        int message_length; //000000 son 6 bit veri miktarı (byte cinsinden)
        int maxy = 100;
        int miny = -100;
        int maxx = 200;
        int minx = 0;

        PictureBox[] imgArray = new PictureBox[28];
        Label[] labelArray = new Label[28];
        CheckBox[] checkboxArray = new CheckBox[28];
        Label[] tempLabelsArray = new Label[28];

        public BMS()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cellTab_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void graphTab_Click(object sender, EventArgs e)
        {
            /*
            chart1.ChartAreas[0].AxisX.Minimum = min;
            chart1.ChartAreas[0].AxisX.Maximum = max;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1200;

            sonuc = "6545";
            this.chart1.Series["cell_1"].Points.AddXY((min + max) / 2, sonuc);
            */
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = ports_list.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudrates_list.Text);
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    if (serialPort1.IsOpen == true)
                    {
                        System.Media.SoundPlayer connect = new System.Media.SoundPlayer();
                        connect.SoundLocation = @"F:\Yusuf\Ders & Bölüm\AESK\c#\BMS New Interface\BMS First Try\obj\Debug\voice\opening.wav";
                        connect.Play();
                        connection_label.Text = "Bağlantı Açık";
                        connection_label.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata:" + hata.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            System.Media.SoundPlayer load = new System.Media.SoundPlayer();
            load.SoundLocation = @"F:\Yusuf\Ders & Bölüm\AESK\c#\BMS New Interface\BMS First Try\obj\Debug\voice\this_voice.wav";
            load.Play();
            */

            #region CellPictures
            imgArray[0] = cell1_picture;
            imgArray[1] = cell2_picture;
            imgArray[2] = cell3_picture;
            imgArray[3] = cell4_picture;
            imgArray[4] = cell5_picture;
            imgArray[5] = cell6_picture;
            imgArray[6] = cell7_picture;
            imgArray[7] = cell8_picture;
            imgArray[8] = cell9_picture;
            imgArray[9] = cell10_picture;
            imgArray[10] = cell11_picture;
            imgArray[11] = cell12_picture;
            imgArray[12] = cell13_picture;
            imgArray[13] = cell14_picture;
            imgArray[14] = cell15_picture;
            imgArray[15] = cell16_picture;
            imgArray[16] = cell17_picture;
            imgArray[17] = cell18_picture;
            imgArray[18] = cell19_picture;
            imgArray[19] = cell20_picture;
            imgArray[20] = cell21_picture;
            imgArray[21] = cell22_picture;
            imgArray[22] = cell23_picture;
            imgArray[23] = cell24_picture;
            imgArray[24] = cell25_picture;
            imgArray[25] = cell26_picture;
            imgArray[26] = cell27_picture;
            imgArray[27] = cell28_picture;
            #endregion
            #region TempLabels
            tempLabelsArray[0] = cell1_temp;
            tempLabelsArray[1] = cell2_temp;
            tempLabelsArray[2] = cell3_temp;
            tempLabelsArray[3] = cell4_temp;
            tempLabelsArray[4] = cell5_temp;
            tempLabelsArray[5] = cell6_temp;
            tempLabelsArray[6] = cell7_temp;
            tempLabelsArray[7] = cell8_temp;
            tempLabelsArray[8] = cell9_temp;
            tempLabelsArray[9] = cell10_temp;
            tempLabelsArray[10] = cell11_temp;
            tempLabelsArray[11] = cell12_temp;
            tempLabelsArray[12] = cell13_temp;
            tempLabelsArray[13] = cell14_temp;
            tempLabelsArray[14] = cell15_temp;
            tempLabelsArray[15] = cell16_temp;
            tempLabelsArray[16] = cell17_temp;
            tempLabelsArray[17] = cell18_temp;
            tempLabelsArray[18] = cell19_temp;
            tempLabelsArray[19] = cell20_temp;
            tempLabelsArray[20] = cell21_temp;
            tempLabelsArray[21] = cell22_temp;
            tempLabelsArray[22] = cell23_temp;
            tempLabelsArray[23] = cell24_temp;
            tempLabelsArray[24] = cell25_temp;
            tempLabelsArray[25] = cell26_temp;
            tempLabelsArray[26] = cell27_temp;
            tempLabelsArray[27] = cell28_temp;
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
            cellcurent_graph.ChartAreas[0].AxisX.Maximum = maxx;
            cellcurent_graph.ChartAreas[0].AxisX.Minimum = minx;
            cellcurent_graph.ChartAreas[0].AxisY.Maximum = maxy;
            cellcurent_graph.ChartAreas[0].AxisY.Minimum = miny;

            timer1.Start();


        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                int bytes = serialPort1.BytesToRead;
                byte[] buffer = new byte[bytes];
                
                int step = 0;
                int data_counter = 0;
                int counter = 0;

                serialPort1.Read(buffer, 0, bytes);

                for(int i = 0; i < bytes; i++)
                {
                    switch(step)
                    {
                        case 0:
                            {
                                if(buffer[i]==0xA0)
                                {                                    
                                    step = 1;
                                }
                                break;
                            }
                        case 1:
                            {                                
                                data_type = buffer[i] >> 6; //ilk 2 bit veri biçimini tanımlar, 1-sıcaklık 2-gerilim 3-genel durum
                                if((data_type == 1 || data_type == 2) || data_type == 3)
                                {
                                    message_length = buffer[i] & 0b00111111; //son 6 bit paket uzunluğunu temsil ettiği için son 6 byteı ayıklıyoruz, paket uzunluğu sadece bilgi içeren byteları ifade eder
                                    step = 2;
                                }
                                
                                else
                                {
                                    step = 0;
                                }

                                break;
                            }
                        case 2:
                            {
                                captured_data[data_counter] = buffer[i];
                                data_counter++;
                                counter++;

                                if(counter > (message_length + 2)) //paket uzunluğu kadar byte ve 2 byte CRC alınca hesaplamaları başlatacak
                                {
                                    gelen_crc = (captured_data[message_length + 1] << 8) | captured_data[message_length]; //crc bytelarını tayin ettikten sonra burayı değiştir
                                    ushort crc_hesaplanan = aeskCRCCalculate(captured_data, Convert.ToUInt32(message_length));                                   
                                    
                                    if(gelen_crc == crc_hesaplanan)
                                    {
                                        label41.BackColor = Color.Green;
                                        switch(data_type)
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
                                    else
                                    {
                                        label41.BackColor = Color.Red;
                                    }
                                    
                                    step = 3;
                                    counter = 0;
                                    data_counter = 0;                                    
                                }
                                break;
                            }
                        
                        case 3:
                            {
                                if (buffer[i] == 0xFF)
                                {
                                    captured_data[data_counter] = buffer[i];
                                    step = 0;
                                }
                                break;
                            }
                        default: break;
                    }
                }                                            
            }
        }

        private void DisplayGeneralState()
        {

        }

        private void DisplayTemprature()
        {
            int counter = 0;
            for (int i = 0; i < 7; i++)
            {                
                for(int j = 0; j < 4; j++)
                {
                    cells_temprature[counter] = Convert.ToUInt16(captured_data[i]);
                    counter++;
                }               
            }
            #region sıcaklıktan-ekrana
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
            #endregion
        }

        private void DisplayVoltage()
        {
            for (int i = 0; i < 28; i++)
            {
                cells_voltage[i] = Convert.ToUInt16(captured_data[i]); //bu bitconverter ile değişecek

                if (cells_voltage[i] >= 200)
                    imgArray[i].Image = cell_images.Images[4];
                else if (cells_voltage[i] < 200 && cells_voltage[i] >= 100)
                    imgArray[i].Image = cell_images.Images[3];
                else if (cells_voltage[i] < 100 && cells_voltage[i] >= 50)
                    imgArray[i].Image = cell_images.Images[2];
                else if (cells_voltage[i] < 50 && cells_voltage[i] >= 25)
                    imgArray[i].Image = cell_images.Images[1];
                else
                    imgArray[i].Image = cell_images.Images[0];                
            }

            #region gerilimden-ekrana
            cell1_voltage.Text = Convert.ToString(cells_voltage[0]);
            cell2_voltage.Text = Convert.ToString(cells_voltage[1]);
            cell3_voltage.Text = Convert.ToString(cells_voltage[2]);
            cell4_voltage.Text = Convert.ToString(cells_voltage[3]);
            cell5_voltage.Text = Convert.ToString(cells_voltage[4]);
            cell6_voltage.Text = Convert.ToString(cells_voltage[5]);
            cell7_voltage.Text = Convert.ToString(cells_voltage[6]);
            cell8_voltage.Text = Convert.ToString(cells_voltage[7]);
            cell9_voltage.Text = Convert.ToString(cells_voltage[8]);
            cell10_voltage.Text = Convert.ToString(cells_voltage[9]);
            cell11_voltage.Text = Convert.ToString(cells_voltage[10]);
            cell12_voltage.Text = Convert.ToString(cells_voltage[11]);
            cell13_voltage.Text = Convert.ToString(cells_voltage[12]);
            cell14_voltage.Text = Convert.ToString(cells_voltage[13]);
            cell15_voltage.Text = Convert.ToString(cells_voltage[14]);
            cell16_voltage.Text = Convert.ToString(cells_voltage[15]);
            cell17_voltage.Text = Convert.ToString(cells_voltage[16]);
            cell18_voltage.Text = Convert.ToString(cells_voltage[17]);
            cell19_voltage.Text = Convert.ToString(cells_voltage[18]);
            cell20_voltage.Text = Convert.ToString(cells_voltage[19]);
            cell21_voltage.Text = Convert.ToString(cells_voltage[20]);
            cell22_voltage.Text = Convert.ToString(cells_voltage[21]);
            cell23_voltage.Text = Convert.ToString(cells_voltage[22]);
            cell24_voltage.Text = Convert.ToString(cells_voltage[23]);
            cell25_voltage.Text = Convert.ToString(cells_voltage[24]);
            cell26_voltage.Text = Convert.ToString(cells_voltage[25]);
            cell27_voltage.Text = Convert.ToString(cells_voltage[26]);
            cell28_voltage.Text = Convert.ToString(cells_voltage[27]);
            #endregion

            cpuThread = new Thread(new ThreadStart(this.graph_draw));
            cpuThread.Start();
        }

        static ushort aeskCRCCalculate(byte[] frame, uint framesize)
        {
            ushort crc16_data = 0;
            byte data = 0;
            for (byte mlen = 0; mlen < framesize; mlen++)
            {
                data = Convert.ToByte(((byte)frame[mlen] ^ Convert.ToByte(((crc16_data) & (0xFF)))));
                data = (byte)((byte)data ^ (byte)(data << 4));
                crc16_data = (ushort)((((ushort)data << 8) | ((crc16_data & 0xFF00) >> 8)) ^ (byte)(data >> 4) ^ ((ushort)data << 3));
            }
            return (crc16_data);
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                connection_label.Text = "Bağlantı Kapalı";
                connection_label.ForeColor = Color.Red;
            }
        }


        private void graph_draw()
        {

            this.Invoke((MethodInvoker)delegate { draw_func(); });
            Thread.Sleep(500);

        }

        private void draw_func()
        {
            cellchart_1.Series["cells_voltage"].Points.Clear();
            cellchart_2.Series["cells_voltage"].Points.Clear();
            cellchart_3.Series["cells_voltage"].Points.Clear();
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-1", cells_voltage[0]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-2", cells_voltage[1]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-3", cells_voltage[2]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-4", cells_voltage[3]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-5", cells_voltage[4]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-6", cells_voltage[5]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-7", cells_voltage[6]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-8", cells_voltage[7]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-9", cells_voltage[8]);
            cellchart_1.Series["cells_voltage"].Points.AddXY("Cell-10", cells_voltage[9]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-11", cells_voltage[10]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-12", cells_voltage[11]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-13", cells_voltage[12]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-14", cells_voltage[13]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-15", cells_voltage[14]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-16", cells_voltage[15]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-17", cells_voltage[16]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-18", cells_voltage[17]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-19", cells_voltage[18]);
            cellchart_2.Series["cells_voltage"].Points.AddXY("Cell-20", cells_voltage[19]);
            cellchart_3.Series["cells_voltage"].Points.AddXY("Cell-21", cells_voltage[20]);
            cellchart_3.Series["cells_voltage"].Points.AddXY("Cell-22", cells_voltage[21]);
            cellchart_3.Series["cells_voltage"].Points.AddXY("Cell-23", cells_voltage[22]);
            cellchart_3.Series["cells_voltage"].Points.AddXY("Cell-24", cells_voltage[23]);
            cellchart_3.Series["cells_voltage"].Points.AddXY("Cell-25", cells_voltage[24]);
            cellchart_3.Series["cells_voltage"].Points.AddXY("Cell-26", cells_voltage[25]);
            cellchart_3.Series["cells_voltage"].Points.AddXY("Cell-27", cells_voltage[26]);
            cellchart_3.Series["cells_voltage"].Points.AddXY("Cell-28", cells_voltage[27]);

        }


        private void Voltage_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        int x = 0;
        int x_scala = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {

            cellcurent_graph.Series["Current"].Points.AddXY(x,cells_voltage[0]);


            x_scala = x_bar.Value;

            maxy = y_bar.Value;


            cellcurent_graph.ChartAreas[0].AxisX.Maximum = x + x_scala/4;
            cellcurent_graph.ChartAreas[0].AxisX.Minimum = x - x_scala * 0.75;
            cellcurent_graph.ChartAreas[0].AxisY.Maximum = maxy;
            x++;
        }

        private void cellcurent_graph_Click(object sender, EventArgs e)
        {

        }

    }
}
