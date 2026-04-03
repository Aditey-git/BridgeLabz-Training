using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ExtractCurrencyValues
    {
        public static void Main(string[] args)
        {
            string inputString = "The price is $45.99, and the discount is $ 10.50.";

            Regex regex = new Regex(@"\$?\s?\d+\.\d{2}");

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                string value = match.Value.Trim().Replace("$", "").Trim();
                Console.WriteLine(value);
            }
        }
    }
}
