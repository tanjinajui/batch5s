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
    public partial class CustomerForm : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                string name;
                int age;
                user = userTextBox.Text;
                name = nameTextBox.Text;
               
                if (string.IsNullOrEmpty(userTextBox.Text))
                {
                    userLabel.Text = (" User Field can not be empty");
                    return;
                }
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    userLabel.Text = ("Name Field can not be empty");
                    return;
                }
                if (string.IsNullOrEmpty(ageTextBox.Text))
                {
                    userLabel.Text = ("Age Field can not be empty");
                    return;
                }
                age = Convert.ToInt32(ageTextBox.Text);
                if (UserExists ( userTextBox.Text))
                {
                    userLabel.Text = "User already Exits";
                    return;
                }
                users.Add(user);
                names.Add(name);
                ages.Add(age);

                

            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }

            displayRichTextBox.Text = Display();
        }
        private string Display()
        {
            string message = "";
            message = "User\tName\tAge\n";
            
            int index = 0;
            foreach (string user in users)
            {
                message = message   + user +  "\t" + names [index] + "\t" + ages [index] .ToString()+ "\n";
                index++;
            }
            return message;
            
        }
        
        private bool UserExists(string user)
        {
            bool isExist = false; 
            foreach (var userchk in users)
            {
                if (userchk == user)
                    isExist = true;
            }
            return isExist;
        }
        
    }
       
}
