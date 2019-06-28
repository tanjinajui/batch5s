using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
     class Person
    {
        //public string firstName;
        //public string middleName;
        //public string lastName; 

        // one class- onno class a private field access (method)
        private string firstName;
        private string middleName;
        private string lastName;

        //set method//instance method
        public void SetFirstName(string firstName)
        {
            firstName = this.firstName;
        }
        //get method//instance method
        public string GetFirstName()
        {
            return firstName;
        }

        //property get set method
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public string GetFullName()
        {
            return firstName + "" + middleName + "" + lastName;
        }

        public string GetReverseName()
        {
            string reverseName = "";
            string fullName = GetFullName();
            for (int index = fullName.Length - 1; index >= 0; index--)
            {
                reverseName += fullName[index];
            }
            return reverseName;
        }

    }
}
