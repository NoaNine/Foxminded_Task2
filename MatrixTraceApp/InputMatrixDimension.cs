namespace MatrixTraceApp
{
    public class InputMatrixDimension
    {
        public int InputRowsNumber()
        {
            Console.WriteLine(Properties.Messages.InputRows);
            return CheckIsNumber(Console.ReadLine());
        }

        public int InputColsNumber()
        {
            Console.WriteLine(Properties.Messages.InputCols);
            return CheckIsNumber(Console.ReadLine());
        }

        private int CheckIsNumber(string input)
        {
            int num;
            while (true)
            {
                if (int.TryParse(input, out num) && num > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Must be only a positive number");
                    input = Console.ReadLine();
                }
            }
            return num;
        }
    }
}
