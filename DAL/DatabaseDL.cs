using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SQLite;

namespace DAL
{
    public abstract class DatabaseDL
    {
        private static SQLiteConnection sqlCon = new SQLiteConnection();

        public static List<DuLieu> Init()
        {
            string command = "SELECT * FROM DuLieu ORDER BY TenDL";
            Connection.openConnection(sqlCon);
            SQLiteCommand com = new SQLiteCommand(command, sqlCon);
            SQLiteDataReader reader = com.ExecuteReader();

            List<DuLieu> dsDL = new List<DuLieu>();
            while (reader.Read())
            {
                DuLieu dl = new DuLieu(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4));
                dsDL.Add(dl);
            }
            reader.Close();
            Connection.closeConnection(sqlCon);
            return dsDL;
        }

        public static string CreateMaDL()
        {
            string command = "SELECT MaDL FROM DuLieu ORDER BY MaDL";
            Connection.openConnection(sqlCon);
            SQLiteCommand cmd = new SQLiteCommand(command, sqlCon);
            SQLiteDataReader reader = cmd.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                if (i != int.Parse(reader.GetString(0).Substring(4))) break;
                i++;
            }
            reader.Close();
            Connection.closeConnection(sqlCon);

            string result = i.ToString();
            while (result.Length < 4) result = '0' + result;
            return "DL" + result;
        }

        public static void Insert(DuLieu dl)
        {
            string command = string.Format("INSERT INTO DuLieu VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", dl.MaDL, dl.TenDL, dl.DuongDan, dl.DuoiDL, dl.Anh);

            Connection.openConnection(sqlCon);
            SQLiteCommand com = new SQLiteCommand(command, sqlCon);
            com.ExecuteNonQuery();
            Connection.closeConnection(sqlCon);
        }

        public static void Update(DuLieu dl)
        {
            string command = string.Format("UPDATE DuLieu SET TenDL = '{0}', DuongDan = '{1}', DuoiDL = '{2}', " +
                "Anh = '{3}' WHERE MaDL = '{4}'", dl.TenDL, dl.DuongDan, dl.DuoiDL, dl.Anh, dl.MaDL);

            Connection.openConnection(sqlCon);
            SQLiteCommand com = new SQLiteCommand(command, sqlCon);
            com.ExecuteNonQuery();
            Connection.closeConnection(sqlCon);
        }

        public static void Delete(string MaDL)
        {
            string command = string.Format("DELETE FROM DuLieu WHERE MaDL = '{0}'", MaDL);

            Connection.openConnection(sqlCon);
            SQLiteCommand com = new SQLiteCommand(command, sqlCon);
            com.ExecuteNonQuery();
            Connection.closeConnection(sqlCon);
        }

        public static List<DuLieu> Search(string value)
        {
            string command = string.Format("SELECT * FROM DuLieu WHERE TenDL like '%{0}%' ORDER BY TenDL", value);
            Connection.openConnection(sqlCon);
            SQLiteCommand com = new SQLiteCommand(command, sqlCon);
            SQLiteDataReader reader = com.ExecuteReader();

            List<DuLieu> dsDL = new List<DuLieu>();
            while (reader.Read())
            {
                DuLieu dl = new DuLieu(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4));
                dsDL.Add(dl);
            }
            reader.Close();
            Connection.closeConnection(sqlCon);
            return dsDL;
        }
    }
}
