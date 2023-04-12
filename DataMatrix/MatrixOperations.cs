namespace DataMatrix
{
    public class MatrixOperations
    {
        public int[] GetElementsInSpiralOrder(int[,] matrix)
        {
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                return new int[0];
            }
            int[] elementsInSpiralOrder = new int[matrix.GetLength(0)];
            return elementsInSpiralOrder;
        }

        public int[] GetMainDiagonal(int[,] matrix)
        {
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                return new int[0];
            }
            int[] mainDiagonal = new int[matrix.GetLength(0)];
            int length = matrix.GetLength(0) <= matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
            for (int i = 0; i < length; i++)
            {
                mainDiagonal[i] = matrix[i, i];
            }
            return mainDiagonal;
        }

        public int[] GetSecondaryDiagonal(int[,] matrix)
        {
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                return new int[0];
            }
            int[] secondaryDiagonal = new int[matrix.GetLength(0)];
            int length = matrix.GetLength(0) <= matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                for (int j = length - 1, i = 0; j >= 0; i++, j--)
                {
                    secondaryDiagonal[i] = matrix[i, j];
                }
            }
            return secondaryDiagonal;
        }

    }
}