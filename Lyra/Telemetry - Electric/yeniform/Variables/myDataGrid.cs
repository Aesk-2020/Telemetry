using System.Drawing;
using System.Windows.Forms;

namespace Telemetri.Variables
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
                d1.Columns[0].Name = "Lap";
                d1.Columns[1].Name = "Sector";
                d1.Columns[2].Name = "SectorTime";
                d1.Columns[3].Name = "Distance(Vcu)";
                d1.Columns[4].Name = "Distance(Gps)";
                d1.Columns[5].Name = "AvgVelocity(Vcu)";
                d1.Columns[6].Name = "AvgVelocity(Gps)";
                d1.Columns[7].Name = "Consumption";

                d1.Columns["Lap"].HeaderText = "LAP";
                d1.Columns["Sector"].HeaderText = "S";
                d1.Columns["SectorTime"].HeaderText = "SECTOR TIME";
                d1.Columns["Distance(Vcu)"].HeaderText = "DISTANCE(VCU)";
                d1.Columns["Distance(Gps)"].HeaderText = "DISTANCE(GPS)";
                d1.Columns["AvgVelocity(Vcu)"].HeaderText = "AVG V(VCU)";
                d1.Columns["AvgVelocity(Gps)"].HeaderText = "AVG V(GPS)";
                d1.Columns["Consumption"].HeaderText = "CONSUMPTION";

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
