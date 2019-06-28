using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class FinalSalary
    {
        public string employeeName;
        public int basicAmount;
        public int houseRent;
        public int medicalAllowance;

        public string GetFullSalary()
        {
            int salary = basicAmount + (basicAmount / 100 * houseRent) + (basicAmount / 100 * medicalAllowance);
            return salary.ToString();
        }
    }

    
}
