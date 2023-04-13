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
            return rows;
        }

        public int InputColsNumber()
        {
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
                    inputCols = Console.ReadLine();
                }
            }
            return cols;
        }
    }
}
