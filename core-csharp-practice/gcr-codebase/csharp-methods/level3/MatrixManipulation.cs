using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level3
{
    internal class MatrixManipulation
    {
        public static double[,] CreateMatrix(int rows, int cols){


            double[,] matrix = new double[rows, cols];
            Random randomGen = new Random();

            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = randomGen.Next(1, 10);

            return matrix;

        }


        public static double[,] Addition(double[,] firstMatrix, double[,] secondMatrix){


            int rows = firstMatrix.GetLength(0);
            int cols = firstMatrix.GetLength(1);
            double[,] resultMatrix = new double[rows, cols];

            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    resultMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];

            return resultMatrix;

        }


        public static double[,] Subtraction(double[,] firstMatrix, double[,] secondMatrix){

            int rows = firstMatrix.GetLength(0);
            int cols = firstMatrix.GetLength(1);
            double[,] resultMatrix = new double[rows, cols];

            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    resultMatrix[row, col] = firstMatrix[row, col] - secondMatrix[row, col];

            return resultMatrix;

        }


        public static double[,] Multiplication(double[,] leftMatrix, double[,] rightMatrix){

            int leftRows = leftMatrix.GetLength(0);
            int leftCols = leftMatrix.GetLength(1);
            int rightCols = rightMatrix.GetLength(1);

            double[,] productMatrix = new double[leftRows, rightCols];

            for (int row = 0; row < leftRows; row++)
                for (int col = 0; col < rightCols; col++)
                    for (int idx = 0; idx < leftCols; idx++)
                        productMatrix[row, col] += leftMatrix[row, idx] * rightMatrix[idx, col];

            return productMatrix;

        }


        public static double[,] TransposeOfMatrix(double[,] originalMatrix){

            int rows = originalMatrix.GetLength(0);
            int cols = originalMatrix.GetLength(1);
            double[,] transposedMatrix = new double[cols, rows];


            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    transposedMatrix[col, row] = originalMatrix[row, col];

            return transposedMatrix;

        }


        public static double DeterminantTwo(double[,] matrix){

            return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);

        }


        public static double DeterminantThree(double[,] matrix)
        {

            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                   matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                   matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

        }


        public static double[,] InverseTwo(double[,] matrix){

            double determinant = DeterminantTwo(matrix);
            if (determinant == 0) return null;

            double[,] inverseMatrix = new double[2, 2];

            inverseMatrix[0, 0] = matrix[1, 1] / determinant;
            inverseMatrix[0, 1] = -matrix[0, 1] / determinant;
            inverseMatrix[1, 0] = -matrix[1, 0] / determinant;
            inverseMatrix[1, 1] = matrix[0, 0] / determinant;

            return inverseMatrix;

        }


        public static double[,] InverseThree(double[,] matrix){

            double determinant = DeterminantThree(matrix);
            if (determinant == 0) return null;

            double[,] inverseMatrix = new double[3, 3];

            inverseMatrix[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / determinant;
            inverseMatrix[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / determinant;
            inverseMatrix[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / determinant;

            inverseMatrix[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / determinant;
            inverseMatrix[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / determinant;
            inverseMatrix[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / determinant;

            inverseMatrix[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / determinant;
            inverseMatrix[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / determinant;
            inverseMatrix[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / determinant;

            return inverseMatrix;

        }


        public static void Display(double[,] matrix){

            for (int row = 0; row < matrix.GetLength(0); row++){
                for (int col = 0; col < matrix.GetLength(1); col++){
                    Console.Write($"{matrix[row, col],6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static void MatrixMul(){

            double[,] firstMatrix = CreateMatrix(3, 3);
            double[,] secondMatrix = CreateMatrix(3, 3);

            Console.WriteLine("Matrix A:");
            Display(firstMatrix);
            Console.WriteLine("Matrix B:");
            Display(secondMatrix);
            Console.WriteLine("A + B:");
            Display(Addition(firstMatrix, secondMatrix));
            Console.WriteLine("A - B:");
            Display(Subtraction(firstMatrix, secondMatrix));
            Console.WriteLine("A * B:");
            Display(Multiplication(firstMatrix, secondMatrix));
            Console.WriteLine("Transpose of A:");
            Display(TransposeOfMatrix(firstMatrix));
            Console.WriteLine($"Determinant of A: {DeterminantThree(firstMatrix)}");
            Console.WriteLine("Inverse A:");
            double[,] inverseResult = InverseThree(firstMatrix);

            if (inverseResult != null)
                Display(inverseResult);
            else
                Console.WriteLine("Not exist");

        }

    }
    }
