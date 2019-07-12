using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryAppPractice1
{
    class Employee
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string email { get; set; }
        public double salary { get; set; }

        public string GetFinalSalary()
        {
            int salary = basicAmount + (basicAmount / 100 * houseRent) + (basicAmount / 100 * medicalAllowance);
            return salary.ToString();
        }

    }
}
