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
    public partial class ArrayExeciseForm : Form
    {
        const int size = 0;
        int[] number = new int[size];
        int index = 0;
        public ArrayExeciseForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;
            string message = "";
            for (int index=0; index < number.Length; index++)
            {
                if (number[index]!=0)
                message= message +"Element at index ["+index + "]is: " + number[index].ToString();
            }
            showRichTextBox.Text = message;
        }
    }
}
