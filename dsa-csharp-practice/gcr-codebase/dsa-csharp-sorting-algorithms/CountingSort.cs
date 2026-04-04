using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.SortingAlgorithms
{
    internal class CountingSort
    {
        static void CountingSortArray(int[] agesArr)
        {
            int minimumAge = 10;
            int maximumAge = 18;
            int rangeArr = maximumAge - minimumAge + 1;

            int[] countArr = new int[rangeArr];
            int[] outputArr = new int[agesArr.Length];

            for (int i = 0; i < agesArr.Length; i++)
            {
                countArr[agesArr[i] - minimumAge]++;
            }

            for (int i = 1; i < rangeArr; i++)
            {
                countArr[i] += countArr[i - 1];
            }

            for (int i = agesArr.Length - 1; i >= 0; i--)
            {
                int ageOfStudent = agesArr[i];
                outputArr[countArr[ageOfStudent - minimumAge] - 1] = ageOfStudent;
                countArr[ageOfStudent - minimumAge]--;
            }

            for (int i = 0; i < agesArr.Length; i++)
            {
                agesArr[i] = outputArr[i];
            }
        }

        public static void Main(string[] args)
        {
            int[] studentAgesArr = { 12, 15, 11, 18, 14, 10, 16, 13, 15 };

            Console.WriteLine("Student ages before sorting:");
            foreach (int ageOfStudent in studentAgesArr)
            {
                Console.Write(ageOfStudent + " ");
            }

            CountingSortArray(studentAgesArr);

            Console.WriteLine("Student ages after sorting:");
            foreach (int ageOfStudent in studentAgesArr)
            {
                Console.Write(ageOfStudent + " ");
            }
        }
    }
}
