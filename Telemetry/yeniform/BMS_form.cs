using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yeniform.Variables;
namespace yeniform
{
    public partial class BMS_form : Form
    {
        BMS bms = new BMS();
        public BMS_form()
        {
            InitializeComponent();
        }

        UInt16[] cells_voltage = new UInt16[28];
        UInt16[] cells_temprature = new UInt16[28];

        PictureBox[] imgArray = new PictureBox[28];
        Label[] labelArray = new Label[28];
        CheckBox[] checkboxArray = new CheckBox[28];
        Label[] tempLabelsArray = new Label[28];



        private void BMS_Load(object sender, EventArgs e)
        {
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
            #region TempratureLabels
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
           
        }

        private void tableLayoutPanel68_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
