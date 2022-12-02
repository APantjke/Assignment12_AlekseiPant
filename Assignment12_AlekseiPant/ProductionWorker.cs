using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12_AlekseiPant
{
    public class ProductionWorker : Employee
    {
        public ProductionWorker(string name, int number, int shiftNumber, decimal hourlyPayRate)
            : base(name, number)
        {
            ShiftNumber = shiftNumber;
            HourlyPayRate = hourlyPayRate;
        }

        public int ShiftNumber { get; set; }
        public decimal HourlyPayRate { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                "Employee Shift Number: " + ShiftNumber + "\r\n" +
                "Employee Hourly Pay Rate: " + HourlyPayRate + "\r\n";
        }
    }
}
