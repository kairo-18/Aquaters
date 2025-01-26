using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Aquaters_Capstone_
{
    internal class Customer
    {
        public int orderCount { get; private set; }
        public string[,] orders { get; private set; } = new string[10, 10];
        public int totalPrice { get; private set; }
        
        public void addToCustomerCart(string typeOfWater, string typeOfContainer, string typeOfOrder, int price)
        {
        
            if (orderCount == 10)
            {
                MessageBox.Show("Maximum of 10 orders");
            }else
            {
                orders[orderCount, 3] = typeOfWater;
                orders[orderCount, 4] = typeOfContainer;
                orders[orderCount, 9] = typeOfOrder;
                totalPrice += price;
                orders[orderCount, 7] = totalPrice.ToString();
                orderCount++;
            }
            
        }

        public void addCustomerInfo(TextBox txName, TextBox txAddress, TextBox txContactNumber)
        {
            for (int i = 0; i < orderCount; i++)
            {
                orders[i, 0] = txName.Text;
                orders[i, 1] = txAddress.Text;
                orders[i, 2] = txContactNumber.Text;
            }

        }
        
    }
}
