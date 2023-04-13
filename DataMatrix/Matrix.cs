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

        public int Rows
        {
            get
            {
                return _rows;
            }
            private set
            {
                if (value < 2)
                {
                    Console.WriteLine("Matrix must have at least 2 rows");
                }
                else
                {
                    _rows = value;
                }
            }
        }

        public int Cols
        {
            get
            {
                return _cols;
            }
            private set
            {
                if (value < 2)
                {
                    Console.WriteLine("Matrix must have at least 2 colums");
                }
                else
                {
                    _cols = value;
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                return _matrix[i, j];
            }
            set
            {
                _matrix[i, j] = value;
            }
        }

        public Matrix(int rows, int cols)
        {
            if (rows >= 2 && cols >= 2)
            {
                Rows = rows;
                Cols = cols;
                _matrix = new int[Rows, Cols];
            }
        }

        public Matrix(int[,] matrix)
        {
            if (matrix.GetLength(0) >= 2 && matrix.GetLength(1) >= 2)
            {
                Rows = matrix.GetLength(0);
                Cols = matrix.GetLength(1);
                _matrix = matrix;
            }
        }
    }
}
