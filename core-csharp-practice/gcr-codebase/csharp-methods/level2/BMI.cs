using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class BMI
    {
        public static void BMIfn() {
            //
            double[,] personDetails = new double[10, 3];

            //Getting input from user
            for (int i = 0; i < 10; i++){
                Console.WriteLine($"Enter details for Person {i + 1}");

                Console.Write("Enter weight of the person: ");
                personDetails[i, 0] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter height of the person: ");
                personDetails[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

            //Calling the Methods
            BMICalculate(personDetails);
            string[] status = GetStatus(personDetails);

            Console.WriteLine("\nBMI Report:");
            for(int i = 0; i < 10; i++){
                Console.WriteLine($"BMI = {personDetails[i, 2]}, Status = {status[i]}");
            }
        }



        //Method to calculate BMI
        public static void BMICalculate(double[,] data){
            for (int i = 0; i < 10; i++){
                double weightOfPerson = data[i, 0];
                double height = data[i, 1];

                double heightMeter = height / 100;

                data[i, 2] = weightOfPerson/(heightMeter * heightMeter);
            }
        }

        //Method to find BMI status
        public static string[] GetStatus(double[,] details){
            string[] BMIstatus = new string[10];

            for (int i = 0; i < 10; i++){
                double BMI = details[i, 2];

                if (BMI <= 18.4) BMIstatus[i] = "Underweight";
                else if (BMI >= 18.5 && BMI <= 24.9) BMIstatus[i] = "Normal";
                else if (BMI >= 25.0 && BMI <= 39.9) BMIstatus[i] = "Overweight";
                else BMIstatus[i] = "Obese";
            }

            return BMIstatus;
        }
    }
}
