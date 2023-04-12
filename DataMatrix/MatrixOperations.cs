using System.Data.Common;

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
            int[] elementsInSpiralOrder = new int[matrix.GetLength(0)*matrix.GetLength(1)];
            int index = 0;
            int i;
            int startingColumnIndex = 0;
            int endingColumnIndex = matrix.GetLength(0);
            int startingRowIndex = 0;
            int endingRowIndex = matrix.GetLength(1);

            while (startingRowIndex < endingRowIndex && startingColumnIndex < endingColumnIndex)
            {
                for (i = startingColumnIndex; i < endingColumnIndex; i++)
                {
                    elementsInSpiralOrder[index] = matrix[startingRowIndex, i];
                }
                startingRowIndex++;

                for (i = startingRowIndex; i < endingRowIndex; i++)
                {
                    elementsInSpiralOrder[index] = matrix[i, endingColumnIndex - 1];
                }
                endingColumnIndex--;

                if (startingRowIndex < endingRowIndex)
                {
                    for (i = endingColumnIndex - 1; i >= startingColumnIndex; i--)
                    {
                        elementsInSpiralOrder[index] = matrix[endingRowIndex - 1, i];
                    }
                    endingRowIndex--;
                }

                if (startingColumnIndex < endingColumnIndex)
                {
                    for (i = endingRowIndex - 1; i >= startingRowIndex; i--)
                    {
                        elementsInSpiralOrder[index] = matrix[i, startingColumnIndex];
                    }
                    startingColumnIndex++;
                }
            }
            return elementsInSpiralOrder;
        }

        public int[] GetMainDiagonal(int[,] matrix)
        {
            //if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            //{
            //    return new int[0];
            //}
            //int[] mainDiagonal = new int[matrix.GetLength(0)];
            //int length = matrix.GetLength(0) <= matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
            //for (int i = 0; i < length; i++)
            //{
            //    mainDiagonal[i] = matrix[i, i];
            //}
            //return mainDiagonal;
            try
            {
                if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
                {
                    throw new Exception("Matrix must not be less than 2x2");
                }
                int[] mainDiagonal = new int[matrix.GetLength(0)];
                int length = matrix.GetLength(0) <= matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
                for (int i = 0; i < length; i++)
                {
                    mainDiagonal[i] = matrix[i, i];
                }
                return mainDiagonal;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
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