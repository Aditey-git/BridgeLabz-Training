using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ValidateSSN
    {
        public static void Main(string[] args)
        {
            string inputString = "My SSN is 123-45-6789.";

            // Extract SSN from text
            Regex regex = new Regex(@"\b\d{3}-\d{2}-\d{4}\b");

            Match match = regex.Match(inputString);

            if (match.Success)
            {
                Console.WriteLine("✅ " + match.Value + " is valid");
            }
            else
            {
                Console.WriteLine("❌ Invalid SSN");
            }
        }
    }
}
