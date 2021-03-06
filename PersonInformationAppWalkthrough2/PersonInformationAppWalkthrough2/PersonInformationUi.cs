﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformationAppWalkthrough2
{
    public partial class PersonInformationUi : Form
    {
        public PersonInformationUi()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Person personobj = new Person();
            //personobj.firstName = firstNameTextBox.Text;
            //personobj.middleName = middleNameTextBox.Text;
            //personobj.lastName = lastNameTextBox.Text;

            //private method k set method a call 
            personobj.SetFirstName(firstNameTextBox.Text);
            personobj.SetMiddleName(middleNameTextBox.Text);
            personobj.SetLastName(lastNameTextBox.Text);

            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string fullName = personobj.GetFullName();
            string reverseName = personobj.GetReverseName();
            //string firstName = personobj.GetFirstName();
            //string middleName = personobj.GetMiddleName();
            //string lastName = personobj.GetLastName();
            //propety method call
            //personobj.FirstName = firstNameTextBox.Text;
            //string firstName = personobj.FirstName;

            fullNameTextBox.Text = fullName;
            reverseNameTextBox.Text = reverseName;
        }
    }
}
