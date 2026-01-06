using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Encapsulation_polymorphism_interface_abstractclass
{

    abstract class Employee
    {
        // Encapsulated fields
        private int IdOfEmployee;
        private string nameOfEmployee;
        protected double baseSalaryAmount;

        // Properties (Encapsulation)
        public int EmployeeId
        {
            get { return IdOfEmployee; }
        }

        public string EmployeeName
        {
            get { return nameOfEmployee; }
        }

        // Constructor
        public Employee(int IdOfEmployee, string nameOfEmployee, double baseSalaryAmount)
        {
            this.IdOfEmployee = IdOfEmployee;
            this.nameOfEmployee = nameOfEmployee;
            this.baseSalaryAmount = baseSalaryAmount;
        }

        // Abstract method
        public abstract double SalaryCalculate();

        // Concrete method
        public virtual void DetailsDisplay()
        {
            Console.WriteLine($"Employee ID: {IdOfEmployee}");
            Console.WriteLine($"Name: {EmployeeName}");
            Console.WriteLine($"Salary: {SalaryCalculate()}");
        }
    }


    // Interface
    interface IDepartment
    {
        void DepartmentAssignment(string departmentName);
        string DepartmentDetailsGetter();
    }


    // Full-time employee
    class FullTimeEmployeeClass : Employee, IDepartment
    {
        private string empDepartment;

        public FullTimeEmployeeClass(int id, string name, double fixedSalary)
            : base(id, name, fixedSalary)
        {
        }

        public override double SalaryCalculate()
        {
            return baseSalaryAmount; // Fixed monthly salary
        }

        public void DepartmentAssignment(string nameOfDepartment)
        {
            empDepartment = nameOfDepartment;
        }

        public string DepartmentDetailsGetter()
        {
            return empDepartment;
        }

        public override void DetailsDisplay()
        {
            base.DetailsDisplay();
            Console.WriteLine($"Department  : {empDepartment}");
            Console.WriteLine("Employee Type: Full-Time");
        }
    }
    

    // Part-time employee
    class PartTimeEmployeeClass : Employee, IDepartment
    {
        private int workedHours;
        private string empDepartment;

        public PartTimeEmployeeClass(int empId, string empName, double rateHourly, int workedHours)
            : base(empId, empName, rateHourly)
        {
            this.workedHours = workedHours;
        }

        public override double SalaryCalculate()
        {
            return baseSalaryAmount * workedHours;
        }

        public void DepartmentAssignment(string departmentName)
        {
            empDepartment = departmentName;
        }

        public string DepartmentDetailsGetter()
        {
            return empDepartment;
        }

        public override void DetailsDisplay()
        {
            base.DetailsDisplay();
            Console.WriteLine($"Department  : {empDepartment}");
            Console.WriteLine("Employee Type: Part-Time");
        }
    }

    class EmployeeManagementClass
    {
        static void EmployeeManagementFunction()
        {
            // Polymorphic collection
            List<Employee> employeesArr = new List<Employee>();

            FullTimeEmployeeClass ftEmp = new FullTimeEmployeeClass(101, "Rahul", 60000);
            ftEmp.DepartmentAssignment("IT");

            PartTimeEmployeeClass ptEmp = new PartTimeEmployeeClass(102, "Anita", 500, 40);
            ptEmp.DepartmentAssignment("HR");

            employeesArr.Add(ftEmp);
            employeesArr.Add(ptEmp);

            // Polymorphism in action
            foreach (Employee emplo in employeesArr)
            {
                emplo.DetailsDisplay();
                Console.WriteLine();
            }
        }
    }

}
