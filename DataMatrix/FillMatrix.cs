using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMatrix
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

        public Matrix GetFilledMatrixWithRandomNumbers(Matrix matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix[i, j] = random.Next(startRange, endRange);
                }
            }
            return matrix;
        }
    }
}
