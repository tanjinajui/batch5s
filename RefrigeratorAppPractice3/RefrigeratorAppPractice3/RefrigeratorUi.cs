using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        ShowWeight _showWeight = new ShowWeight();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }
        
            
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                _showWeight.MaxWeightLimit = Convert.ToDouble(maxWeightTakeTextBox.Text);
                //maxWeightTakeTextBox.Clear();

                MessageBox.Show("Saved Succesfully!");
            }
            catch(Exception exception)
            {
                //string Message = " ";
                //Message = "Saved Failed!";
                MessageBox.Show(exception.Message);
                
            }
        }

        private void EnterButton_Click_1(object sender, EventArgs e)
        {
            _showWeight.ItemsNo = Convert.ToInt32(itemTextBox.Text);
            _showWeight.Weight__Kg_Unit = Convert.ToDouble(weightTextBox.Text);

            itemTextBox.Clear();
            weightTextBox.Clear();

            if ((_showWeight.validation()) == true)
            {
                MessageBox.Show("Sorry  Items  Weight is Larger than Refrigerator's Maximum Weight Limit");


            }

            else
            {
                currentWeightTextBox.Text = Convert.ToString(_showWeight.GetCurrentWeight());
                remainingWeightTextBox.Text = Convert.ToString(_showWeight.GetRemainingWeight());
            }
        }
     
    }
}
