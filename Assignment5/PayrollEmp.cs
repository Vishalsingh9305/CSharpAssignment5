using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    internal class PayrollEmp:Employee
    {
        public DateTime JoiningDate { get; set; }
        public int Experience { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal DA { get; private set; }
        public decimal HRA { get; private set; }
        public decimal PF { get; private set; }
        public decimal NetSalary { get; private set; }

        public PayrollEmp(int uid, string name, string reportingManager, DateTime joiningDate, int experience, decimal basicSalary)
            : base(uid, name, reportingManager)
        {
            JoiningDate = joiningDate;
            Experience = experience;
            BasicSalary = basicSalary;
            CalculateSalary();
        }

        private void CalculateSalary()
        {
            if (Experience > 10)
            {
                DA = BasicSalary * 0.10M;
                HRA = BasicSalary * 0.085M;
                PF = 6200;
            }
            else if (Experience > 7)
            {
                DA = BasicSalary * 0.07M;
                HRA = BasicSalary * 0.065M;
                PF = 4100;
            }
            else if (Experience > 5)
            {
                DA = BasicSalary * 0.041M;
                HRA = BasicSalary * 0.038M;
                PF = 1800;
            }
            else
            {
                DA = BasicSalary * 0.019M;
                HRA = BasicSalary * 0.02M;
                PF = 1200;
            }

            NetSalary = BasicSalary + DA + HRA - PF;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Payroll Employee ID: {UId}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Reporting Manager: {ReportingManager}");
            Console.WriteLine($"Employee Joining Date: {JoiningDate.ToShortDateString()}");
            Console.WriteLine($"Experience: {Experience} years");
            Console.WriteLine($"Basic Salary: Rs.{BasicSalary}");
            Console.WriteLine($"DA: {DA}");
            Console.WriteLine($"HRA: {HRA}");
            Console.WriteLine($"PF: {PF}");
            Console.WriteLine($"Net Salary: {NetSalary}");
        }
    }
}
