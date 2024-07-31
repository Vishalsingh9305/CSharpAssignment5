using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    internal class ContractBaseEmp:Employee
    {
        public DateTime ContractDate { get; set; }
        public int Duration { get; set; }
        public double Charges { get; set; }

        public ContractBaseEmp(int uid, string name, string reportingManager, DateTime contractDate, int duration, double charges)
            : base(uid, name, reportingManager)
        {
            ContractDate = contractDate;
            Duration = duration;
            Charges = charges;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {UId}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Reporting Manager: {ReportingManager}");
            Console.WriteLine($"Employee Contract Date: {ContractDate.ToShortDateString()}");
            Console.WriteLine($"Duration: {Duration} months");
            Console.WriteLine($"Charges: {Charges}");
        }
    }
}
