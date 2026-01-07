using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.Employee
{
    interface IEmployee
    {
        Employee AddEmployee();

        bool EmployeePresentOrNot(); //UC 1

        
        int DailyWageCalculate(); //UC 2

    }
}
