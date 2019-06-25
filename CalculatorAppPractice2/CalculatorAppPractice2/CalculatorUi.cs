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
            //int firstNumber = Convert.ToInt32 (firstNumberTextBox.Text);
            //int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            //int sum = firstNumber + secondNumber;

            resultTextBox.Text = Add();
            resultTextBox.ToString=ad

        }
        
        private void Add()
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber + secondNumber;

            return;
        }
    }
}
