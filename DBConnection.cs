using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aquaters_Capstone_
{
    internal class DBConnection
    {
        string connectionString = "server = 127.0.0.1; port = 3306; uid = root; pwd = ; database = clients;";

        public MySqlConnection conn;

        public void Connect()
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Disconnect()
        {
            conn.Dispose();
            conn.Close();
        }
    }
}
