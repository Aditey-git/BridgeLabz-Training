using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.SortingAlgorithms
{
    internal class BubbleSort
    {
        static void BubbleSortMarks(int[] marksArr)
        {
            int n = marksArr.Length;
            bool swappedOrNot;

            for (int i = 0; i < n - 1; i++)
            {
                swappedOrNot = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marksArr[j] > marksArr[j + 1])
                    {
                        int temp = marksArr[j];
                        marksArr[j] = marksArr[j + 1];
                        marksArr[j + 1] = temp;

                        swappedOrNot = true;
                    }
                }
                if (!swappedOrNot)
                    break;
            }
        }

        public static void Main(string[] args)
        {
            int[] studentMarksArr = { 79, 46, 84, 63, 55, 95 };

            Console.WriteLine("Enter the marks: ");
            foreach (int studentMark in studentMarksArr)
            {
                Console.Write(studentMark + " ");
            }

            BubbleSortMarks(studentMarksArr);

            Console.WriteLine("\n\nMarks after sorting: ");
            foreach (int studentMark in studentMarksArr)
            {
                Console.Write(studentMark + " ");
            }
        }
    }
}
