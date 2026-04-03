using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ValidateUsername
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            string inputString = Console.ReadLine();

            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9_]{4,14}$");

            bool isValid = regex.IsMatch(inputString);

            if (isValid)
            {
                Console.WriteLine("Username valid.");
            }
            else
            {
                Console.WriteLine("Invalid Username");
            }
        }
    }
}
