using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceApp
{
    public class Matrix
    {
        public int colums;
        public int rows;
        public int[,] matrix;

        public Matrix(int colums, int rows)
        {
            this.colums = colums;
            this.rows = rows;
        }

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }
    }
}
