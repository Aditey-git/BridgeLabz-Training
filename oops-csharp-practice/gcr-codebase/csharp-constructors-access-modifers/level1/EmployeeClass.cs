using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Constructor_Instance.level1
{
    internal class EmployeeClass
    {
        public int employeeID;

        protected string department;

        private double salary;

        // Constructor
        public EmployeeClass(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        // Public method to modify salary
        public void SalarySetter(double salaryNew)
        {
            if (salaryNew > 0)
            {
                salary = salaryNew;
            }
            else
            {
                Console.WriteLine("Invalid salary amount.");
            }
        }

        // Public method to access salary
        public double SalaryGetter()
        {
            return salary;
        }
    }

    // Subclass demonstrating access to public and protected members
    internal class ManagerClass : EmployeeClass
    {
        public string roleOfEmployee;

        public ManagerClass(int id, string dept, double salary, string role)
            : base(id, dept, salary)
        {
            this.roleOfEmployee = role;
        }

        public void ManagerDetailsDisplay()
        {
            Console.WriteLine($"Employee ID: {employeeID}");   
            Console.WriteLine($"Department: {department}");   
            Console.WriteLine($"Role: {roleOfEmployee}");
            Console.WriteLine($"Salary: ₹{SalaryGetter()}"); 
        }
    }

    internal class ProgramClassEmployee
    {
        static void EmployeeManage(){
            ManagerClass managerEmp = new ManagerClass(201, "IT", 85000, "Project Manager");

            managerEmp.ManagerDetailsDisplay();

            // Modify salary
            managerEmp.SalarySetter(95000);
            Console.WriteLine("Updated Salary: ₹" + managerEmp.SalaryGetter());
        }
    }
}
