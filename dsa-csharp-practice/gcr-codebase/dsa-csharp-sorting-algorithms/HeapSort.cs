using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.SortingAlgorithms
{
    internal class HeapSort
    {
        static void HeapSortArray(int[] salariesArr)
        {
            int n = salariesArr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(salariesArr, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = salariesArr[0];
                salariesArr[0] = salariesArr[i];
                salariesArr[i] = temp;

                Heapify(salariesArr, i, 0);
            }
        }

        static void Heapify(int[] salariesArr, int sizeOfHeap, int rootIndex)
        {
            int largestSalary = rootIndex;
            int leftSalary = 2 * rootIndex + 1;
            int rightSalary = 2 * rootIndex + 2;

            if (leftSalary < sizeOfHeap && salariesArr[leftSalary] > salariesArr[largestSalary])
            {
                largestSalary = leftSalary;
            }

            if (rightSalary < sizeOfHeap && salariesArr[rightSalary] > salariesArr[largestSalary])
            {
                largestSalary = rightSalary;
            }

            if (largestSalary != rootIndex)
            {
                int swap = salariesArr[rootIndex];
                salariesArr[rootIndex] = salariesArr[largestSalary];
                salariesArr[largestSalary] = swap;

                Heapify(salariesArr, sizeOfHeap, largestSalary);
            }
        }

        public static void Main(string[] args)
        {
            int[] salaryDemandsArr = { 75000, 50000, 120000, 90000, 65000 };

            Console.WriteLine("Salary demands before sorting:");
            foreach (int salary in salaryDemandsArr)
            {
                Console.Write(salary + " ");
            }

            HeapSortArray(salaryDemandsArr);

            Console.WriteLine("Salary demands after sorting:");
            foreach (int salary in salaryDemandsArr)
            {
                Console.Write(salary + " ");
            }
        }
    }
}
