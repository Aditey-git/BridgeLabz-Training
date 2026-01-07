using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.Employee
{
    class Employee
    {
        private string employeeId;
        private string employeeName;
        private double salary;

        public string GetEmployeeId()
        {
            return employeeId;
        }

        public void SetEmployeeId(string employeeId)
        {
            this.employeeId = employeeId;
        }

        public string GetEmployeeName()
        {
            return employeeName;
        }

        public void SetEmployeeName(string employeeName)
        {
            this.employeeName = employeeName;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"EmployeeId   : {employeeId}\n" +
                   $"EmployeeName : {employeeName}\n" +
                   $"Salary       : {salary}";
        }
    }
}
