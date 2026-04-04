using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.SortingAlgorithms
{
    internal class InsertionSort
    {
        static void InsertionSortEmployee(int[] employeeIdsArr)
        {
            int n = employeeIdsArr.Length;

            for (int i = 1; i < n; i++)
            {
                int idKey = employeeIdsArr[i];
                int j = i - 1;

                while (j >= 0 && employeeIdsArr[j] > idKey)
                {
                    employeeIdsArr[j + 1] = employeeIdsArr[j];
                    j--;
                }

                employeeIdsArr[j + 1] = idKey;
            }
        }

        public static void Main(string[] args)
        {
            int[] employeeIds = { 1005, 1003, 1002, 1004, 1001 };

            Console.WriteLine("Enter Employee IDs:");
            foreach (int id in employeeIds)
            {
                Console.Write(id + " ");
            }

            InsertionSortEmployee(employeeIds);

            Console.WriteLine("Employee IDs after sorting:");
            foreach (int id in employeeIds)
            {
                Console.Write(id + " ");
            }
        }
    }
}
