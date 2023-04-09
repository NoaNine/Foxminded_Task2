using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceApp
{
    public class MatrixTrace
    {
        public int[,] CreateRandomMatrix(int lines, int columns, int numberRange)
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
            return matrix;
        }

        public int[] GetSnailElements(int[,] matrix)
        {
            return new int[0];
        }

        public int[] GetMainDiagonal(int[,] matrix)
        {
            int[] mainDiagonal = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                mainDiagonal[i] = matrix[i, i];
            }
            return mainDiagonal;
        }

        public int GetMatrixTrace(int[] mainDiagonal)
        {
            return 0;
        }
    }
}
