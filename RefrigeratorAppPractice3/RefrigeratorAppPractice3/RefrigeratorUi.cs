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
        Refrigerator refrigeratorobj = new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigeratorobj.ItemsNo = Convert.ToInt32(itemTextBox.Text);
            itemTextBox.Clear();
            weightTextBox.Clear();
            if ((refrigeratorobj.validation()) == true)
            {
                MessageBox.Show("SorryItems Weight is larger than Refrigerators Maximum Weight Limit");
            }
            else
            {
                currentWeightTextBox.Text = Convert.ToString(refrigeratorobj.GetCurrentWeight());
                remainingWeightTextBox.Text = Convert.ToString(refrigeratorobj.GetRemainingWeight());
            }
        }
    }
}
