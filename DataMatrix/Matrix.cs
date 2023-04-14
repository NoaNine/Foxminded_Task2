using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMatrix
{
    public class Matrix
    {
        private int _rows;
        private int _cols;
        private int[,] _matrix;

        public int Rows { get => _rows; private set => _rows = value; }

        public int Cols { get => _cols; private set => _cols = value; }

        public int this[int i, int j]
        {
            get => _matrix[i, j];
            set => _matrix[i, j] = value;
        }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            _matrix = new int[Rows, Cols];
        }

        public Matrix(int[,] matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            Rows = matrix.GetLength(0);
            Cols = matrix.GetLength(1);
            _matrix = matrix;
        }

        private void ThrowIfOutOfRange(int rows, int cols)
        {
            if (rows <= 0 || rows > 1000 || cols <= 0 || cols > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
