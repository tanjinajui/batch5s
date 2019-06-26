using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            //int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            //int sum = firstNumber + secondNumber;
            Add()
            ;
            resultTextBox.Text = sum.ToString();
        }
        private void Add()
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber + secondNumber;
            return;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber - secondNumber;
            //Sub();
            resultTextBox.Text = sum.ToString();
        }
        //private void Sub()
        //{
        //    int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
        //    int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
        //    int sum = firstNumber - secondNumber;
        //    return;

        //}

        private void MultiplyButton_Click(object sender, EventArgs e)
        {

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

        }
       
    }
}
