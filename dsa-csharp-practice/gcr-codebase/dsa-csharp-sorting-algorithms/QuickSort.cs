using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.SortingAlgorithms
{
    internal class QuickSort
    {
        static void QuickSortArray(int[] pricesArr, int lowInd, int highInd)
        {
            if (lowInd < highInd)
            {
                int pivotInd = PartitionArray(pricesArr, lowInd, highInd);

                QuickSortArray(pricesArr, lowInd, pivotInd - 1);
                QuickSortArray(pricesArr, pivotInd + 1, highInd);
            }
        }

        static int PartitionArray(int[] pricesArr, int lowEle, int highEle)
        {
            int pivot = pricesArr[highEle]; // Pivot element
            int i = lowEle - 1;

            for (int j = lowEle; j < highEle; j++)
            {
                if (pricesArr[j] < pivot)
                {
                    i++;
                    Swap(pricesArr, i, j);
                }
            }

            Swap(pricesArr, i + 1, highEle);
            return i + 1;
        }

        static void Swap(int[] pricesArr, int i, int j)
        {
            int temp = pricesArr[i];
            pricesArr[i] = pricesArr[j];
            pricesArr[j] = temp;
        }

        public static void Main(string[] args)
        {
            int[] productPricesArr = { 999, 450, 1299, 299, 799, 1599 };

            Console.WriteLine("Product prices before sorting:");
            foreach (int price in productPricesArr)
            {
                Console.Write(price + " ");
            }

            QuickSortArray(productPricesArr, 0, productPricesArr.Length - 1);

            Console.WriteLine("Product prices after sorting:");
            foreach (int price in productPricesArr)
            {
                Console.Write(price + " ");
            }
        }
    }
}
