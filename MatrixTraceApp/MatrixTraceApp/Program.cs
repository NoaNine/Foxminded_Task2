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
            int[,] input = new int[,] { { 1, 2, 3, 4 }, { 8, 7, 6, 5 }, { 4, 3, 2, 9, } };
        }
    }
}