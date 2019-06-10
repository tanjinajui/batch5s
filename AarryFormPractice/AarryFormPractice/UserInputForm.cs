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
    public partial class UserInputForm : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index = 0;
        public UserInputForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {



          number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;


           
            showRichTextBox.Text =Show("add");
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            string message = "";
            for (int index = size - 1; index >= 0; index--)
            {
                if (number[index] != 0)
                    message = message + "Element at index [" + index + "] is : " + number[index].ToString() + "\n";
            }

            showRichTextBox.Text = message;
        }
        private string Show(string name)
        {
            string message = "";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Element at index [" + index + "] is : " + number[index].ToString() + "\n";
            }

            return  message ;
        }
    }
}
