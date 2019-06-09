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
    public partial class PersonalInformationForm : Form
    {
        private readonly string message;

        public PersonalInformationForm()
        {
            InitializeComponent();
        }
        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" " +  FirstNameTextBox.Text  + "" +  lastNameTextBox.Text  + "" +  fathersnameTextBox.Text  +  "" +  mothersNameTextBox.Text  +  "" +  AddressTextBox.Text);
        }

       

        private void ParentsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + fathersnameTextBox.Text  +  "" +  mothersNameTextBox.Text);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + AddressTextBox.Text);
        }

        private void NameButton_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("" + FirstNameTextBox.Text  +  "" +  lastNameTextBox.Text);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveRichTextBox.Text = (" " + FirstNameTextBox.Text + "" + lastNameTextBox.Text + "" + fathersnameTextBox.Text + "" + mothersNameTextBox.Text + "" + AddressTextBox.Text);
        }
        
        
         
    }
}
