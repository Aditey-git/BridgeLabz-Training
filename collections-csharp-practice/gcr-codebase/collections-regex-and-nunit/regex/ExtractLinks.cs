using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ExtractLinks
    {
        public static void Main(string[] args)
        {
            string inputString = "Visit https://www.google.com and http://example.org for more info.";

            Regex regex = new Regex(@"https?://[^\s]+");

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
