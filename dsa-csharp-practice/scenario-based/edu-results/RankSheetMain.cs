using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.EduResults_Rank_Sheet_Generator
{
    internal class RankSheetMain
    {
        static void Main(string[] args)
        {
            Student[] d1 = {
            new Student("S101", "Aman", "Delhi", 95),
            new Student("S102", "Riya", "Delhi", 90)
        };

            Student[] d2 = {
            new Student("S201", "Karan", "Mumbai", 96),
            new Student("S202", "Neha", "Mumbai", 90)
        };

            DistrictResult[] districts = {
            new DistrictResult("Delhi", d1),
            new DistrictResult("Mumbai", d2)
        };

            RankSheet rankSheet = new RankSheet(districts);
            Student[] students = rankSheet.GenerateRankSheet();

            Console.WriteLine("State Rank List: ");
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Rank. "+(i+1));
                Console.WriteLine(students[i].ToString());
                Console.WriteLine();
            }
        }
    }
}
