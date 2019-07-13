using ClassLibraryStudentAss.BLL.BLL;
using ClassLibraryStudentAss.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryStudentAss
{
    public partial class StudentUiDesign : Form
    {
        public StudentUiDesign()
        {
            InitializeComponent();
        }
        

        private void StudentUiDesign_Load(object sender, EventArgs e)
        {
            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Tanjina";

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
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
