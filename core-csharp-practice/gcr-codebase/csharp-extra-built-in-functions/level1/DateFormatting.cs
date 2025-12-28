using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BuiltIn
{
    internal class DateFormatting
    {
        public static void FormatDate() {
            DateTime todayDate = DateTime.Now;

            Console.WriteLine("Current Date in Different Formats:\n");
            Console.WriteLine("dd/MM/yyyy      : " + todayDate.ToString("dd/MM/yyyy"));

            Console.WriteLine("yyyy-MM-dd      : " + todayDate.ToString("yyyy-MM-dd"));

            Console.WriteLine("EEE, MMM dd, yyyy: " + todayDate.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
