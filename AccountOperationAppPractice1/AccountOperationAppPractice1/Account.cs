using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class Account
    {
        public string accountNumber;
        public string customerName;
        public int balance;

        
        
        public void Deposit(int amount)
        {
            balance = balance + amount;
            
        }

        public void WithDraw (int amount)
        {
            balance = balance - amount;

        }

        public string Report()
        {
            return accountNumber + "" + customerName + "" + balance;
        }
    }
}
