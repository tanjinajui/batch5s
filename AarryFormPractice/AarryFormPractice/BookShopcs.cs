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
    public partial class BookShopcs : Form
    {
        public BookShopcs()
        {
            InitializeComponent();
        }

        //private void SaveButton_Click(object sender, EventArgs e)
        //{
        //    string customerName = CustomerNameTextBox.Text;
        //    string contactNumber = ContactNumberTextBox.Text;
        //    string Address = addressTextBox.Text;
        //    string order = orderComboBox.Text;
        //    int quantity = Convert.ToInt32(quantityTextBox.Text);
        //    int totalPrice = 0;
            

        //    if (order == "")
        //    {
        //        MessageBox.Show("Select the product");
        //    }
        //    else if (order == "Math")
        //    {
        //        Int32 mathBookPriceRate = 120;
        //        totalPrice = quantity * mathBookPriceRate;
        //    }
        //    else if (order == "English")
        //    {
        //        Int32 englishBookPriceRate = 100;
        //        totalPrice = quantity * englishBookPriceRate;
        //    }
        //    else if (order == "Bangla")
        //    {
        //        Int32 banglaBookPriceRate = 90;
        //        totalPrice = quantity * banglaBookPriceRate;

        //    }
        //    else if (order == "Art")
        //    {
        //        Int32 artBookPriceRate = 80;
        //        totalPrice = quantity * artBookPriceRate;
        //    }else
        //            {
        //        Int32 regularPriceRate = 70;
        //        totalPrice = quantity * regularPriceRate;
        //            }
        //    MessageBox.Show("Book Shop:\n\n Customer Name: " + customerName + "\n Contact Number: " + 
        //        contactNumber + " \n Address: " + Address + "\n Order: " + orderComboBox + "\n Quantity: " +
        //        quantity);
        //    richTextBox.Text = "Book Shop:\n\n Customer Name: " + customerName + "\n Contact Number: "
        //         + contactNumber + " \n Address: " + Address + "\n Order: " + orderComboBox +
        //         "\n Quantity: " + quantity;
        //}

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            string customerName = CustomerNameTextBox.Text;
            string contactNumber = ContactNumberTextBox.Text;
            string Address = addressTextBox.Text;
            string order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int totalPrice = 0;


            if (order == "")
            {
                MessageBox.Show("Select the product");
            }
            else if (order == "Math")
            {
                Int32 mathBookPriceRate = 120;
                totalPrice = quantity * mathBookPriceRate;
            }
            else if (order == "English")
            {
                Int32 englishBookPriceRate = 100;
                totalPrice = quantity * englishBookPriceRate;
            }
            else if (order == "Bangla")
            {
                Int32 banglaBookPriceRate = 90;
                totalPrice = quantity * banglaBookPriceRate;

            }
            else if (order == "Art")
            {
                Int32 artBookPriceRate = 80;
                totalPrice = quantity * artBookPriceRate;
            }
            else
            {
                Int32 regularPriceRate = 70;
                totalPrice = quantity * regularPriceRate;
            }
            MessageBox.Show("Book Shop:\n\n Customer Name: " + customerName + "\n Contact Number: " +
                contactNumber + " \n Address: " + Address + "\n Order: " + orderComboBox + "\n Quantity: " +
                quantity);
            richTextBox.Text = "Book Shop:\n\n Customer Name: " + customerName + "\n Contact Number: "
                 + contactNumber + " \n Address: " + Address + "\n Order: " + order +
                 "\n Quantity: " + quantity;
        }
    }
}
