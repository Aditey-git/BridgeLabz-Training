using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.level1
{
    internal class EmployeeDetails
    {
        public string name;
        public int id;
        public double salary;


        //Class for doing object creation and method call
        public static void DetailsOfEmployee()
        {
            //Object creation
            EmployeeDetails employee = new EmployeeDetails();

            employee.name = "Aditey";
            employee.id = 1;
            employee.salary = 50000;
            employee.DisplayEmployeeDetails();
        }
             
        //Method to display Employee  
        public void DisplayEmployeeDetails(){
                Console.WriteLine("Name: " + name);
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Salary: " + salary);
            }
        }
}
