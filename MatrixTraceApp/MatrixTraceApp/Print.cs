using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceApp
{
    public class Print
    {
        public void PrintArray(int[] snailElements)
        {
            for (int i = 0; i < snailElements.Length; i++)
            {
                Console.WriteLine(snailElements[i] + " ");
            }
        }

        public void PrintTwoDimensionalArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
