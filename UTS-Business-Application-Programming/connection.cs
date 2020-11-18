using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_Business_Application_Programming
{
    public class Connection
    {

        private string connString = "";

        public Connection()
        {
            connString = @"Data Source = DESKTOP - 43407LQ\SQLEXPRESS; Initial Catalog = kiyo; Integrated Security = True";
        }

        public SqlConnection CreateAndOpenConnection()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }


    }
}