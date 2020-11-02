using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace EmniyetArac
{
    public static class DataFlow
    {

        static SQLiteConnection _connection = new SQLiteConnection("Data source =.\\MainDB.db; Version=3;");


        public static void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Close();
            }
            _connection.Open();
        }
        public static void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }

        private static void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public static void BackupExcel(string path)
        {
            string sqlCommand = "SELECT Pendings.Id As PendingID, Pendings.VehiceID as PVehiceID,Pendings.Date as PDate, Pendings.isCompleted as Completed, Vehices.Id as VID,Vehices.Plate as VPlate, Vehices.Station as VStation FROM Pendings JOIN Vehices ON Pendings.VehiceID = Vehices.Id ";
            int i = 2;
            try
            {
                ConnectionControl();
                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    Marshal.ReleaseComObject(xlApp);
                }
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "ID";
                xlWorkSheet.Cells[1, 2] = "Plaka";
                xlWorkSheet.Cells[1, 3] = "Sube";
                xlWorkSheet.Cells[1, 4] = "Tarih";
                xlWorkSheet.Cells[1, 5] = "Durum";


                SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);
                SQLiteDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    xlWorkSheet.Cells[i, 1] = Convert.ToInt32(reader["PendingID"]).ToString();
                    xlWorkSheet.Cells[i, 2] = reader["VPlate"].ToString();
                    xlWorkSheet.Cells[i, 3] = reader["VStation"].ToString();
                    xlWorkSheet.Cells[i, 4] = Convert.ToInt32(reader["PVehiceID"]);
                    xlWorkSheet.Cells[i, 5] = ((Convert.ToInt32(reader["Completed"])) == 1) ? "***" : " ";
                    i++;
                }
                reader.Close();
                _connection.Close();
                xlWorkBook.SaveAs(path + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
            catch (Exception e)
            {

            }
        }
        public static void BackupExcel(string path,DateTime k, DateTime b)
        {
            string StempK = k.ToString("yyyy-MM-dd HH:mm");
            string StempB = b.ToString("yyyy-MM-dd HH:mm");
            string sqlCommand = "SELECT Pendings.Id As PendingID, Pendings.VehiceID as PVehiceID,Pendings.Date as PDate, Pendings.isCompleted as Completed, Vehices.Id as VID,Vehices.Plate as VPlate, Vehices.Station as VStation FROM Pendings JOIN Vehices ON Pendings.VehiceID = Vehices.Id " + " WHERE Date BETWEEN '" + StempK + "' and '" + StempB + "'";
            int i = 2;

            try {
                ConnectionControl();
                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                Marshal.ReleaseComObject(xlApp);
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Plaka";
            xlWorkSheet.Cells[1, 3] = "Sube";
            xlWorkSheet.Cells[1, 4] = "Tarih";
            xlWorkSheet.Cells[1, 5] = "Durum";
       
            
            SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);
            SQLiteDataReader reader = command.ExecuteReader();

            
            while (reader.Read())
            {
                xlWorkSheet.Cells[i, 1] = Convert.ToInt32(reader["PendingID"]).ToString();
                xlWorkSheet.Cells[i, 2] = reader["VPlate"].ToString();
                xlWorkSheet.Cells[i, 3] = reader["VStation"].ToString();
                xlWorkSheet.Cells[i, 4] = Convert.ToInt32(reader["PVehiceID"]);
                xlWorkSheet.Cells[i, 5] = ((Convert.ToInt32(reader["Completed"])) == 1) ? "***" : " ";
                i++;
            }
            reader.Close();
            _connection.Close();
            xlWorkBook.SaveAs(path + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            }
            catch(Exception e)
            {

            }
        }

        #region Pending
        public static void AddPending(Pending product)
        {
            ConnectionControl();

            SQLiteCommand command = new SQLiteCommand("Insert into Pendings values(NULL,@VehiceID,@Date,@isCompleted)", _connection);
            command.Parameters.AddWithValue("@VehiceID", product.VehiceID);
            command.Parameters.AddWithValue("@Date", product.Date);
            command.Parameters.AddWithValue("@isCompleted", 0);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public static void DeletePending(int id)
        {

            ConnectionControl();
            SQLiteCommand command = new SQLiteCommand(
                "Delete from Pendings where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public static void CompletePending(int id)
        {
            ConnectionControl();
            SQLiteCommand command = new SQLiteCommand("Update Pendings set isCompleted=@isCompleted WHERE Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@isCompleted", 1);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public static List<Pending> GetPendings()
        {
            ConnectionControl();
            SQLiteCommand command = new SQLiteCommand("Select * from Pendings", _connection);

            SQLiteDataReader reader = command.ExecuteReader();
            List<Pending> pendings = new List<Pending>();
            while (reader.Read())
            {
                Pending temp = new Pending
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    VehiceID = Convert.ToInt32(reader["VehiceID"]),
                    Date = (DateTime)Convert.ToDateTime(reader["Date"]),
                    isCompleted = ((Convert.ToInt32(reader["isCompleted"])) == 1),

                };
                pendings.Add(temp);
            }

            reader.Close();
            _connection.Close();
            return pendings;
        }
        
        public static List<Pending> GetPendings(string plate)
        {


            if (GetVehices(plate).Count < 1)
            {
                List<Pending> tempList = new List<Pending>() { new Pending() { Id = 0, Date = DateTime.Now, VehiceID = 0, isCompleted = false } };
                return tempList;
            }
            string sqlCommand = "Select * from Pendings WHERE VehiceID =" + GetVehices(plate)[0].Id.ToString();
            ConnectionControl();
            SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<Pending> pendings = new List<Pending>();

            while (reader.Read())
            {
                Pending temp = new Pending
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    VehiceID = Convert.ToInt32(reader["VehiceID"]),
                    Date = (DateTime)Convert.ToDateTime(reader["Date"]),
                    isCompleted = ((Convert.ToInt32(reader["isCompleted"])) == 1),

                };
                pendings.Add(temp);
            }
            reader.Close();
            _connection.Close();
            return pendings;
        }
        public static List<Pending> GetPendings(DateTime k, DateTime b)
        {
            ConnectionControl();
            //yyyy-MM-dd HH:mm:ss

            string StempK = k.ToString("yyyy-MM-dd HH:mm");
            string StempB = b.ToString("yyyy-MM-dd HH:mm");

            string sqlCommand = "Select * from Pendings WHERE Date BETWEEN '" + StempK + "' and '" + StempB + "'";

            SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<Pending> pendings = new List<Pending>();

            while (reader.Read())
            {
                Pending temp = new Pending
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    VehiceID = Convert.ToInt32(reader["VehiceID"]),
                    Date = (DateTime)Convert.ToDateTime(reader["Date"]),
                    isCompleted = ((Convert.ToInt32(reader["isCompleted"])) == 1),

                };
                pendings.Add(temp);

            }


            reader.Close();
            _connection.Close();
            return pendings;
        }

        public static int GetPendingID(Vehice vehice, DateTime date)
        {

            ConnectionControl();
            //yyyy-MM-dd HH:mm:ss
            string StempK = date.AddDays(-0.2).ToString("yyyy-MM-dd HH:mm");
            string StempB = date.AddDays(0.2).ToString("yyyy-MM-dd HH:mm");

            //bokluk burada
            string sqlCommand = "Select * from Pendings WHERE VehiceID=" + vehice.Id.ToString() + " AND " + " Date BETWEEN '" + StempK + "' and '" + StempB + "'";

            SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<Pending> pendings = new List<Pending>();

            while (reader.Read())
            {
                Pending temp = new Pending
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    VehiceID = Convert.ToInt32(reader["VehiceID"]),
                    Date = (DateTime)Convert.ToDateTime(reader["Date"]),
                    isCompleted = ((Convert.ToInt32(reader["isCompleted"])) == 1),

                };
                pendings.Add(temp);

            }
            reader.Close();
            _connection.Close();


            return pendings[0].Id;

        }

        #endregion

        #region Vehice
        public static void AddVehice(Vehice product)
        {
            ConnectionControl();
            List<Vehice> temp = GetVehices(product.Plate);

            if (temp.Count < 1)
            {

                SQLiteCommand command = new SQLiteCommand("Insert into Vehices values(NULL,@Plate,@Station)", _connection);
                command.Parameters.AddWithValue("@Plate", product.Plate);
                command.Parameters.AddWithValue("@Station", product.Station);
                _connection.Open();
                command.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public static void UpdateVehice(Vehice product)
        {

            ConnectionControl();
            SQLiteCommand command = new SQLiteCommand(
                "Update Vehices set Plate=@Plate, Station=@Station where Id=@Id", _connection);

            command.Parameters.AddWithValue("@Id", product.Id);
            command.Parameters.AddWithValue("@Plate", product.Plate);
            command.Parameters.AddWithValue("@Station", product.Station);

            _connection.Close();

        }
        public static void DeleteVehice(int id)
        {

            ConnectionControl();
            SQLiteCommand command = new SQLiteCommand(
                "Delete from Vehices where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public static List<Vehice> GetVehices()
        {
            ConnectionControl();

            //komutu yazmak
            SQLiteCommand command = new SQLiteCommand("Select * from Vehices", _connection);

            //komutu execute sonra biseye atamak
            SQLiteDataReader reader = command.ExecuteReader();

            List<Vehice> vehicess = new List<Vehice>();

            //kayit okudugu surece donguyu calistir
            while (reader.Read())
            {
                Vehice vehice = new Vehice
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Plate = reader["Plate"].ToString(),
                    Station = reader["Station"].ToString(),

                };
                vehicess.Add(vehice);
            }

            reader.Close();
            _connection.Close();
            return vehicess;
        }


        public static List<Vehice> GetVehices(string Plate)
        {
            ConnectionControl();
            string sqlCommand = "Select * from Vehices where Plate=" + "'" + Plate + "'";
            //komutu yazmak
            SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);

            //komutu execute sonra biseye atamak
            SQLiteDataReader reader = command.ExecuteReader();

            List<Vehice> vehicess = new List<Vehice>();

            //kayit okudugu surece donguyu calistir
            while (reader.Read())
            {
                Vehice vehice = new Vehice
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Plate = reader["Plate"].ToString(),
                    Station = reader["Station"].ToString(),

                };
                vehicess.Add(vehice);
            }

            reader.Close();
            _connection.Close();
            return vehicess;
        }

        public static List<DetailedPending> GetDetailed()
        {

            ConnectionControl();


            string sqlCommand = "SELECT Pendings.Id As PendingID, Pendings.VehiceID as PVehiceID,Pendings.Date as PDate, Pendings.isCompleted as Completed, Vehices.Id as VID,Vehices.Plate as VPlate, Vehices.Station as VStation FROM Pendings JOIN Vehices ON Pendings.VehiceID = Vehices.Id ";

            //komutu yazmak
            SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);

            //komutu execute sonra biseye atamak
            SQLiteDataReader reader = command.ExecuteReader();

            List<DetailedPending> detailedPendings = new List<DetailedPending>();

            //kayit okudugu surece donguyu calistir
            while (reader.Read())
            {
                DetailedPending detailed = new DetailedPending
                {
                    pending = new Pending() { Id = Convert.ToInt32(reader["PendingID"]), Date = (DateTime)Convert.ToDateTime(reader["PDate"]), isCompleted = ((Convert.ToInt32(reader["Completed"])) == 1), VehiceID = Convert.ToInt32(reader["PVehiceID"]) },
                    vehice = new Vehice() { Id = Convert.ToInt32(reader["VID"]), Plate = reader["VPlate"].ToString(), Station = reader["VStation"].ToString() }
                };
                detailedPendings.Add(detailed);
            }

            reader.Close();
            _connection.Close();
            return detailedPendings;
        }
        public static List<DetailedPending> GetDetailed(DateTime k,DateTime b)
        {
            string StempK = k.ToString("yyyy-MM-dd HH:mm");
            string StempB = b.ToString("yyyy-MM-dd HH:mm");
            ConnectionControl();
            string sqlCommand = "SELECT Pendings.Id As PendingID, Pendings.VehiceID as PVehiceID,Pendings.Date as PDate, Pendings.isCompleted as Completed, Vehices.Id as VID,Vehices.Plate as VPlate, Vehices.Station as VStation FROM Pendings JOIN Vehices ON Pendings.VehiceID = Vehices.Id " + " WHERE Date BETWEEN '" + StempK + "' and '" + StempB + "'";

            //komutu yazmak
            SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);

            //komutu execute sonra biseye atamak
            SQLiteDataReader reader = command.ExecuteReader();

            List<DetailedPending> detailedPendings = new List<DetailedPending>();

            //kayit okudugu surece donguyu calistir
            while (reader.Read())
            {
                DetailedPending detailed = new DetailedPending
                {
                    pending = new Pending() { Id = Convert.ToInt32(reader["PendingID"]), Date = (DateTime)Convert.ToDateTime(reader["PDate"]), isCompleted = ((Convert.ToInt32(reader["Completed"])) == 1), VehiceID = Convert.ToInt32(reader["PVehiceID"]) },
                    vehice = new Vehice() { Id = Convert.ToInt32(reader["VID"]), Plate = reader["VPlate"].ToString(), Station = reader["VStation"].ToString() }
                };
                detailedPendings.Add(detailed);
            }

            reader.Close();
            _connection.Close();
            return detailedPendings;
        }

        public static List<Vehice> GetVehices(int id)
        {
            ConnectionControl();
            string sqlCommand = "Select * from Vehices where Id=" + id.ToString();
            //komutu yazmak
            SQLiteCommand command = new SQLiteCommand(sqlCommand, _connection);

            //komutu execute sonra biseye atamak
            SQLiteDataReader reader = command.ExecuteReader();

            List<Vehice> vehicess = new List<Vehice>();

            //kayit okudugu surece donguyu calistir
            while (reader.Read())
            {
                Vehice vehice = new Vehice
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Plate = reader["Plate"].ToString(),
                    Station = reader["Station"].ToString(),

                };
                vehicess.Add(vehice);
            }

            reader.Close();
            _connection.Close();
            return vehicess;
        }
        #endregion


    

    }
}
