using System.Drawing;
using System.Windows.Forms;

namespace telemetry_hydro.Variables
{
    public class myDataGrid
    {
        private string _carName;
        private DataGridView _d1;
        private Font font = new Font("Century Gothic", 12, FontStyle.Bold);
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
            if (_carName == "HYDRA")
            {
                d1.ColumnCount = 7;
                d1.Columns[0].Name = "Tur"; //tur numarası (kaçıncı tur bu)
                d1.Columns[1].Name = "Sure";
                d1.Columns[2].Name = "OrtalamaHiz";
                d1.Columns[3].Name = "MaksHiz";
                d1.Columns[4].Name = "OutCons";
                d1.Columns[5].Name = "OrtHizHesap";
                d1.Columns[6].Name = "GerekenOrtHız";

                d1.Columns["Tur"].HeaderText            = "TUR";
                d1.Columns["Sure"].HeaderText           = "SÜRE";
                d1.Columns["OrtalamaHiz"].HeaderText    = "ORT HIZ";
                d1.Columns["MaksHiz"].HeaderText        = "MAKS HIZ";
                d1.Columns["OutCons"].HeaderText        = "OUT CONS";
                d1.Columns["OrtHizHesap"].HeaderText    = "ORT HIZ(SÜRE/PİST)";
                d1.Columns["GerekenOrtHız"].HeaderText  = "Gereken Ortalama Hız";


                d1.Columns[0].Width = 60;
                d1.Columns[1].Width = 120;
                d1.Columns[2].Width = 120;
                d1.Columns[3].Width = 120;
                d1.Columns[4].Width = 120;
                d1.Columns[5].Width = 180;
                d1.Columns[6].Width = 200;
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
