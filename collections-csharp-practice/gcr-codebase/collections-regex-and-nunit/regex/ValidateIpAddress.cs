using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ValidateIpAddress
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter IP Address: ");
            string inputString = Console.ReadLine();

            string pattern = @"^((25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)$";

            Regex regex = new Regex(pattern);

            bool isValid = regex.IsMatch(inputString);

            if (isValid)
            {
                Console.WriteLine("Valid IP Address");
            }
            else
            {
                Console.WriteLine("Invalid IP Address");
            }
        }
    }
}
