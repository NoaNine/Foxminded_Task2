using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceApp
{
    public class MatrixTrace
    {
        public int[,] CreateRandomMatrix(int lines, int columns)
        {
            int[,] matrix = new int[lines, columns];
            Random random = new Random();
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(100);
                }
            }
            return matrix;
        }

        private int[] GetSnailElements(int[,] matrix)
        {
            return new int[0];
        }

        private int[] GetMainDiagonal(int[,] matrix)
        {
            return new int[0];
        }

        private int[] GetSecondaryDiagonal(int[,] matrix)
        {
            return new int[0];
        }

        private int GetMatrixTrace(int[] mainDiagonal)
        {
            return 0;
        }
    }
}
