using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForms
{
    public partial class CoffeShopForm : Form
    {
        public CoffeShopForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string customerName = CustomerNameTextBox.Text;
            string customerNumber = ContactNumberTextBox.Text;
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            int quantity = Int32.Parse(quantityTextBox.Text);
            int totalPrice = 0;
            if (order == "") 
            {
                MessageBox.Show("Select a Product");
            }
            else if (order == "Black")
            {
                Int32 blackPriceRate = 120;
                totalPrice = quantity * blackPriceRate;
            }
            else if (order == "Cold")
            {
                Int32 coldPriceRate = 100;
                totalPrice = quantity * coldPriceRate;
            }
            else if (order == "Hot")
            {
                Int32 hotPriceRate = 90;
                totalPrice = quantity * hotPriceRate;
            }
            else
            {
                Int32 regularPriceRate = 80;
                totalPrice = quantity * regularPriceRate;
            }
            richTextBox.Text = "Coffee Purchase Information:\n\nCustomer Name: " + customerName +
                "\n Contact Number: " + customerNumber + "\nAddress: " + address +
                 "\nOrder: " + order + "\nQuantity: " + quantity + "\n\nTotal Price: " + totalPrice;

        }
    }
}
