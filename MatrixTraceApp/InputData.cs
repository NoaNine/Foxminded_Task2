using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMatrix;

namespace MatrixTraceApp
{
    public class InputData
    {
        public int InputRowsNumber()
        {
            Console.WriteLine(Properties.Messages.InputRows);
            int rows = CheckIsNumber(Console.ReadLine());
            return rows;
        }

        public int InputColsNumber()
        {
            Console.WriteLine(Properties.Messages.InputCols);
            int cols = CheckIsNumber(Console.ReadLine());
            return cols;
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
