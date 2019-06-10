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
    public partial class ArrayvalueDeclartForm : Form
    {
        public ArrayvalueDeclartForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] number = new int[size];
            number[8] = 15;
            number[6] = 20;
            number[3] = 25;
            string message = "";
            for (int index = 0; index < number.Length; index++)
            {
                if (number [index] !=0)
                message = message + "Element at index [" + index + "] is : " + number[index].ToString() + "\n";
            }

            
            //message = message + "Element at index 8 is : " + number[8].ToString()+"\n";
            //message = message + "Element at index 6 is : " + number[6].ToString() + "\n";
            //message = message + "Element at index 3 is : " + number[3].ToString() + "\n";

            showRichTextBox.Text = message;
        }

        private void showRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
