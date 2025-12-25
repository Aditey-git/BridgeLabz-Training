using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class RandomAverage
    {
        public static void RandomAvg() {            
            int[] randomNumberArr = RandomArrayGenerate(5);

            Console.WriteLine("Generated 4-digit random numbers:");
            for (int i = 0; i < randomNumberArr.Length; i++){
                Console.WriteLine(randomNumberArr[i]);
            }

            double[] resultArr = FindAverageMinMax(randomNumberArr);
            //Display the results
            Console.WriteLine("Average value = " + resultArr[0]);
            Console.WriteLine("Minimum value = " + resultArr[1]);
            Console.WriteLine("Maximum value = " + resultArr[2]);
        }

        //Method to generate 4-digit random numbers array
        public static int[] RandomArrayGenerate(int s){
            int[] num = new int[s];
            Random random = new Random();

            for (int i = 0; i < s; i++){
                num[i] = random.Next(1000, 10000);
            }

            return num;
        }

        //Method to find average, min and max
        public static double[] FindAverageMinMax(int[] nums){
            int minimum = nums[0];
            int maximum = nums[0];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++){
                sum += nums[i];
                minimum = Math.Min(minimum, nums[i]);
                maximum = Math.Max(maximum, nums[i]);
            }
            double avg = (double)sum / nums.Length;
            return new double[] { avg, minimum, maximum };
        }

    }
}
