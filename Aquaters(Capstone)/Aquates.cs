using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquaters_Capstone_
{
    public partial class Aquaters : Form
    {
        public static Panel _pnMain;
        public Aquaters()
        {
            InitializeComponent();
            _pnMain = pnMain;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsgm, int wParam, int lParam);
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.TopLevel = false;
            pnMain.Controls.Add(order);
            order.BringToFront();
            order.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.TopLevel = false;
            pnMain.Controls.Add(prod);
            prod.BringToFront();
            prod.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
