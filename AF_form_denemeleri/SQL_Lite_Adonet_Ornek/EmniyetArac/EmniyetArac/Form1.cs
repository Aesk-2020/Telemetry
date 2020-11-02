using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace EmniyetArac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataGridMatrix[,] gridMatrices = new DataGridMatrix[9, 7];
        string[] Hours = { "09:00","10:00","11:00","12:00","13:00","14:00","15:00","16:00","Mesai Dışı" };

        DateTime tempHaft;
        DateTime pickedDate;

        string KlasorYolu;

        int columnIndex=0;
        int rowIndex=0;

        private void Form1_Load(object sender, EventArgs e)
        {

            ExcelButton.Enabled = false;
            haftExcel.Enabled = false;
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                   
                    gridMatrices[i, j].cells = new List<Cell>() { new Cell() { Vehice=new Vehice() { Id = 0, Plate = "", Station = "" }, isCompleted=false} };
                }
            }

            DataFlow.OpenConnection();
            ResetGridMatrix(ref gridMatrices);
            
            tempHaft = DateTime.Now;
            pickedDate = DateTime.Now;
            datePortionDateTimePicker.Format = DateTimePickerFormat.Custom;
            datePortionDateTimePicker.CustomFormat = "dd MMMM yyyy -dddd";
            timePortionDateTimePicker.Format = DateTimePickerFormat.Time;
            timePortionDateTimePicker.ShowUpDown = true;
            ShowWeek(ref gridMatrices, tempHaft);

        }
        public void ResetGridMatrix(ref DataGridMatrix[,] dataGridMatrices) 
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    dataGridMatrices[i, j].cells.Clear();
                    //dataGridMatrices[i, j].vehices.Add(new Vehice() { Id = 0, Plate = "", Station = "" });
                }
            }

        }

       

        //guncellenen elemanları alcaz buna vercez
        public void ShowWeek(ref DataGridMatrix[,] matrix, DateTime gun)
        {
            tamamlaButton.Enabled = false;
            silButton.Enabled = false;
           
            ComboBoxVehice.SelectedIndex = -1;
            ComboBoxVehice.Items.Clear();
            
            RefleshGrid();
            int a = (gun.DayOfWeek.GetHashCode()+6)%7;
            DateTime Pazartesi = gun.AddDays(- a);
            DateTime Pazar = gun.AddDays((6-a));
            labelHaft.Text = Pazartesi.ToString("dddd, dd MMMM yyyy") +" Olan Hafta";

            List <DetailedPending> detailedPendings = DataFlow.GetDetailed(Pazartesi,Pazar);

            int tempRow = 0;
            int tempColumn =0;  

            ResetGridMatrix(ref gridMatrices);
            foreach (DetailedPending Xdetailed in detailedPendings)
            {
                tempRow = getRowHour(Xdetailed.pending.Date);
                tempColumn = getColumnDay(Xdetailed.pending.Date);
                //xJoin

                gridMatrices[tempRow, tempColumn].cells.Add(new Cell() { Vehice = Xdetailed.vehice, isCompleted = Xdetailed.pending.isCompleted });
            }
         

            for (int i = 0; i < 9; i++)
            {
                var tempString = new string[] {
                    Hours[i],gridMatrices[i, 0].VehicesToSingleString(),gridMatrices[i, 1].VehicesToSingleString(),gridMatrices[i, 2].VehicesToSingleString(),gridMatrices[i, 3].VehicesToSingleString(),
                        gridMatrices[i, 4].VehicesToSingleString(),gridMatrices[i, 5].VehicesToSingleString(),gridMatrices[i, 6].VehicesToSingleString()};
                dataGridView1.Rows.Add(tempString);

            }
        }

        //m 0 t 1 w 2 th 3 fr 4 sat 5 sun 6
        private int getColumnDay(DateTime dateTime)
        {
            return (dateTime.DayOfWeek.GetHashCode()+6) % 7;
        }

        private int getRowHour(DateTime date)
        {
            int a = !(date.Hour > 17||date.Hour<9) ? ((date.Hour + 15)% 24) : 8;
            return a;
        }

        private void RefleshGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            string plaka = textboxInsertPlate.Text;
            string sube = textboxInsertSube.Text;
            
            //o araci ekliyor arac veri tabanina
            //fonkiyon icerisinde kontrolleri var birden fazla eklemiyor
            if(plaka.Length>4 && sube.Length>2) {
                Vehice VehicTemp = new Vehice { Id = 0, Plate = plaka, Station = sube };
                DataFlow.AddVehice(VehicTemp);
                Pending PendingTemp = new Pending { Id = 0, VehiceID = DataFlow.GetVehices(plaka)[0].Id, Date = pickedDate, isCompleted = false };
                DataFlow.AddPending(PendingTemp);
            }


            ShowWeek(ref gridMatrices, tempHaft);

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            tempHaft=tempHaft.AddDays(-7);
            ShowWeek(ref gridMatrices, tempHaft);
        }

        private void Forwardbutton_Click(object sender, EventArgs e)
        {

            tempHaft = tempHaft.AddDays(7);
            ShowWeek(ref gridMatrices, tempHaft);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            pickedDate = datePortionDateTimePicker.Value.Date + timePortionDateTimePicker.Value.TimeOfDay;
            labelSelectedDate.Text = pickedDate.ToString("dddd HH:mm ,dd MMMM");
        }

        private void buttonSeeData_Click(object sender, EventArgs e)
        {
            AllDataAcces x = new AllDataAcces();
            x.Show();
        }

        private void gotoDate_Click(object sender, EventArgs e)
        {
            tempHaft = datePortionDateTimePicker.Value;
            RefleshGrid();
            ShowWeek(ref gridMatrices,tempHaft);
        }
        private void platesearchButton_Click(object sender, EventArgs e)
        {
            string temp = textboxSearchPlate.Text;
            List<Pending> templist = DataFlow.GetPendings(temp);
            RichTextBox1.Text = "";
            if (templist[0].Id==0)
            {
                RichTextBox1.Text += "Boş";
            }
            else
            {
                foreach (Pending i in templist)
                {
                    RichTextBox1.Text += "ID: " + i.Id.ToString() + "><" + i.Date + ">< Durum:" + ((i.isCompleted) ? "Tamamlandi" : "Beklemede")+"\n";
                }
            }

           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Klasor = new FolderBrowserDialog();
            Klasor.ShowDialog();
            KlasorYolu = Klasor.SelectedPath;

            if (KlasorYolu != null && !KlasorYolu.Contains(" ") && KlasorYolu.Length > 3)
            {
                MessageBox.Show(KlasorYolu);
                ExcelButton.Enabled = true;
                haftExcel.Enabled = true;

            }
            else
            {
                MessageBox.Show("Konum Seçiniz");
            }

        }
        private void ExcelButton_Click(object sender, EventArgs e)
        {
           
            string path = KlasorYolu + "\\" + "Yedek" + "_tarih_" + DateTime.Now.ToString("yyyy-MM-dd");

            DataFlow.BackupExcel(path);

            ExcelButton.Enabled = false;
            haftExcel.Enabled = false;
           

        }
        private void haftExcel_Click(object sender, EventArgs e)
        {
            string path = KlasorYolu + "\\" + "Haftalik_Yedek" + "_tarih_" + DateTime.Now.ToString("yyyy-MM-dd");

            int a = (tempHaft.DayOfWeek.GetHashCode() + 6) % 7;
            DateTime Pazartesi = tempHaft.AddDays(-a);
            DateTime Pazar = tempHaft.AddDays((6 - a));

            DataFlow.BackupExcel(path,Pazartesi,Pazar);
            
            ExcelButton.Enabled = false;
            haftExcel.Enabled = false;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ComboBoxVehice.Items.Clear();
            ComboBoxVehice.SelectedIndex = -1;
            ComboBoxVehice.Text = "";

            int a = (tempHaft.DayOfWeek.GetHashCode() + 6) % 7;
            DateTime Pazartesi = tempHaft.AddDays(-a);

            columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            rowIndex = dataGridView1.CurrentCell.RowIndex;

         


            if (!(columnIndex == 0) && (rowIndex < 8))
            {
                pickedDate = Pazartesi.AddDays(columnIndex - 1).Date + DateTime.Parse("09:01").AddHours(rowIndex).TimeOfDay;
                selectedTarihLabel.Text = pickedDate.ToString("dddd HH: mm, dd MMMM");


                foreach (Cell cell in gridMatrices[rowIndex, columnIndex - 1].cells)
                {
                    ComboBoxVehice.Items.Add(((cell.isCompleted) ? "*" : "") + cell.Vehice.Plate + " " + cell.Vehice.Station);
                }

            }
            labelSelectedDate.Text = pickedDate.ToString("dddd HH:mm ,dd MMMM");

        }
        private void tamamlaButton_Click(object sender, EventArgs e)
        {
            if (!(ComboBoxVehice.SelectedIndex<0)) {
                Vehice tempVehice = gridMatrices[rowIndex, columnIndex - 1].cells[ComboBoxVehice.SelectedIndex].Vehice;
                int pendingID = DataFlow.GetPendingID(tempVehice, pickedDate);


                DataFlow.CompletePending(pendingID);
                ShowWeek(ref gridMatrices, pickedDate);

                tamamlaButton.Enabled = false;
                silButton.Enabled = false;
            }
            
        }
        private void silButton_Click(object sender, EventArgs e)
        {
            if (!(ComboBoxVehice.SelectedIndex < 0))
            {
                Vehice tempVehice = gridMatrices[rowIndex, columnIndex - 1].cells[ComboBoxVehice.SelectedIndex].Vehice;
                int pendingID = DataFlow.GetPendingID(tempVehice, pickedDate);
                DataFlow.CompletePending(pendingID);
                DataFlow.DeletePending(pendingID);
                ShowWeek(ref gridMatrices, pickedDate);
                tamamlaButton.Enabled = false;
                silButton.Enabled = false;

            }
                
        }
        private void timePortionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            pickedDate = datePortionDateTimePicker.Value.Date + timePortionDateTimePicker.Value.TimeOfDay;
            labelSelectedDate.Text = pickedDate.ToString("dddd HH: mm, dd MMMM");

        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataFlow.CloseConnection();
           
        }

        private void ComboBoxVehice_SelectedIndexChanged(object sender, EventArgs e)
        {
            tamamlaButton.Enabled = true;
            silButton.Enabled = true;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tek bir bilgisayarda local bir veri tabanında çalışacak şekilde ayarlanmıştır\nGüvenlik nedeniyle yerel dışında kullanmayınız\n-Ahmet Furkan ÜNLÜ, Memur Murat ÜNLÜ'ye");
        }

   
    }
}
