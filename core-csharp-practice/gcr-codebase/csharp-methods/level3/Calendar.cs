using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class Calendar
    {
        public static void CalendarDisplay() {
            //Getting Input from the user
            Console.Write("Enter month: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int yearNumber = Convert.ToInt32(Console.ReadLine());

            string NameOfMonth = GetNameOfMonth(monthNumber);
            int NumberOfDaysInMonth = GetNumberOfDaysInMonth(monthNumber, yearNumber);
            int DayOne = GetDayOne(monthNumber, yearNumber);

            Console.WriteLine();
            Console.WriteLine($"{NameOfMonth} {yearNumber}");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            for(int i = 0; i < DayOne; i++){
                Console.Write("    ");
            }
            for (int day = 1;day <= NumberOfDaysInMonth;day++){
                Console.Write($"{day,3} ");

                if((day + DayOne) % 7 == 0){
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }


        //Method to get name of Month
        public static string GetNameOfMonth(int monthNumber){
            string[] monthsArr = {
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"};

            return monthsArr[monthNumber - 1];

        }

        //Leap year method
        public static bool LeapYearCheck(int year){
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        //Method to get number of days in month
        public static int GetNumberOfDaysInMonth(int monthNumber, int yearNumber){
            int[] daysArr = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if(monthNumber == 2 && LeapYearCheck(yearNumber)){
                return 29;
            }

            return daysArr[monthNumber - 1];
        }

        //Method to get first day using Gregorian algorithm
        public static int GetDayOne(int monthNumber, int yearNumber){

            int d = 1;
            int y0 = yearNumber - (14 - monthNumber) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = monthNumber + 12 * ((14 - monthNumber) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            return d0;

        }
    }
}
