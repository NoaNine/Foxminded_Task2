using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMatrix;

namespace MatrixTraceApp
{
    public class Print
    {
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintTwoDimensionalArray(Matrix matrix)
        {
            for (int i = 0; i < matrix.Cols; i++)
            {
                for (int j = 0; j < matrix.Rows; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
