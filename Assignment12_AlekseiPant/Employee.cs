using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12_AlekseiPant
{
    public class Employee
    {
        public Employee(string name, int number)
        {
            EmployeeName = name;
            EmployeeNumber = number;
        }

        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }

        public override string ToString()
        {
            return "Employee Name: " + EmployeeName + "\r\n" +
                   "EmployeeNumber: " + EmployeeNumber + "\r\n";
        }
    }
}
