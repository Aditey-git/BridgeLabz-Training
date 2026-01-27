using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ValidateHexColor
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the hex color: ");
            string inputString = Console.ReadLine();

            Regex regex = new Regex(@"^\#[0-9A-Fa-f]{6}$");

            bool isValid = regex.IsMatch(inputString);
            if (isValid)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }

        }
    }
}
