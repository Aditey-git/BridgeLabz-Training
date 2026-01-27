using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ValidateLicensePlate
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the license plate:");
            string inputString = Console.ReadLine();

            Regex regex = new Regex(@"^[A-Z][A-Z][0-9]{4}$");

            bool isValid = regex.IsMatch(inputString);

            if (isValid)
            {
                Console.WriteLine("Number plate valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
