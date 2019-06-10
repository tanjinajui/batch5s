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
    public partial class CustomerAssignmentForm : Form
    {
        List<string> usernames = new List<string>();
        List<string> firstnames = new List<string>();
        List<string> lastnames = new List<string>();
        List<int> contactnumbers = new List<int>();
        List<string> emails = new List<string>();
        List<string> address = new List<string>();
        List<int> accountnumbers = new List<int>();
        

        public CustomerAssignmentForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userName;
                userLabelTextBox.Text = "";
                if (!string .IsNullOrEmpty(userNameTextBox.Text))
                {
                    bool isEixt = false;
                    userName = userNameTextBox.Text;
                    isExist = IsExist(userName);
                    if (isExist)
                    {
                        MessageBox.Show("UserName: " +  userName +  "already exit");
                        return;
                    }
                   
                }else
                {
                    userLabelTextBox.Text = "Field can not be Empty";
                    return;
                }
                int contactNumber;
                if (!string.IsNullOrEmpty(contactNoTextBox.Text))
                {
                    contactNumber = Convert.ToInt32(contactNoTextBox.Text);
                    contactnumbers.Add(contactNumber);
                }
                else
                {
                    userLabelTextBox.Text = "Field can not be Empty";

                    return;
                }
                string email;
                if (!string.IsNullOrEmpty(emailTextBox.Text))
                {
                    email = emailTextBox.Text;
                    
                }
                else
                {
                    userLabelTextBox.Text = "Field can not be Empty";
                    return;
                }
                string addresses;
                int accountNumber;
                if (!string.IsNullOrEmpty(accountNoTextBox.Text))
                {
                    accountNumber = Convert.ToInt32(accountNoTextBox.Text);
                   
                }
                else
                {
                    userLabelTextBox.Text = "Field can not be Empty";

                    return;
                }
                string firstName;
                string lastName;
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;                            
                addresses = addressTextBox.Text;
                usernames.Add(userName);
                emails.Add(email);
                accountnumbers.Add(accountNumber);
                firstnames.Add(firstName);
                lastnames.Add(lastName);                              
                address.Add(addresses);                      
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            
            }
            displayRichTextBox.Text = Display();

        }
        private string Display()
        {
            string message = "";
            message = "SI \tUsername \tFirstname \tLastname \tContactnumber \tEmail                  \t \tAddress             \tAccountnumber \n";
            int index = 0;
            foreach (string user in usernames)
            {
                message =  message  + (index+1) + "\t" + usernames[index] + "\t" + "\t" + firstnames[index] + "\t" + "\t" + lastnames[index] + "\t" + "\t" + contactnumbers[index].ToString() + "\t"  + emails[index] + "\t"
                  +address[index]  +"\t" + accountnumbers[index].ToString() + "\n";
                index++;
            }
            return message;
        }
        private bool IsExist(string userName)
            
        {
            bool isExit = false;
            foreach (var userchk in usernames)
            {
                if (userName == userchk)
                    isExist = true;
            }
            return isExist;
        }
            bool isExist = false;

       

        private void showButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
