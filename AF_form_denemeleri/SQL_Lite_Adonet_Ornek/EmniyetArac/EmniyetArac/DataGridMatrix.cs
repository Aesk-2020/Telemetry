using System;
using System.Collections.Generic;


namespace EmniyetArac
{
    public struct DataGridMatrix
    {
       public DataGridMatrix(List<Cell> Cells)
        {
            this.cells = Cells;
        }
        public List<Cell> cells { get; set; }
      public string VehicesToSingleString()
        {
            string _temp = "";
            if (cells.Count < 1)
            {
                return "";
            }
            foreach(Cell cell in cells)
            {
                _temp += "\n" + ((cell.isCompleted) ? "*" : "") +cell.Vehice.Plate +" " +cell.Vehice.Station;
            }
            return _temp;
        }
 
    }
    
}
