using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMatrix;

namespace MatrixTraceApp
{
    public class MatrixTrace
    {
        public int GetMatrixTrace(int[,] matrix)
        {
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                return 0;
            }
            MatrixOperations matrixArray = new MatrixOperations();
            int[] elementsMaidDiagonal = matrixArray.GetMainDiagonal(matrix);
            int sum = 0;
            for (int i = 0; i < elementsMaidDiagonal.Length; i++)
            {
                sum += elementsMaidDiagonal[i];
            }
            return sum;
        }
    }
}
