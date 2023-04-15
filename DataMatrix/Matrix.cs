namespace DataMatrix
{
    public class Matrix
    {
        private int _rows;
        private int _cols;
        private int[,] _matrix;
        private int _trace;

        public int Rows { get => _rows; private set => _rows = value; }

        public int Cols { get => _cols; private set => _cols = value; }

        //public int Trace { get => _trace; private set => _trace = value; }

        public int this[int i, int j]
        {
            get => _matrix[i, j];
            set => _matrix[i, j] = value;
        }

        public Matrix(int rows, int cols)
        {
            ThrowIfOutOfRange(rows, cols);
            Rows = rows;
            Cols = cols;
            _matrix = new int[Rows, Cols];
        }

        public Matrix(int[,] matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            Rows = matrix.GetLength(0);
            Cols = matrix.GetLength(1);
            ThrowIfOutOfRange(Rows, Cols);
            _matrix = (int[,])matrix.Clone();
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
