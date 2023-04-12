using System;
using DataMatrix;

namespace MatrixTraceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixTrace matrixTrace = new MatrixTrace();
            MatrixOperations matrix = new MatrixOperations();
            Print print = new Print();
            Console.WriteLine(Properties.Messages.Greeting);
            Console.WriteLine("Input rows matrix");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input colums matrix");
            int colums = Convert.ToInt32(Console.ReadLine());
            int range = 100;
        }
    }
}   