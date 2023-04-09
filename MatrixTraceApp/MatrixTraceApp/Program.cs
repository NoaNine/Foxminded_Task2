using System;

namespace MatrixTraceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixTrace matrixTrace = new MatrixTrace();
            Print print = new Print();
            Console.WriteLine(Properties.Messages.Greeting);
            Console.WriteLine("Input lines matrix");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input colums matrix");
            int colums = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = matrixTrace.CreateRandomMatrix(lines, colums);
            print.PrintMatrix(matrix);
            int[,] input1 = new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2, } };
            int[,] input2 = new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2, } };
        }
    }
}