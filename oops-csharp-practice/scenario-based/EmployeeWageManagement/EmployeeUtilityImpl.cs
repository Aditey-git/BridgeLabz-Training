using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.Employee
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;
        private int wagePerHour = 20;
        private int fullDayHrs = 8;
        private int partTimeHrs = 4;
        private int workingDaysPerMonth = 20;

        public Employee AddEmployee()
        {
            employee = new Employee(); 
            return employee;
        }


        public int GetWorkingHrs()
        {
            Random random = new Random();
            int type = random.Next(3);

            if (type == 0) return 0;
            else if (type == 1) return 4;
            else return 8;
        }

        // UC1
        public bool EmployeePresentOrNot()
        {
            Random random = new Random();
            int attendance = random.Next(2);
            return attendance == 1;
        }

        //UC2
        public int DailyWageCalculate()
        {
            return wagePerHour * fullDayHrs;
        }


        //UC:03
        public int PartTimeWageCalculate()
        {
            return partTimeHrs * wagePerHour;
        }


        //UC:05
        public int MonthlyWageCalculate()
        {
            return workingDaysPerMonth * fullDayHrs * wagePerHour;
        }

        public int MonthlyPartTimeWage()
        {
            return workingDaysPerMonth * partTimeHrs * wagePerHour;
        }
    }
}
