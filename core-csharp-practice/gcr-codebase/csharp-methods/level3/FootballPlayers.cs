using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class FootballPlayers
    {
        public static void HeightCompare() {
            int[] heightsArr = new int[11];

            Random random = new Random();
            for (int i = 0; i < heightsArr.Length; i++){
                heightsArr[i] = random.Next(150, 251);
            }

            Console.WriteLine("Heights of Players:");
            foreach (int h in heightsArr){
                Console.Write(h + " ");
            }
            Console.WriteLine();



            //Calling methods
            int sumOfHeight = FindSum(heightsArr);
            double meanOfHeight = FindMean(heightsArr);
            int shortestPlayer = FindShortest(heightsArr);
            int tallestPlayer = FindTallest(heightsArr);



            Console.WriteLine("\nResults:");
            Console.WriteLine("Shortest Height: " + shortestPlayer + " cm");
            Console.WriteLine("Tallest Height: " + tallestPlayer + " cm");
            Console.WriteLine("Mean Height: " + meanOfHeight + " cm");
        }


        //Method to find sum
        static int FindSum(int[] arrHeight){
            int addition = 0;
            for (int i = 0; i < arrHeight.Length; i++){
                addition += arrHeight[i];
            }
            return addition;
        }

        //Method to find mean
        static double FindMean(int[] arrHeight){
            int sum = FindSum(arrHeight);
            return (double) sum / arrHeight.Length;
        }

        // Method to find shortest height
        static int FindShortest(int[] arrHeight){
            int minimum = arrHeight[0];

            for (int i = 1; i < arrHeight.Length; i++){
                if (arrHeight[i] < minimum) minimum = arrHeight[i];
            }


            return minimum;
        }

        // Method to find tallest height
        static int FindTallest(int[] arrHeight){

            int maximum = arrHeight[0];
            for (int i = 1; i < arrHeight.Length; i++){
                if (arrHeight[i] > maximum) maximum = arrHeight[i];
            }

            return maximum;
        }
    }
}
