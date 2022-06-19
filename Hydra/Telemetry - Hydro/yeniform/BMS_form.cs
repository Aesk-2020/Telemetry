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
using System.Timers;
using Telemetri.Variables;
using telemetry_hydro.Variables;
namespace telemetry_hydro
{
    public partial class BMS_form : Form
    {

        public static List<PictureBox> cellPictureBoxes = new List<PictureBox>();
        public static List<Label> cellVoltLabels = new List<Label>();
        public static List<Label> cellTempLabels = new List<Label>();
        public static System.Timers.Timer updateForm = new System.Timers.Timer(1000);

        public BMS_form()
        {
            InitializeComponent();
            #region InitCellsAndTimer
            cellPictureBoxes.Add(cell1PictureBox);
            cellPictureBoxes.Add(cell2PictureBox);
            cellPictureBoxes.Add(cell3PictureBox);
            cellPictureBoxes.Add(cell4PictureBox);
            cellPictureBoxes.Add(cell5PictureBox);
            cellPictureBoxes.Add(cell6PictureBox);
            cellPictureBoxes.Add(cell7PictureBox);
            cellPictureBoxes.Add(cell8PictureBox);
            cellPictureBoxes.Add(cell9PictureBox);
            cellPictureBoxes.Add(cell10PictureBox);
            cellPictureBoxes.Add(cell11PictureBox);
            cellPictureBoxes.Add(cell12PictureBox);
            cellPictureBoxes.Add(cell13PictureBox);
            cellPictureBoxes.Add(cell14PictureBox);
            cellPictureBoxes.Add(cell15PictureBox);
            cellPictureBoxes.Add(cell16PictureBox);
            cellPictureBoxes.Add(cell17PictureBox);
            cellPictureBoxes.Add(cell18PictureBox);
            cellPictureBoxes.Add(cell19PictureBox);
            cellPictureBoxes.Add(cell20PictureBox);
            cellPictureBoxes.Add(cell21PictureBox);
            cellPictureBoxes.Add(cell22PictureBox);
            cellPictureBoxes.Add(cell23PictureBox);
            cellPictureBoxes.Add(cell24PictureBox);
            cellPictureBoxes.Add(cell25PictureBox);
            cellPictureBoxes.Add(cell26PictureBox);
            cellPictureBoxes.Add(cell27PictureBox);
            cellPictureBoxes.Add(cell28PictureBox);

            cellTempLabels.Add(cell1TempBox);
            cellTempLabels.Add(cell2TempBox);
            cellTempLabels.Add(cell3TempBox);
            cellTempLabels.Add(cell4TempBox);
            cellTempLabels.Add(cell5TempBox);
            cellTempLabels.Add(cell6TempBox);
            cellTempLabels.Add(cell7TempBox);
            cellTempLabels.Add(cell8TempBox);
            cellTempLabels.Add(cell9TempBox);
            cellTempLabels.Add(cell10TempBox);
            cellTempLabels.Add(cell11TempBox);
            cellTempLabels.Add(cell12TempBox);
            cellTempLabels.Add(cell13TempBox);
            cellTempLabels.Add(cell14TempBox);
            cellTempLabels.Add(cell15TempBox);
            cellTempLabels.Add(cell16TempBox);
            cellTempLabels.Add(cell17TempBox);
            cellTempLabels.Add(cell18TempBox);
            cellTempLabels.Add(cell19TempBox);
            cellTempLabels.Add(cell20TempBox);
            cellTempLabels.Add(cell21TempBox);
            cellTempLabels.Add(cell22TempBox);
            cellTempLabels.Add(cell23TempBox);
            cellTempLabels.Add(cell24TempBox);
            cellTempLabels.Add(cell25TempBox);
            cellTempLabels.Add(cell26TempBox);
            cellTempLabels.Add(cell27TempBox);
            cellTempLabels.Add(cell28TempBox);

            cellVoltLabels.Add(cell1VoltBox);
            cellVoltLabels.Add(cell2VoltBox);
            cellVoltLabels.Add(cell3VoltBox);
            cellVoltLabels.Add(cell4VoltBox);
            cellVoltLabels.Add(cell5VoltBox);
            cellVoltLabels.Add(cell6VoltBox);
            cellVoltLabels.Add(cell7VoltBox);
            cellVoltLabels.Add(cell8VoltBox);
            cellVoltLabels.Add(cell9VoltBox);
            cellVoltLabels.Add(cell10VoltBox);
            cellVoltLabels.Add(cell11VoltBox);
            cellVoltLabels.Add(cell12VoltBox);
            cellVoltLabels.Add(cell13VoltBox);
            cellVoltLabels.Add(cell14VoltBox);
            cellVoltLabels.Add(cell15VoltBox);
            cellVoltLabels.Add(cell16VoltBox);
            cellVoltLabels.Add(cell17VoltBox);
            cellVoltLabels.Add(cell18VoltBox);
            cellVoltLabels.Add(cell19VoltBox);
            cellVoltLabels.Add(cell20VoltBox);
            cellVoltLabels.Add(cell21VoltBox);
            cellVoltLabels.Add(cell22VoltBox);
            cellVoltLabels.Add(cell23VoltBox);
            cellVoltLabels.Add(cell24VoltBox);
            cellVoltLabels.Add(cell25VoltBox);
            cellVoltLabels.Add(cell26VoltBox);
            cellVoltLabels.Add(cell27VoltBox);
            cellVoltLabels.Add(cell28VoltBox);

            updateForm.Elapsed += UpdateForm_Elapsed;
            #endregion
        }

        private void UpdateForm_Elapsed(object sender, ElapsedEventArgs e)
        {
            DisplayAll();
        }

        private void DisplayAll()
        {
            for (int i = 0; i < 28; i++)
            {
                if(DataBMS.cells[i].actVoltage >= 4.0)
                {
                    cellPictureBoxes[i].Image = cell_images.Images[4];
                }
                else if (DataBMS.cells[i].actVoltage < 4.0 && DataBMS.cells[i].actVoltage >= 3.75)
                {
                    cellPictureBoxes[i].Image = cell_images.Images[3];
                }
                else if (DataBMS.cells[i].actVoltage < 3.75 && DataBMS.cells[i].actVoltage >= 3.2)
                {
                    cellPictureBoxes[i].Image = cell_images.Images[2];
                }
                else if (DataBMS.cells[i].actVoltage < 3.2 && DataBMS.cells[i].actVoltage >= 2.5)
                {
                    cellPictureBoxes[i].Image = cell_images.Images[1];
                }
                else
                {
                    cellPictureBoxes[i].Image = cell_images.Images[0];
                }
                cellVoltLabels[i].Text = DataBMS.cells[i].actVoltage.ToString("0.000");
                cellTempLabels[i].Text = DataBMS.cells[i].temperature_u8.ToString();
            }
            /*
            for (int i = 0; i < 16; i++)
            {
                bmsUI.voltageLabelsArray[i].Text = Convert.ToString(BMS.bms_cells[i]);
            }

            charge_state.BackColor = BMS.charging_u1 ? MACROS.AeskBlue : Color.Red;
            max_cell_temp.Text = BMS.temp_u8.ToString();
            SoC.Text = BMS.soc_f32.ToString();
            */
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telemetry.bmsForm.Hide();
        }
    }
}
