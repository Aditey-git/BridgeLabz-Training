using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ValidateCreditCardNumber
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Credit Card Number: ");
            string inputString = Console.ReadLine();

            // Visa: starts with 4, MasterCard: starts with 5, total 16 digits
            string pattern = @"^(4\d{15}|5\d{15})$";

            Regex regex = new Regex(pattern);

            bool isValid = regex.IsMatch(inputString);

            if (isValid)
            {
                Console.WriteLine("Valid Credit Card Number");
            }
            else
            {
                Console.WriteLine("Invalid Credit Card Number");
            }
        }
    }
}
