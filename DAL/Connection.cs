using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DAL
{
    public class Connection
    {
        internal static void openConnection(SQLiteConnection con)
        {
            con.ConnectionString = "Data Source=launcher.db;Version=3;";
            con.Open();
        }

        internal static void closeConnection(SQLiteConnection con)
        {
            con.Close();
        }
    }
}
