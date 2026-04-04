using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level1
{
    internal class TwoDimensionalArray
    {
        public static void convert2DArray(){
            //Getting user Input
            Console.Write("Enter rows:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter columns:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m,n];

            Console.WriteLine("Enter elements of the matrix:");
            for(int i = 0; i < m; i++){
                for(int j = 0; j < n; j++){
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] arr = new int[m * n];
            int arrIndex = 0;

            // Copying the 2D array into 1D array
            for (int i = 0;i < m;i++){
                for (int j = 0;j < n;j++){
                    arr[arrIndex] = matrix[i, j];
                    arrIndex++;
                }
            }

            // Displaying the resultant 1D array
            Console.WriteLine("1D Array elements:");
            for (int i = 0;i < arr.Length;i++){
                Console.WriteLine(arr[i]);
            }

        }
    }
}
