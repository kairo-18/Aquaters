using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aquaters_Capstone_;
using Microsoft.VisualBasic;

namespace Aquaters_Capstone_
{
    public partial class Order : Form
    {
        Customer customer;
        DataAccessLayer layer;
        PersonalInfo pi;
        public Order()
        {
            InitializeComponent();
            customer = new Customer();
            layer = new DataAccessLayer();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pi = new PersonalInfo();
            pi.OnClickHandler += onButtonClick;
            pi.Show();

        }

        public void onButtonClick()
        {
            customer.addCustomerInfo(pi.txName, pi.txAddress, pi.txContactNo);
            pi.Close();

            layer.AddOrdersToDatabase(customer.orderCount, customer.orders);
        }

        public void updateTotalPrice()
        {
            lblTotalPriceOrder.Text = customer.totalPrice.ToString();
        }

        private void btn7LOrder_Click(object sender, EventArgs e)
        {
            customer.addToCustomerCart("Purified", "7L Gallon", "Refill", 10);
            if (customer.orderCount < 10)
            {
                lbOrders.Text += "Purified, 7L Gallon, Refill - 10";
                lbOrders.Text += Environment.NewLine;
                updateTotalPrice();
            }
            
        }
        

        private void btn10LOrder_Click(object sender, EventArgs e)
        {
            if (customer.orderCount < 10)
            {
                customer.addToCustomerCart("Purified", "10L Gallon", "Refill", 15);
                lbOrders.Text += "Purified, 10L Gallon, Refill - 15";
                lbOrders.Text += Environment.NewLine;
                updateTotalPrice();
            }
        }

        private void btnSlim20LOrder_Click(object sender, EventArgs e)
        {
            if (customer.orderCount < 10)
            {
                customer.addToCustomerCart("Purified", "20L Slim ", "Refill", 25);
                lbOrders.Text += "Purified, 20L Slim, Refill - 25";
                lbOrders.Text += Environment.NewLine;
                updateTotalPrice();
            }
        }
        private void btnRound20LOrder_Click(object sender, EventArgs e)
        {
            if (customer.orderCount < 10)
            {
                customer.addToCustomerCart("Purified", "20L Round ", "Refill", 30);
                lbOrders.Text += "Purified, 20L Round , Refill - 30";
                lbOrders.Text += Environment.NewLine;
                updateTotalPrice();
            }
        }
    }
}
