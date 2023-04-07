using System;

namespace MatrixTraceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixTrace matrixTrace = new MatrixTrace();
            Console.WriteLine(Properties.Messages.Greeting);
            Console.WriteLine("Input columns matrix");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input lines matrix");
            int lines = Convert.ToInt32(Console.ReadLine());
        }
    }
}