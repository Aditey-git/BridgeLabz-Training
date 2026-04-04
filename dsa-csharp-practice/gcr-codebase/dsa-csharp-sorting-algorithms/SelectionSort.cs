using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.SortingAlgorithms
{
    internal class SelectionSort
    {
        static void SelectionSortArray(int[] scoresArr)
        {
            int n = scoresArr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minimumIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (scoresArr[j] < scoresArr[minimumIndex])
                    {
                        minimumIndex = j;
                    }
                }

                if (minimumIndex != i)
                {
                    int temp = scoresArr[i];
                    scoresArr[i] = scoresArr[minimumIndex];
                    scoresArr[minimumIndex] = temp;
                }
            }
        }

        static void Main()
        {
            int[] examScoresArr = { 78, 48, 90, 62, 55 };

            Console.WriteLine("Exam scores before sorting:");
            foreach (int scoreInExam in examScoresArr)
            {
                Console.Write(scoreInExam + " ");
            }

            SelectionSortArray(examScoresArr);

            Console.WriteLine("Exam scores after sorting:");
            foreach (int score in examScoresArr)
            {
                Console.Write(score + " ");
            }
        }
    }
}
