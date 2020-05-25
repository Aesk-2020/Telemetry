using System.Drawing;
using System.Windows.Forms;

namespace telemetry_hydro.Variables
{
    public class myDataGrid
    {
        private string _carName;
        private DataGridView _d1;
        private Font font = new Font("Calibri", 16, FontStyle.Bold);
        public myDataGrid(string carName)
        {
            _carName = carName;
            _carName = _carName.ToUpper();
        }

        public void InitDataGrid(DataGridView d1)
        {
            _d1 = d1;
            d1.Font = font;
            d1.DefaultCellStyle.Font = font;
            d1.AlternatingRowsDefaultCellStyle.Font = font;
            d1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (_carName == "LYRA")
            {
                d1.ColumnCount = 8;
                d1.Columns[0].Name = "Tur";
                d1.Columns[1].Name = "Sektör";
                d1.Columns[2].Name = "SektörSüre";
                d1.Columns[3].Name = "Yol(Vcu)";
                d1.Columns[4].Name = "Yol(Gps)";
                d1.Columns[5].Name = "OrtalamaHiz(Vcu)";
                d1.Columns[6].Name = "OrtalamaHiz(Gps)";
                d1.Columns[7].Name = "Tuketim";

                d1.Columns["Tur"].HeaderText = "TUR";
                d1.Columns["Sektör"].HeaderText = "S";
                d1.Columns["SektörSüre"].HeaderText = "SEKTÖR SÜRE";
                d1.Columns["Yol(Vcu)"].HeaderText = "YOL(VCU)";
                d1.Columns["Yol(Gps)"].HeaderText = "YOL(GPS)";
                d1.Columns["OrtalamaHiz(Vcu)"].HeaderText = "ORT HIZ(VCU)";
                d1.Columns["OrtalamaHiz(Gps)"].HeaderText = "ORT HIZ(GPS)";
                d1.Columns["Tuketim"].HeaderText = "TÜKETİM";

                d1.Columns[0].Width = 50;
                d1.Columns[1].Width = 50;
                d1.Columns[2].Width = 120;
                d1.Columns[3].Width = 120;
                d1.Columns[4].Width = 120;
                d1.Columns[5].Width = 110;
                d1.Columns[6].Width = 110;
                d1.Columns[7].Width = 110;
            }
        }

        public void addGrid(object[] datas)
        {
            if (_d1.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    addGrid(datas);
                };
                _d1.Invoke(del);
                return;
            }
            
            _d1.Rows.Add(datas);
            
        }

    }
}
