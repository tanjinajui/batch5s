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
    public partial class SubAddMultDivForm : Form
    {
        public SubAddMultDivForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber + secondNumber;
            summationTextBox.Text = sum.ToString();

        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber - secondNumber;
            summationTextBox.Text = sum.ToString();
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber * secondNumber;
            summationTextBox.Text = sum.ToString();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber / secondNumber;
            summationTextBox.Text = sum.ToString();
        }
    }
}
