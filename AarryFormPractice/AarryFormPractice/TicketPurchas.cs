using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AarryFormPractice
{
    public partial class TicketPurchas : Form
    {
      private int numberOftickets = 0;
        private double unitPrices = 10;
        private string customerName = "";
        private double totalPrice = 0;
        public TicketPurchas()
        {
            InitializeComponent();
        }

        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            numberOftickets = Convert.ToInt32(numberOfTicketTextBox.Text);
            customerName = customerNameTextBox.Text;
            totalPrice = unitPrices * numberOftickets;
            MessageBox.Show("Customer Name:  " + customerName + " , Please pay " + totalPrice + " Taka to Purchase " + numberOftickets + " Tickets ");
            
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            string messageOutput = "Customer Name: " + customerName + " , \n Unit Price:  " + unitPrices + " , \n Total Price: " + totalPrice;
            MessageBox.Show(messageOutput);
        }
    }
}
