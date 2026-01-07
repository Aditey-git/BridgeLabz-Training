using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.Employee
{
    sealed class EmployeeMenu
    {
        private IEmployee Iemployee;


        public void EmployeeChoice()
        {
            Iemployee = new EmployeeUtilityImpl();

            // UC:01
            bool present = Iemployee.EmployeePresentOrNot();

            if (present)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

            
        public void EmployeeWage() {
            // UC:02
            bool present = Iemployee.EmployeePresentOrNot();

            if (present)
            {
                int dailyWage = Iemployee.DailyWageCalculate();
                Console.WriteLine($"Daily Employee Wage: {dailyWage}");
            }
        }


        public void EmployeePartTimeWage()
        {
            // UC:03
            bool present = Iemployee.EmployeePresentOrNot();

            if (present)
            {
                int partTimeWage = Iemployee.PartTimeWageCalculate();
                Console.WriteLine($"Part Time Wage: {partTimeWage}");
            }
        }
    }
}
