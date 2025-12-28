using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn
{
    internal class DateArithemetic
    {
        public static void ArithemeticDate() {
            //Getting date input from user
            Console.Write("Enter a date: ");
            DateTime dateInput = Convert.ToDateTime(Console.ReadLine());
            DateTime dateUpdated = dateInput.AddDays(7).AddMonths(1).AddYears(2);
            DateTime dateFinal = dateUpdated.AddDays(-21);
            Console.WriteLine("\nOriginal Date: " + dateInput.ToShortDateString());
            Console.WriteLine("After Adding 7 days, 1 month, 2 years: " + dateUpdated.ToShortDateString());
            Console.WriteLine("After Subtracting 3 weeks: " + dateFinal.ToShortDateString());
        }
    }
}
