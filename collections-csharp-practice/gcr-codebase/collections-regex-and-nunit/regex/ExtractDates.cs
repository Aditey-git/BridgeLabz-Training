using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ExtractDates
    {
        public static void Main(string[] args)
        {
            string inputString = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

            Regex regex = new Regex(@"\b\d{2}/\d{2}/\d{4}\b");

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
