using System.Data.Common;

namespace DataMatrix
{
    public class MatrixOperations
    {
        public int[] GetElementsInSpiralOrder(Matrix matrix)
        {
            if (matrix.Rows < 2 || matrix.Cols < 2)
            {
                return new int[0];
            }
            int[] elementsInSpiralOrder = new int[matrix.Rows * matrix.Cols];
            int index = 0;
            int i;
            int startingColumnIndex = 0;
            int endingColumnIndex = matrix.Rows;
            int startingRowIndex = 0;
            int endingRowIndex = matrix.Cols;

            while (startingRowIndex < endingRowIndex && startingColumnIndex < endingColumnIndex)
            {
                for (i = startingColumnIndex; i < endingColumnIndex; i++)
                {
                    elementsInSpiralOrder[index] = matrix[startingRowIndex, i];
                    index++;
                }
                startingRowIndex++;

                for (i = startingRowIndex; i < endingRowIndex; i++)
                {
                    elementsInSpiralOrder[index] = matrix[i, endingColumnIndex - 1];
                    index++;
                }
                endingColumnIndex--;

                if (startingRowIndex < endingRowIndex)
                {
                    for (i = endingColumnIndex - 1; i >= startingColumnIndex; i--)
                    {
                        elementsInSpiralOrder[index] = matrix[endingRowIndex - 1, i];
                        index++;
                    }
                    endingRowIndex--;
                }

                if (startingColumnIndex < endingColumnIndex)
                {
                    for (i = endingRowIndex - 1; i >= startingRowIndex; i--)
                    {
                        elementsInSpiralOrder[index] = matrix[i, startingColumnIndex];
                        index++;
                    }
                    startingColumnIndex++;
                }
            }
            return elementsInSpiralOrder;
        }

        public int[] GetMainDiagonal(Matrix matrix)
        {
            int length = matrix.Rows <= matrix.Cols ? matrix.Rows : matrix.Cols;
            int[] mainDiagonal = new int[length];
            for (int i = 0; i < length; i++)
            {
                mainDiagonal[i] = matrix[i, i];
            }
            return mainDiagonal;
        }

        public int[] GetSecondaryDiagonal(Matrix matrix)
        {
            int length = matrix.Rows <= matrix.Cols ? matrix.Rows : matrix.Cols;
            int[] secondaryDiagonal = new int[length];
            for (int j = length - 1, i = 0; j >= 0; i++, j--)
            {
                secondaryDiagonal[i] = matrix[i, j];
            }
            return secondaryDiagonal;
        }

        public int GetMatrixTrace(Matrix matrix)
        {
            if (matrix.Rows < 2 || matrix.Cols < 2)
            {
                return 0;
            }
            int sum = 0;
            int length = matrix.Rows <= matrix.Cols ? matrix.Rows : matrix.Cols;
            for (int i = 0; i < length; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
    }
}