using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixOperations;

namespace MatrixTraceApp
{
    public class MatrixTrace
    {
        public void CreateRandomMatrix(int lines, int columns, int numberRange)
        {
            int[,] matrix = new int[lines, columns];
            Random random = new Random();
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(numberRange);
                }
            }
        }

        public int GetMatrixTrace(int[] mainDiagonal)
        {
            int sum = 0;
            for (int i = 0; i < mainDiagonal.Length; i++)
            {
                sum += mainDiagonal[i];
            }
            return sum;
        }
    }
}
