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
    public partial class Data_Types : Form
    {
        public Data_Types()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int firstNumber;
            firstNumber = 10;
            int secondNumber = firstNumber;
            double thirdNumber = secondNumber;
            MessageBox.Show(" firstNumber: " +  firstNumber  +   " secondNumber: " +  secondNumber +  " thirdNumber: " +  thirdNumber);
        }
    }
}
