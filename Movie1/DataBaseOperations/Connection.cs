using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie1.DataBaseOperations
{
    public class Connection
    {
        private static SqlConnection con = null;

        private Connection() { }

        //Connection with Database
        public static SqlConnection StartConnection()
        {
            if (con == null)
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-MVFA7CI;Initial Catalog=movie1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
            }

            return con; // if connection object already exists, then return the last connection object
        }

        //Close the Connection 
        public static void DisposeConnection()
        {
            if (con != null)
            {
                con.Dispose();
            }
            con = null;
        }

    }
}
