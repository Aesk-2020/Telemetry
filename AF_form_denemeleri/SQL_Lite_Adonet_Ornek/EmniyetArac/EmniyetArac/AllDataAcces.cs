using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmniyetArac
{
    public partial class AllDataAcces : Form
    {
        public AllDataAcces()
        {
            InitializeComponent();
        }

        List<Vehice> AllVehices = new List<Vehice>();
        List<Pending> AllPendings = new List<Pending>();

        private void AllDataAcces_Load(object sender, EventArgs e)
        {
            AllVehices.Clear();
            AllPendings.Clear();

            AllVehices = DataFlow.GetVehices();
            AllPendings = DataFlow.GetPendings();


            foreach(Vehice it in AllVehices)
            {
                var tempString = new string[]
                {
                    it.Id.ToString(),
                    it.Plate,
                    it.Station
                };
                dataGridViewVehice.Rows.Add(tempString);
            }

            foreach (Pending it in AllPendings)
            {
                var tempString = new string[]
                {
                    it.Id.ToString(),
                    it.VehiceID.ToString(),
                    it.Date.ToString("dd/MM/yyyy HH:mm"),
                    (it.isCompleted)?"Tamamlandi":"Beklemede"
                    
                };
                dataGridViewPendings.Rows.Add(tempString);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewPendings.Rows.Clear();
            dataGridViewVehice.Rows.Clear();


            AllVehices.Clear();
            AllPendings.Clear();

            AllVehices = DataFlow.GetVehices();
            AllPendings = DataFlow.GetPendings();

            foreach (Vehice it in AllVehices)
            {
                var tempString = new string[]
                {
                    it.Id.ToString(),
                    it.Plate,
                    it.Station
                };
                dataGridViewVehice.Rows.Add(tempString);
            }

            foreach (Pending it in AllPendings)
            {
                var tempString = new string[]
                {
                    it.Id.ToString(),
                    it.VehiceID.ToString(),
                    it.Date.ToString("dd/MM/yyyy HH:mm"),
                    (it.isCompleted)?"Tamamlandi":"Beklemede"

                };
                dataGridViewPendings.Rows.Add(tempString);
            }


        }

        private void buttonDeleteVehice_Click(object sender, EventArgs e)
        {
          

        }

        private void buttonDeletePending_Click(object sender, EventArgs e)
        {

        }
    }
}
