using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn
{
    internal class DateAndComparision
    {
        public static void DateCompare() {
            //Getting date from user
            Console.Write("Enter first date: ");
            DateTime dateFirst = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter second date: ");
            DateTime dateSecond = Convert.ToDateTime(Console.ReadLine());

            int resultant = dateFirst.CompareTo(dateFirst);

            if(resultant < 0){
                Console.WriteLine("The first date is BEFORE the second date.");
            }else if(resultant > 0){
                Console.WriteLine("The first date is AFTER the second date.");
            }else{
                Console.WriteLine("Both dates are the SAME.");
            }
        }
    }
}
