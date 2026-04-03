using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.RegexQuestions
{
    internal class ExtractEmail
    {
        public static void Main(string[] args)
        {
            string inputString = "Contact us at support@example.com and info@company.org";

            Regex regex = new Regex(@"[\w\.-]+@[\w\.-]+\.\w+");

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
