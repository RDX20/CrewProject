using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class Connect
    {
        private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=crewproject");

        public MySqlConnection GetConnection()
        {
            return conn;

        }

        public void openConn()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

}
