namespace DataMatrix
{
    public class FillMatrix
    {
        private int startRange;
        private int endRange;

        public FillMatrix(int startRange, int endRange)
        {
            ThrowIfOutOfRange(startRange, endRange);
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

        private void ThrowIfOutOfRange(int startRange, int endRange)
        {
            if (startRange < 0 || startRange > 100 || endRange < 0 || endRange > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
