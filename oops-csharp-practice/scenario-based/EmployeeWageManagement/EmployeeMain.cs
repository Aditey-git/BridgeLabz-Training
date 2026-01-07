using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.Employee
{
    internal class EmployeeMain
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");


            EmployeeMenu empMenu;
            empMenu = new EmployeeMenu();


            // UC:01
            empMenu.EmployeeChoice();

            // UC:02
            empMenu.EmployeeChoice();

        }
    }

}
