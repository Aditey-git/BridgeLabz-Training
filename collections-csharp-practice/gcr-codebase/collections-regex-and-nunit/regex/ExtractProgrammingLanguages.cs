using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ExtractProgrammingLanguages
    {
        public static void Main(string[] args)
        {
            string inputString = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

            // List of programming languages to extract
            string pattern = @"\b(Java|Python|JavaScript|Go|C|C\+\+|C#|Ruby|PHP)\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
