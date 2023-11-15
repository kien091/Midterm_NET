using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car_System.Db
{
    internal class DbConnection
    {
        static SqlConnection conn;
        public static SqlConnection GetConnection()
        {
            if(conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Server"] = "LAPTOP-RR1781P4\\SQLEXPRESS";
                builder["integrated Security"] = true;
                builder["Initial Catalog"] = "RentalCarDb";
                builder.UserID = "LAPTOP-RR1781P4\\SQLEXPRESS";
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
            }
            return conn;
        }
    }
}
