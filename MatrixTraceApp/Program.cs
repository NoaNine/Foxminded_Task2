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

            Console.WriteLine(Properties.Messages.Matrix);
            Print print = new Print();
            print.PrintTwoDimensionalArray(matrix);

            Console.WriteLine(Properties.Messages.Trace);
            Console.WriteLine(matrix.GetTrace());

            MatrixInSpiralForm matrixInSpiralForm = new MatrixInSpiralForm();
            Console.WriteLine(Properties.Messages.Snail);
            print.PrintArray(matrixInSpiralForm.GetElementsInSpiralOrder(matrix));
        }
    }
}
