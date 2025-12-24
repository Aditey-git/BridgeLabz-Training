using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class BMI
    {
        public void Bmi()
        {
            //Getting Input form user 
            int number = Convert.ToInt32(Console.ReadLine());

            double[] wt = new double[number];
            double[] ht = new double[number];
            double[] BMI = new double[number];
            string[] wtStatus = new string[number];

            for(int i = 0;i < number;i++){
                Console.Write("Enter weight:");
                wt[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter height in cm:");
                ht[i] = Convert.ToDouble(Console.ReadLine());

                //Calculation 
                double newHt = ht[i] / 100;
                BMI[i] = wt[i] / (newHt * newHt);
                if(BMI[i] <= 18.4){
                    wtStatus[i] = "Underweight";
                }
                else if(BMI[i] >= 18.5 && BMI[i] <= 24.9){
                    wtStatus[i] = "Normal";
                }
                else if (BMI[i] >= 25 && BMI[i] <= 39.9){
                    wtStatus[i] = "Overweight";
                }
                else{
                    wtStatus[i] = "Obese";
                }
            }

            for(int j = 0;j < number;j++){
                Console.WriteLine($"Height is {ht[j]}, weight is {wt[j]}, Bmi is {BMI[j]} and status is {wtStatus[j]}");
            }
        }
    }
}
