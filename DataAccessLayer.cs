using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aquaters_Capstone_
{
    internal class DataAccessLayer
    {
        DBConnection conn1 = new DBConnection();
        MySqlDataReader reader;

        public void DisplayDatabaseData(DataGridView dgv)
        {
            conn1.Connect();
            string query = "select * from clientdetails;";
            MySqlCommand command = new MySqlCommand(query, conn1.conn);
            reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dgv.DataSource = dt;

            reader.Dispose();
            reader.Close();
            conn1.Disconnect();
        }

        public void AddOrdersToDatabase(int orderCount, string[,] orders)
        {
            conn1.Connect();

            for (int i = 0; i < orderCount; i++)
            {
                string query = "INSERT INTO `clientdetails` (`Key`, `Name`, `Address`, `Contact Number`, `Type of Water`, `Type of Container`, `Mode of Payment`, `Quantity`, `Price`, `Delivery Status`, `Refill/Order`) VALUES (NULL, '" + orders[i, 0] + "', '" + orders[i, 1] + "', '" + orders[i, 2] + "' , '" + orders[i, 3] + "', '" + orders[i, 4] + "', '" + orders[i, 5] + "', '" + orders[i, 6] + "', '" + orders[i, 7] + "', '" + orders[i,8] + "', '" + orders[i, 9] + "');";

                MessageBox.Show(query);
                MySqlCommand insertTable = new MySqlCommand(query, conn1.conn);
                
                
                insertTable.ExecuteNonQuery();

            }

            conn1.Disconnect();
        }
    }
}
