using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.ThisSealedStatic
{
    internal class Employee
    {
        //static variable shared by all employees
        public static string NameOfCompany = "Infosys Ltd";
        private static int totalEmployees = 0;

        //readonly variable
        public readonly int Id;

        // instance variables
        public string employeeName;
        public string employeeDesignation;

        // constructor using 'this' keyword
        public Employee(string employeeName, int Id, string employeeDesignation)
        {
            this.employeeName = employeeName;
            this.Id = Id;
            this.employeeDesignation = employeeDesignation;
            totalEmployees++;
        }

        // static method
        public static void TotalEmployeesDisplay()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }

        // instance method
        public void EmployeeDetailsDisplay(object obj)
        {
            // using 'is' operator
            if (obj is Employee){
                Console.WriteLine("Company Name: " + NameOfCompany);
                Console.WriteLine("Employee Name: " + employeeName);
                Console.WriteLine("Employee ID: " + Id);
                Console.WriteLine("Designation: " + employeeDesignation);
            }
            else{
                Console.WriteLine("Object is not an Employee.");
            }
        }
    }

    internal class EmployeeManagement
    {
        static void EmployeeManage()
        {
            Employee employee1 = new Employee("Aditey Rai", 101, "Software Engineer");
            Employee employee2 = new Employee("Sambhav Tiwari", 102, "HR Manager");

            employee1.EmployeeDetailsDisplay(employee1);
            Console.WriteLine();
            employee2.EmployeeDetailsDisplay(employee2);
            Console.WriteLine();

            Employee.TotalEmployeesDisplay();
        }
    }
}
