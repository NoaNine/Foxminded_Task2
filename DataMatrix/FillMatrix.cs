using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceApp
{
    public class FillMatrix
    {
        private int startRange;
        private int endRange;

        public FillMatrix(int startRange, int endRange) 
        {
            this.startRange = startRange;
            this.endRange = endRange;
        }  

        public int[,] GetFilledMatrixWithRandomNumbers(int[,] matrix)
        {
            int[,] filledMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            Random random = new Random();
            for (int i = 0; i < filledMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < filledMatrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(startRange, endRange);
                }
            }
            return matrix;
        }
    }
}
