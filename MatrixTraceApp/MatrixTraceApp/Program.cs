using System;
using MatrixOperations;

namespace MatrixTraceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixTrace matrixTrace = new MatrixTrace();
            DataMatrix dataMatrix = new DataMatrix();
            Print print = new Print();
            Console.WriteLine(Properties.Messages.Greeting);
            Console.WriteLine("Input lines matrix");
            //int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input colums matrix");
            //int colums = Convert.ToInt32(Console.ReadLine());
            //int numberRandomRange = 10;
            //int[,] matrix = matrixTrace.CreateRandomMatrix(lines, colums, numberRandomRange);
            //print.PrintMatrix(matrix);
            int[,] input1 = new int[,] { { 1, 2, 3, 4}, { 8, 7, 6, 5 }, { 4, 3, 2, 9 } };
            int[,] input2 = new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2, } };
            int[] mainDiagonal = dataMatrix.GetMainDiagonal(input1);
            print.PrintArray(mainDiagonal);
        }
    }
}