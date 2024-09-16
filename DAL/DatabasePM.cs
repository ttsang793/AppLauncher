using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SQLite;

namespace DAL
{
    public abstract class DatabasePM
    {
        private static SQLiteConnection sqlCon = new SQLiteConnection();

        public static List<PhanMem> Init()
        {
            string command = "SELECT * FROM PhanMem ORDER BY TenPM";
            Connection.openConnection(sqlCon);
            SQLiteCommand com = new SQLiteCommand(command, sqlCon);
            SQLiteDataReader reader = com.ExecuteReader();

            List<PhanMem> dsPM = new List<PhanMem>();
            while (reader.Read())
            {
                PhanMem pm = new PhanMem(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3));
                dsPM.Add(pm);
            }
            reader.Close();
            Connection.closeConnection(sqlCon);
            return dsPM;
        }

        public static string CreateMaPM()
        {
            string command = "SELECT MaPM FROM PhanMem ORDER BY MaPM";
            Connection.openConnection(sqlCon);
            SQLiteCommand cmd = new SQLiteCommand(command, sqlCon);
            SQLiteDataReader reader = cmd.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                if (i != int.Parse(reader.GetString(0).Substring(2))) break;
                i++;
            }
            reader.Close();
            Connection.closeConnection(sqlCon);

            string result = i.ToString();
            while (result.Length < 4) result = '0' + result;
            return "PM" + result;
        }        

        public static void Insert(PhanMem pm)
        {
            string command = string.Format("INSERT INTO PhanMem VALUES ('{0}', '{1}', '{2}', '{3}')", pm.MaPM, pm.TenPM, pm.DuongDan, pm.Anh);
            Connection.openConnection(sqlCon);
            SQLiteCommand com = new SQLiteCommand(command, sqlCon);
            com.ExecuteNonQuery();
            Connection.closeConnection(sqlCon);
        }

        public static void Update(PhanMem pm)
        {
            string command = string.Format("UPDATE PhanMem SET TenPM = '{0}', DuongDan = '{1}', " +
                "Anh = '{2}' WHERE MaPM = '{3}'", pm.TenPM, pm.DuongDan, pm.Anh, pm.MaPM);

            Connection.openConnection(sqlCon);
            SQLiteCommand cmd = new SQLiteCommand(command, sqlCon);
            cmd.ExecuteNonQuery();
            Connection.closeConnection(sqlCon);
        }

        public static void Delete(string MaPM)
        {
            string command = string.Format("DELETE FROM PhanMem WHERE MaPM = '{0}'", MaPM);

            Connection.openConnection(sqlCon);
            SQLiteCommand cmd = new SQLiteCommand(command, sqlCon);
            cmd.ExecuteNonQuery();
            Connection.closeConnection(sqlCon);
        }

        public static List<PhanMem> Search(string value)
        {
            string command = string.Format("SELECT * FROM PhanMem WHERE TenPM LIKE '%{0}%' ORDER BY TenPM", value);
            Connection.openConnection(sqlCon);
            SQLiteCommand com = new SQLiteCommand(command, sqlCon);
            SQLiteDataReader reader = com.ExecuteReader();

            List<PhanMem> dsPM = new List<PhanMem>();
            while (reader.Read())
            {
                PhanMem pm = new PhanMem(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3));
                dsPM.Add(pm);
            }
            reader.Close();
            Connection.closeConnection(sqlCon);
            return dsPM;
        }
    }
}
