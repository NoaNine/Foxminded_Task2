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
