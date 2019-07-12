using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAndAccountAppExample1
{
    public partial class CustomerAndAccountUi : Form
    {
        public CustomerAndAccountUi()
        {
            InitializeComponent();
        }
        Customer customer = new Customer();
        private void SaveButton_Click(object sender, EventArgs e)
        {

            //customer.Customername = customerNameTextBox.Text;
            //customer.Email = emailTextBox.Text;

            //customer.Account = new Account();
            //customer.Account.AccountNumber = accountNumberTextBox.Text;
            //customer.Account.OpeningDate = openingDateTextBox.Text;

            customer.CustomerName1 = customerNameTextBox.Text;
            customer.Email = emailTextBox.Text;
            Account accountobj = new Account(accountNumberTextBox.Text,
            openingDateTextBox.Text);
            customer.CustomerAccount = accountobj;
            MessageBox.Show(customer.CustomerName1 + "Has opened an account with" + customer.CustomerAccount.AccountNumber1 + "AccountNumber");




        }

        private void DepositeButton_Click(object sender, EventArgs e)
        {
            double amount =Convert.ToDouble(amountTextBox.Text);
            bool isDeposited = customer.CustomerAccount.Deposit(amount);
            if (isDeposited)
            {
                amountTextBox.Text = "";
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            bool isWithdrawn = customer.CustomerAccount.Withdraw(amount);

            if (isWithdrawn)
            {
                amountTextBox.Text = "";
            }


        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            customerName2TextBox.Text = customer.CustomerName1;
            email2TextBox.Text = customer.Email;
            accountNumber2TextBox.Text = customer.CustomerAccount.AccountNumber1;
            openingDate2TextBox.Text = customer.CustomerAccount.OpeningDate1;
            BalanceTextBox.Text = customer.CustomerAccount.Balance.ToString();
        }
    }
}
