using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account accountobj = new Account();
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
           // Account accountobj = new Account();
            accountobj.accountNumber = accountNoTextBox.Text;
            accountobj.customerName = customerNameTextBox.Text;
            
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            int amount =Convert.ToInt32( amountTextBox.Text);
            accountobj.Deposit(amount);
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int amount =Convert.ToInt32 (amountTextBox.Text);
            accountobj.WithDraw(amount);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string report = accountobj.Report();
            MessageBox.Show(report);
        }
    }
}
