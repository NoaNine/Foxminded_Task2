namespace DataMatrix
{
    public class FillMatrix
    {
        private Random _random = new Random();
        private int _startRange;
        private int _endRange;

        public FillMatrix(int startRange, int endRange)
        {
            if (startRange > endRange)
            {
                throw new ArgumentException();
            }
            _startRange = startRange;
            _endRange = endRange + 1;
        }

        public Matrix GetFilledMatrixWithRandomNumbers(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix[i, j] = _random.Next(_startRange, _endRange);
                }
            }
            return matrix;
        }
    }
}
