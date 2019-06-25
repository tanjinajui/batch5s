using MyWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForms
{
    public partial class StudentUiDesign : Form
    {
        string connectionString = @"Server=DESKTOP-OVQEG5T; Database=StudentDB; Integrated Security= True";
        SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;

        private Students student;
        public StudentUiDesign()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            student = new Students();
        }

        private void StudentUiDesign_Load(object sender, EventArgs e)
        {
            LoadDistrict();     
        }
        private  void LoadDistrict()
        {
            commandString = @"SELECT * FROM Districts";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count>0)
            districtComboBox.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            student.Roll_No = rollNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.Districts_ID = Convert.ToInt32(districtComboBox.SelectedValue);
            InsertStudent(student);
        }

        private void InsertStudent(Students student)
        {
            commandString = @"INSERT INTO Students (Roll_No ,Name, Age, Address, District_ID)VALUES ('" + student.Roll_No + "', '" + student.Name + "', " + student.Age + ", '" + student.Address + "'," + student.Districts_ID + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved!!");
            }

            sqlConnection.Close();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowStudent();
        }
        private void ShowStudent()
        {
            commandString = @"SELECT * FROM StudentViews";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                displayDataGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

    }
}
