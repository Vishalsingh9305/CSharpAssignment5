using System;
using System.Collections.Generic;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            char ch;
            do
            {
                Console.Write("Enter employee type (contractbase/payroll): ");
                string input = Console.ReadLine().Trim().ToLower();

                Console.Write("Enter ID: ");
                int uid = int.Parse(Console.ReadLine());

                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter reporting manager: ");
                string reportingManager = Console.ReadLine();

                switch (input)
                {
                    case "contractbase":
                        Console.Write("Enter contract date (dd-mm-yyyy): ");
                        DateTime contractDate = DateTime.Parse(Console.ReadLine());

                        Console.Write("Enter duration (in months): ");
                        int duration = int.Parse(Console.ReadLine());

                        Console.Write("Enter charges: ");
                        double charges = double.Parse(Console.ReadLine());

                        employees.Add(new ContractBaseEmp(uid, name, reportingManager, contractDate, duration, charges));
                        break;

                    case "payroll":
                        Console.Write("Enter joining date (dd-mm-yyyy): ");
                        DateTime joiningDate = DateTime.Parse(Console.ReadLine());

                        Console.Write("Enter experience (in years): ");
                        int experience = int.Parse(Console.ReadLine());

                        Console.Write("Enter basic salary: ");
                        decimal basicSalary = decimal.Parse(Console.ReadLine());

                        employees.Add(new PayrollEmp(uid, name, reportingManager, joiningDate, experience, basicSalary));
                        break;

                    default:
                        Console.WriteLine("Invalid employee type. Please enter 'contractbase' or 'payroll'.");
                        break;
                }

                Console.Write("Do you want to add another employee? (y/n): ");
                ch = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (ch == 'y' || ch == 'Y');

            Console.WriteLine("\nEmployee Details:\n");

            foreach (var employee in employees)
            {
                employee.DisplayDetails();
                Console.WriteLine();
            }

            Console.WriteLine($"Total Number of Employees: {employees.Count}");
        }
    }
}
