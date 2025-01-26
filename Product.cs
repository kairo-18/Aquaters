using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquaters_Capstone_
{
    public partial class Product : Form
    {
        Customer customer;
        PersonalInfo pi;
        DataAccessLayer layer;

        public Product()
        {
            InitializeComponent();
            customer = new Customer();
            pi = new PersonalInfo();
            layer = new DataAccessLayer();

            pi.OnClickHandler += onButtonClick;
        }

        public void onButtonClick()
        {
            customer.addCustomerInfo(pi.txName, pi.txAddress, pi.txContactNo);
            pi.Close();

            layer.AddOrdersToDatabase(customer.orderCount, customer.orders);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pi.Show();
        }

        public void updateTotalPrice()
        {
            lblTotalPrice.Text = customer.totalPrice.ToString();
        }


        private void btn7L_Click(object sender, EventArgs e)
        {
            customer.addToCustomerCart("Purified", "7L Gallon", "Order", 10);
            if (customer.orderCount < 10)
            {
                lbOrders.Text += "Purified, 7L Gallon, Order - 10";
                lbOrders.Text += Environment.NewLine;
                updateTotalPrice();
            }
        }

        private void btn10L_Click(object sender, EventArgs e)
        {
            customer.addToCustomerCart("Purified", "10L Gallon", "Order", 10);
            if (customer.orderCount < 10)
            {
                lbOrders.Text += "Purified, 10L Gallon, Order - 10";
                lbOrders.Text += Environment.NewLine;
                updateTotalPrice();
            }
        }

        private void btnSlim20L_Click(object sender, EventArgs e)
        {
            customer.addToCustomerCart("Purified", "20L Slim Gallon", "Order", 10);

            if (customer.orderCount < 10)
            {
                lbOrders.Text += "Purified, 20L Slim Gallon, Order - 10";
                lbOrders.Text += Environment.NewLine;
                updateTotalPrice();
            }
        }

        private void btnRound20L_Click(object sender, EventArgs e)
        {
            customer.addToCustomerCart("Purified", "20L Round Gallon", "Order", 10);

            if (customer.orderCount < 10)
            {
                lbOrders.Text += "Purified, 20L Round Gallon, Order - 10";
                lbOrders.Text += Environment.NewLine;
                updateTotalPrice();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
