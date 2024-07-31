using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class Employee
    {
        public int UId { get; set; }
        public string Name { get; set; }
        public string ReportingManager { get; set; }

        public Employee(int uid, string name, string reportingManager)
        {
            UId = uid;
            Name = name;
            ReportingManager = reportingManager;
        }

        public abstract void DisplayDetails();
    }
}
