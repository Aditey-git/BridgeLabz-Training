using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class FindRepeatingWords
    {
        public static void Main(string[] args)
        {
            string inputString = "This is is a repeated repeated word test.";

            Regex regex = new Regex(@"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase);

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}
