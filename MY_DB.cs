using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace _20110375_HuynhDangKhoa_LoginForm
{
    internal class MY_DB
    {
        public static string instance;
        SqlConnection conn = new SqlConnection(
            @"Data Source=LAPTOP-L5HNLU56\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        
        // get the connection
        public SqlConnection getConnection
        {
            get { return conn; }        
        }

        // open the connection
        public void openConnection()
        {
            if((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }
        }

        // close the connection
        public void closeConnection()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
