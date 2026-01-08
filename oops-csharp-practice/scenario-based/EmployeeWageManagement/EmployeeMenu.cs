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


        public void presentCheck()
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
            Iemployee = new EmployeeUtilityImpl();

            // UC:02
            bool present = Iemployee.EmployeePresentOrNot();

            if (present)
            {
                int dailyWage = Iemployee.DailyWageCalculate();
                Console.WriteLine($"Daily Employee Wage: {dailyWage}");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }


        public void EmployeePartTimeWage()
        {
            Iemployee = new EmployeeUtilityImpl();

            // UC:03
            bool present = Iemployee.EmployeePresentOrNot();

            if (present)
            {
                int partTimeWage = Iemployee.PartTimeWageCalculate();
                Console.WriteLine($"Part Time Wage: {partTimeWage}");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }


        //UC:05
        public void EmployeeMonthlyWage()
        {
            Iemployee = new EmployeeUtilityImpl();

            int workHrs = Iemployee.GetWorkingHrs();

            if(workHrs == 4)
            {
                Console.WriteLine($"Montly Wage for this part time employee: {Iemployee.MonthlyPartTimeWage()}" );
            }
            else
            {
                Console.WriteLine($"Montly Wage for this full time employee: {Iemployee.MonthlyWageCalculate()}");
            }
        }


        //UC:04
        public void EmployeeChoice()
        {
            Iemployee = new EmployeeUtilityImpl();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Select Use Case:");
                Console.WriteLine("1. UC1 - Employee Attendance");
                Console.WriteLine("2. UC2 & UC3 - Wage Calculate");
                Console.WriteLine("3. UC5 - Monthly Wage Calculate");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your Choice:");


                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }


                switch (choice)
                {
                    case 1:
                        presentCheck();
                        break;

                    case 2:
                        int workingHrs = Iemployee.GetWorkingHrs();

                        if(workingHrs == 4)
                        {
                            EmployeePartTimeWage();
                        }
                        else
                        {
                            EmployeeWage();
                        }
                        break;

                    case 3:
                        EmployeeMonthlyWage();
                        break;

                    case 4:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Entered Wrong Choice");
                        break;
                }
            }
        }
    }
}
