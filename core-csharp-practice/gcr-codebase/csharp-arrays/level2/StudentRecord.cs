using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class StudentRecord
    {
        public static void Student()
        {
            // Getting input from the user
            Console.Write("Enter number of students: ");
            int num = Convert.ToInt32(Console.ReadLine());

            double[] physics = new double[num];
            double[] chemistry = new double[num];
            double[] maths = new double[num];
            double[] percentageArr = new double[num];
            char[] gradeArr = new char[num];

            for(int i = 0;i < num;i++){
                Console.Write("Physics: ");
                physics[i] = Convert.ToDouble(Console.ReadLine());
                if(physics[i] < 0){
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }

                Console.Write("Chemistry: ");
                chemistry[i] = Convert.ToDouble(Console.ReadLine());
                if(chemistry[i] < 0){
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }

                Console.Write("Maths: ");
                maths[i] = Convert.ToDouble(Console.ReadLine());
                if(maths[i] < 0){
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }

                // Calculations
                double total = physics[i] + chemistry[i] + maths[i];
                percentageArr[i] = total / 3;

                if (percentageArr[i] >= 80) gradeArr[i] = 'A';
                else if (percentageArr[i] >= 70) gradeArr[i] = 'B';
                else if (percentageArr[i] >= 60) gradeArr[i] = 'C';
                else if (percentageArr[i] >= 50) gradeArr[i] = 'D';
                else if (percentageArr[i] >= 40) gradeArr[i] = 'E';
                else gradeArr[i] = 'R';
            }

            // Displaying the result
            for(int i = 0; i < num; i++){
                Console.WriteLine($"Student {i + 1} Percentage = {percentageArr[i]}%, Grade = {gradeArr[i]}");
            }
        }
    }
}
