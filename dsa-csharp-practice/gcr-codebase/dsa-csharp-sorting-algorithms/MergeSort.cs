using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.SortingAlgorithms
{
    internal class MergeSort
    {
        static void MergeSortBookPrices(int[] pricesArr, int leftElement, int rightElement)
        {
            if (leftElement < rightElement)
            {
                int midElement = leftElement + (rightElement - leftElement) / 2;

                MergeSortBookPrices(pricesArr, leftElement, midElement);

                MergeSortBookPrices(pricesArr, midElement + 1, rightElement);

                Merge(pricesArr, leftElement, midElement, rightElement);
            }
        }

        static void Merge(int[] pricesArr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] LeftArr = new int[n1];
            int[] RightArr = new int[n2];

            for (int i = 0; i < n1; i++)
                LeftArr[i] = pricesArr[left + i];

            for (int j = 0; j < n2; j++)
                RightArr[j] = pricesArr[mid + 1 + j];

            int iInd = 0, jInd = 0, k = left;

            while (iInd < n1 && jInd < n2)
            {
                if (LeftArr[iInd] <= RightArr[jInd])
                {
                    pricesArr[k] = LeftArr[iInd];
                    iInd++;
                }
                else
                {
                    pricesArr[k] = RightArr[jInd];
                    jInd++;
                }
                k++;
            }

            // Copy remaining elements
            while (iInd < n1)
            {
                pricesArr[k] = LeftArr[iInd];
                iInd++;
                k++;
            }

            while (jInd < n2)
            {
                pricesArr[k] = RightArr[jInd];
                jInd++;
                k++;
            }
        }

        public static void Main(string[] args)
        {
            int[] bookPricesArr = { 450, 299, 799, 150, 999, 399 };

            Console.WriteLine("Book prices before sorting:");
            foreach (int price in bookPricesArr)
            {
                Console.Write(price + " ");
            }

            MergeSortBookPrices(bookPricesArr, 0, bookPricesArr.Length - 1);

            Console.WriteLine("\n\nBook prices after sorting (Ascending Order):");
            foreach (int price in bookPricesArr)
            {
                Console.Write(price + " ");
            }
        }
    }
}
