using DataMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraceApp
{
    public class MatrixInSpiralForm
    {
        public int[] GetElementsInSpiralOrder(Matrix matrix)
        {
            int[] elementsInSpiralOrder = new int[matrix.Rows * matrix.Cols];
            int index = 0;
            int startCols = 0;
            int endRow = matrix.Rows;
            int startRow = 0;
            int endCols = matrix.Cols;

            while (startRow < endRow && startCols < endCols)
            {
                FirstRow(elementsInSpiralOrder, matrix, startCols, endCols, ref startRow, ref index);
                LastCol(elementsInSpiralOrder, matrix, startRow, endRow, ref endCols, ref index);
                LastRow(elementsInSpiralOrder, matrix, startCols, endCols, startRow, ref endRow, ref index);
                FirstCol(elementsInSpiralOrder, matrix, startRow, endRow, endCols, ref startCols, ref index);
            }
            return elementsInSpiralOrder;
        }

        private void FirstRow(int[] elementsInSpiralOrder, Matrix matrix, int startCols, int endCols, ref int startRow, ref int index)
        {
            for (int i = startCols; i < endCols; i++)
            {
                elementsInSpiralOrder[index] = matrix[startRow, i];
                index++;
            }
            startRow++;
        }

        private void LastCol(int[] elementsInSpiralOrder, Matrix matrix, int startRow, int endRow, ref int endCols, ref int index)
        {
            for (int i = startRow; i < endRow; i++)
            {
                elementsInSpiralOrder[index] = matrix[i, endCols - 1];
                index++;
            }
            endCols--;
        }

        private void LastRow(int[] elementsInSpiralOrder, Matrix matrix, int startCols, int endCols, int startRow, ref int endRow, ref int index)
        {
            if (startRow < endRow)
            {
                for (int i = endCols - 1; i >= startCols; i--)
                {
                    elementsInSpiralOrder[index] = matrix[endRow - 1, i];
                    index++;
                }
                endRow--;
            }
        }

        private void FirstCol(int[] elementsInSpiralOrder, Matrix matrix, int startRow, int endRow, int endCols, ref int startCols, ref int index)
        {
            if (startCols < endCols)
            {
                for (int i = endRow - 1; i >= startRow; i--)
                {
                    elementsInSpiralOrder[index] = matrix[i, startCols];
                    index++;
                }
                startCols++;
            }
        }
    }
}
