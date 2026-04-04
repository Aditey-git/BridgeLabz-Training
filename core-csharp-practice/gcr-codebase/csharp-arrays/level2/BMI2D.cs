using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class BMI2D
    {
        public void BmiCal()
        {
            // Getting Input from user 
            int number = Convert.ToInt32(Console.ReadLine());
            double[][] person = new double[number][];
            string[] wtStatus = new string[number];

            for (int i = 0; i < number; i++)
            {
                person[i] = new double[3];
                Console.Write("Enter weight:");
                person[i][0] = Convert.ToDouble(Console.ReadLine());
                while(person[i][0] <= 0){
                    Console.Write("Enter positive weight:");
                    person[i][0] = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("Enter height in cm:");
                person[i][1] = Convert.ToDouble(Console.ReadLine());
                while(person[i][1] <= 0){
                    Console.Write("Enter height:");
                    person[i][1] = Convert.ToDouble(Console.ReadLine());
                }

                // Calculations for BMI status
                double newHt = person[i][1] / 100;
                person[i][2] = person[i][0] / (newHt * newHt);

                if(person[i][2] <= 18.4){
                    wtStatus[i] = "Underweight";
                }
                else if (person[i][2] >= 18.5 && person[i][2] <= 24.9){
                    wtStatus[i] = "Normal";
                }
                else if (person[i][2] >= 25 && person[i][2] <= 39.9){
                    wtStatus[i] = "Overweight";
                }
                else{
                    wtStatus[i] = "Obese";
                }
            }

            for(int j = 0;j < number;j++){
                Console.WriteLine($"Height is {person[j][1]}, weight is {person[j][0]}, Bmi is {person[j][2]} and status is {wtStatus[j]}");
            }
        }
    }
}
