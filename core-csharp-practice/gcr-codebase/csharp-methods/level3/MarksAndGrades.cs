using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class MarksAndGrades
    {
        public static int[,] MarksAndGradesFind(int studentD){
            int[,] mat = new int[studentD, 3];
            Random random = new Random();

            for (int i = 0;i < studentD;i++){
                mat[i, 0] = random.Next(10, 100);
                mat[i, 1] = random.Next(10, 100);
                mat[i, 2] = random.Next(10, 100);
            }

            return mat;


        }


        public static double[,] ResultsFind(int[,] mat){
            int stu = mat.GetLength(0);

            double[,] answer = new double[stu, 3];

            for (int i = 0; i < stu; i++){
                int totalMarks = mat[i, 0] + mat[i, 1] + mat[i, 2];
                double average = totalMarks / 3.0;
                double per = (totalMarks / 300.0) * 100;



                answer[i, 0] = totalMarks;
                answer[i, 1] = Math.Round(average, 2);
                answer[i, 2] = Math.Round(per, 2);


            }

            return answer;

        }

        // Grade calculation
        public static string Grade(double per){


            if (per >= 80) return "A";
            if (per >= 70) return "B";
            if (per >= 60) return "C";
            if (per >= 50) return "D";
            if (per >= 40) return "E";
            return "R";


        }

        // Displaying
        public static void Display(int[,] mat, double[,] answer)
        {
            Console.WriteLine("Stu  Phy     Chem    Math    TotalAvg    %   Grade");

            for(int i = 0; i < mat.GetLength(0); i++){

                string gradeOfStudent = Grade(answer[i, 2]);

                Console.WriteLine($"{i + 1}   {mat[i, 0]}   {mat[i, 1]}   {mat[i, 2]}   " + $"{answer[i, 0]}   {answer[i, 1]} {answer[i, 2]} {gradeOfStudent}");

            }
        }

        // Calling methods
        public static void MarksAndGradesMainFunctin()
        {
            Console.Write("Enter number of students: ");

            int stu = Convert.ToInt32(Console.ReadLine());

            int[,] mat = MarksAndGradesFind(stu);
            double[,] answer = ResultsFind(mat);


            Display(mat, answer);

        }
    }
}
