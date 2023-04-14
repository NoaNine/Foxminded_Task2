using System;
using DataMatrix;

namespace MatrixTraceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Messages.Greeting);

            InputData inputData = new InputData();
            int rows = inputData.InputRowsNumber();
            int cols = inputData.InputColsNumber();

            Matrix matrix = new Matrix(rows, cols);

            int startRange = 0;
            int endRange = 100;
            FillMatrix fillMatrix = new FillMatrix(startRange, endRange);
            fillMatrix.GetFilledMatrixWithRandomNumbers(matrix);

            Print print = new Print();
            print.PrintTwoDimensionalArray(matrix);

            MatrixOperations matrixOperations = new MatrixOperations();

            Console.WriteLine("Main diagonal: ");
            //print.PrintArray(matrixOperations.GetMainDiagonal(matrix));
            Console.WriteLine("Matrix trace: ");
            Console.WriteLine(matrixOperations.GetMatrixTrace(matrix));
            Console.WriteLine("Snail shells elements: ");
            //print.PrintArray(matrixOperations.GetElementsInSpiralOrder(matrix));
        }
    }
}
