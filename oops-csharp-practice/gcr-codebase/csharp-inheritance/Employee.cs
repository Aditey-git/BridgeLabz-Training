using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class Employee
    {
        public string EmployeeName;
        public int EmployeeId;
        public double EmployeeSalary;

        public Employee(string EmployeeName, int EmployeeId, double EmployeeSalary)
        {
            this.EmployeeName = EmployeeName;
            this.EmployeeId = EmployeeId;
            this.EmployeeSalary = EmployeeSalary;
        }

        // Virtual method
        public virtual void DetailsDisplay()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {EmployeeName}");
            Console.WriteLine($"ID: {EmployeeId}");
            Console.WriteLine($"Salary: {EmployeeSalary}");
        }
    }

    // Manager subclass
    class ManagerSubclass : Employee
    {
        public int TeamSize;

        public ManagerSubclass(string employeeName, int employeeId, double employeeSalary, int sizeOfTeam)
            : base(employeeName, employeeId, employeeSalary)
        {
            TeamSize = sizeOfTeam;
        }

        public override void DetailsDisplay()
        {
            base.DetailsDisplay();
            Console.WriteLine($"Team Size : {TeamSize}");
        }
    }


    // Developer subclass
    class DeveloperSubclass : Employee
    {
        public string ProgramLanguage;

        public DeveloperSubclass(string developerSubclass, int empId, double salaryOfDeveloper, string programmingLanguage)
            : base(developerSubclass, empId, salaryOfDeveloper)
        {
            ProgramLanguage = programmingLanguage;
        }

        public override void DetailsDisplay()
        {
            base.DetailsDisplay();
            Console.WriteLine($"Language : {ProgramLanguage}");
        }
    }

    // Intern subclass
    class InternSubclass : Employee
    {
        public string InternshipDuration;

        public InternSubclass(string internName, int internId, double internSalary, string workDuration)
            : base(internName, internId, internSalary)
        {
            InternshipDuration = workDuration;
        }

        public override void DetailsDisplay()
        {
            base.DetailsDisplay();
            Console.WriteLine($"Internship Duration : {InternshipDuration}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism in action
            Employee employee1 = new ManagerSubclass("Aditey", 101, 80000, 8);
            Employee employee2 = new DeveloperSubclass("Sambhav", 102, 60000, "C#");
            Employee employee3 = new InternSubclass("Shyam", 103, 15000, "6 Months");

            employee1.DetailsDisplay();
            Console.WriteLine();

            employee2.DetailsDisplay();
            Console.WriteLine();

            employee3.DetailsDisplay();
        }
    }


}
