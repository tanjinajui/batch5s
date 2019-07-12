using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountAppExample1
{
    class Customer
    {
        //public string Customername { get; set; }
        //public string Email { get; set; }

        //public Account Account { get; set; }
        private string CustomerName;
        private string email;
        private Account customerAccount=null;
        public string CustomerName1 {
            get { return CustomerName1; }
            set { CustomerName1 = value; }
        }
        public string Email {
            get { return Email; }
            set { Email = value; }
        }
        public Account CustomerAccount
        {
            get { return customerAccount; }
            set { customerAccount = value; }
        }

    }
}
