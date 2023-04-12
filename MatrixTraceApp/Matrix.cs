using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceApp
{
    public class Matrix
    {
        private int _colums;
        private int _rows;
        public int[,] matrix;

        public int Colums
        {
            get
            {
                return _colums;
            }
            private set
            {
                if (value < 2)
                {
                    Console.WriteLine("Matrix must have at least 2 colums");
                }
                else
                {
                    _colums = value;
                }
            }
        }

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

        public Matrix(int colums, int rows)
        {
            Colums = colums;
            Rows = rows;
        }

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }
    }
}
