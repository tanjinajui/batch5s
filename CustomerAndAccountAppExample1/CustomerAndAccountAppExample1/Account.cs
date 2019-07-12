using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountAppExample1
{
    public class Account
    {
        
        //public string AccountNumber { get; set; }
        //public string OpeningDate { get; set; }
        //public   double Balance { get; private set; }

        private string AccountNumber;
        private string OpeningDate;
        private double Balance;

        public string AccountNumber1 {
            get { return AccountNumber; }
            set { AccountNumber= value; }
        }

        public string OpeningDate1 {
            get { return OpeningDate; }
            set { OpeningDate = value; }
        }
        public double Balance
        {
            get { return balance; }
        }


        //public bool Deposit(double amount)
        //{
        //     Balance +=  amount;
        //    return true;
        //}
        //public bool Withdraw(double amount)
        //{
        //    Balance -= amount;
        //    return true;
        //}
        public Account()
        {
            Balance = 0;
        }

        public Account(string accountNumber, string openingDate) : this()
        {
            this.AccountNumber1 = accountNumber;
            this.OpeningDate1 = openingDate;
        }


        public bool Deposit(double amount)
        {
            Balance += amount;
            return true;
        }
        public bool Withdraw(double amount)
        {
            Balance -= amount;
            return true;
        }
    }
}
