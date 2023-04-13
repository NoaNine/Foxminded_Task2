using System;
using DataMatrix;

namespace MatrixTraceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixTrace matrixTrace = new MatrixTrace();
            Console.WriteLine(Properties.Messages.Greeting);

            Console.WriteLine(Properties.Messages.InputRows);
            string inputRows = Console.ReadLine();
            int rows;
            while (true)
            {
                if (int.TryParse(inputRows, out rows) && rows > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Must be only a positive number");
                    inputRows = Console.ReadLine();
                }
            }

            Console.WriteLine(Properties.Messages.InputCols);
            string inputCols = Console.ReadLine();
            int cols;
            while (true)
            {
                if (int.TryParse(inputCols, out cols) && cols > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Must be only a positive number");
                }
            }
            int startRange = 0;
            int endRange = 100;
        }
    }
}