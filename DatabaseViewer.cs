using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquaters_Capstone_
{
    public partial class DatabaseViewer : Form
    {
        DBConnection conn2;
        DataAccessLayer dal2;
        public DatabaseViewer()
        {
            InitializeComponent();
            conn2 = new DBConnection();
            dal2 = new DataAccessLayer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatabaseViewer_Load(object sender, EventArgs e)
        {
            conn2.Connect();
            dal2.DisplayDatabaseData(dataGridView1);
            conn2.Disconnect();
        }
    }
}
