using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceApp
{
    public class Matrix
    {
        private int colums;
        private int rows;
        public int[,] matrix;

        public Matrix(int colums, int rows)
        {
            Colums = colums;
            Rows = rows;
        }

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public int Colums
        {
            get
            {
                return colums;
            }
            private set
            {
                if (value < 2)
                {
                    Console.WriteLine("Matrix must have at least 2 colums");
                }
                else
                {
                    colums = value;
                }
            }
        }

        public int Rows
        {
            get
            {
                return rows;
            }
            private set
            {
                if (value < 2)
                {
                    Console.WriteLine("Matrix must have at least 2 rows");
                }
                else
                {
                    rows = value;
                }
            }
        }
    }
}
