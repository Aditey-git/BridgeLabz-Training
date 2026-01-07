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
            bool presentOrNot = Iemployee.EmployeePresentOrNot();

            if (presentOrNot)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

    }
}
