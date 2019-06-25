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
    public partial class ADOdatabase : Form
    {
        class Department
        {
            public string Name { set; get; }
            public string Code { set; get; }
        }
       
        public ADOdatabase()
        {
            InitializeComponent();
        }

        //private void SaveButton_Click(object sender, EventArgs e)
        //{
        //Variable declared
        //        //1
        //        SqlConnection sqlConnection = new SqlConnection();
        //        string connectionString = @"Server=DESKTOP-OVQEG5T; Database=StudentDB; Integrated Security=True";
        //        sqlConnection.ConnectionString = connectionString;

        //        //2
        //        SqlCommand sqlCommand = new SqlCommand();
        //        string commandString = @"INSERT INTO Departments(Departments_Name, Department_Code)VALUES ('Computer Science Engineering','CSE')";
        //        sqlCommand.CommandText = commandString;
        //        sqlCommand.Connection = sqlConnection;

        //        //3
        //        sqlConnection.Open();

        //        //4
        //        int isExecuted = 0;

        //        isExecuted = sqlCommand.ExecuteNonQuery();

        //        if (isExecuted > 0)
        //        {
        //            MessageBox.Show("Saved!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Not Saved!");
        //        }

        //        //5
        //        sqlConnection.Close();



        //sqlConnection.Close();

        //user input sql database a show

        //    string name = nameTextBox.Text;
        //    string code = codeTextBox.Text;

        //    Insert(name, code);
        //}
        //private void Insert(string name, string code)
        //{
        //    try
        //    {
        //       // 1
        //                SqlConnection sqlConnection = new SqlConnection();
        //        string connectionString = @"Server=DESKTOP-OVQEG5T; Database=StudentDB; Integrated Security=True";
        //        sqlConnection.ConnectionString = connectionString;

        //        //2
        //        SqlCommand sqlCommand = new SqlCommand();
        //        string commandString = @"INSERT INTO Departments(Departments_Name, Department_Code)VALUES ('" + name + "','" + code + "')";
        //        sqlCommand.CommandText = commandString;
        //        sqlCommand.Connection = sqlConnection;

        //        //3
        //        sqlConnection.Open();

        //        //4
        //        int isExecuted = 0;

        //        isExecuted = sqlCommand.ExecuteNonQuery();

        //        if (isExecuted > 0)
        //        {
        //            MessageBox.Show("Saved!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Not Saved!");
        //        }

        //        //5
        //        sqlConnection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }


        //}
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Name = nameTextBox.Text;
            department.Code = codeTextBox.Text;
            Insert(department);

        }
        private void Insert (Department department)
        {
            try
            {
                // 1
                SqlConnection sqlConnection = new SqlConnection();
                string connectionString = @"Server=DESKTOP-OVQEG5T; Database=StudentDB; Integrated Security=True";
                sqlConnection.ConnectionString = connectionString;

                //2
                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"INSERT INTO Departments(Departments_Name, Department_Code)VALUES ('" + department.Name + "','" + department.Code + "')";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //3
                sqlConnection.Open();

                //4
                int isExecuted = 0;

                isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved!");
                }
                else
                {
                    MessageBox.Show("Not Saved!");
                }

                //5
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-OVQEG5T; Database=StudentDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT*FROM Departments";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
           // SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            showDataGridView.DataSource = dataTable;
            sqlConnection.Close();

        }
    }
}
