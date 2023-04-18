using DataMatrix;

namespace DataMatrixTest
{
    [TestClass]
    public class MatrixTests
    {
        [DataTestMethod]
        [DynamicData(nameof(StorageDataMatrix.InputData_MatrixTraceTest), typeof(StorageDataMatrix), DynamicDataSourceType.Method)]
        public void MatrixTrace(int[,] inputMatrix, int expectedTrace)
        {
            Matrix matrix = new Matrix(inputMatrix);
            Assert.AreEqual(expectedTrace, matrix.Trace);
        }

        [DataTestMethod]
        [DynamicData(nameof(StorageDataMatrix.InputData_InputMatrixTest), typeof(StorageDataMatrix), DynamicDataSourceType.Method)]
        public void InputMatrix(int[,] inputMatrix, Matrix expectedMatrix, int expectedRow, int expectedCols)
        {
            Matrix matrix = new Matrix(inputMatrix);
            int actualRow = matrix.Rows;
            int actualCols = matrix.Cols;
            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCols, actualCols);
            AreEqualElementArray(matrix, expectedMatrix);
        }

        [DataTestMethod]
        [DataRow(3, 3, 3, 3)]
        [DataRow(234, 393, 234, 393)]
        public void RowAndCols(int row, int cols, int expectedRow, int expectedCols)
        {
            Matrix matrix = new Matrix(row, cols);
            int actualRow = matrix.Rows;
            int actualCols = matrix.Cols;
            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCols, actualCols);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0, 3)]
        [DataRow(1, -1)]
        public void OutOfRangeRowAndCols(int row, int cols)
        {
            Matrix matrix = new Matrix(row, cols);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsNull()
        {
            Matrix matrix = new Matrix(null);
        }

        private void AreEqualElementArray(Matrix actualMatrix, Matrix expectedMatrix)
        {
            for (int i = 0; i < expectedMatrix.Rows; i++)
            {
                for (int j = 0; j < expectedMatrix.Cols; j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], actualMatrix[i, j]);
                }
            }
        }
    }
}