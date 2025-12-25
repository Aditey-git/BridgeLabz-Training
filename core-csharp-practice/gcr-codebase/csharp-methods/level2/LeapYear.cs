using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class LeapYear
    {
        public static void LeapYearOrNot() {
            // Take input from user
            Console.Write("Enter the year: ");
            int yearGiven = Convert.ToInt32(Console.ReadLine());

            //Calling the method
            bool answer = LeapYearChecker(yearGiven);

            if(answer){
                Console.WriteLine("Leap Year");
            }
            else{
                Console.WriteLine("Not a Leap Year");
            }
        }

        //Method for checking leap year
        public static bool LeapYearChecker(int yearGiven){
            if (yearGiven < 1582){
                return false;
            }
            if ((yearGiven % 4 == 0 && yearGiven % 100 != 0) || (yearGiven % 400 == 0)){
                return true;
            }

            return false;
        }
    }
}
