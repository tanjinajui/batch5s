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
    public partial class ConditionalStatementForm : Form
    {
        public ConditionalStatementForm()
        {
            InitializeComponent();
        }

        private void showPlanetButton_Click(object sender, EventArgs e)
        {
            string planetName = planetNameComboBox.Text;
            if(planetName == "Planet")
            {
                MessageBox.Show("It is in 3rd position");
            }
            else if(planetName == "Tanjina")
            {
                MessageBox.Show("It is in 6th position");
            }
            else if (planetName == "Jui")
            {
                MessageBox.Show("It is in 4th position");
            }
            else
            {
                MessageBox.Show("I don't Know");
            }
        }
    }
}
