using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HiTechLibrary.DAL
{
    public class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            //Making a Connection to the DataBase
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            conn.Open();

            return conn;
        }
    }
}
