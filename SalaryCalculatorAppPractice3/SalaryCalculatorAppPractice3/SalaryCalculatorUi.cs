using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            FinalSalary finalSalary = new FinalSalary();

            finalSalary.employeeName = employeeNameTextBox.Text;
            finalSalary.basicAmount = Convert.ToInt32 (basicAmountTextBox.Text);
            finalSalary.houseRent = Convert.ToInt32(homeRentTextBox.Text);
            finalSalary.medicalAllowance = Convert.ToInt32(medicalAllowanceTextBox.Text);
            string Salary = finalSalary.GetFullSalary();
            string Name = finalSalary.employeeName;
            MessageBox.Show(Name  +  Salary);


        }
    }
}
