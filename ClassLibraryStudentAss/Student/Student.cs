using ClassLibraryStudentAss.BLL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

           Student student= new Student();
            StudentManager _studentManager = new StudentManager();
            student.Id = Convert.ToInt32(idTextBox.Text);
            student.Name = nameTextBox.Text;
            student.Roll = Convert.ToInt32(rollNoTextBox.Text);
            student.Address = addressTextBox.Text;
            student.Contact = contactTextBox.Text;
            MessageBox.Show(_studentManager.AddStudent(student));
        }
    }
    }