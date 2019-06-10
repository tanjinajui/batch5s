using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AarryFormPractice
{
    public partial class ListForm : Form

    {
        List<int> numbers = new List<int>();
        List<string> names = new List<string>();
        public ListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            //numbers.Add(2);
            //numbers.Add(4);
            //numbers.Add(8);
            names.Add(nameTextBox.Text);
            numbers.Add(Convert.ToInt32(numberTextBox.Text));
            string message = "For\n";
            for(int i = 0; i < numbers.Count;i++)
            {
                message = message + names [i] + ""+ numbers[i] + "\n";
            }
            
            message = message + "Foreah\n";
            int index = 0;
            foreach (int number in numbers)
            {
                message = message + names [index] + " " + number + "\n";
                
            }
            showRichTextBox.Text = message;
        }

        private void showButton_Click(object sender, EventArgs e)
        {

        }
        
    }
}
