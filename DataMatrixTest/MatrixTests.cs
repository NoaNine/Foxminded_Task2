using DataMatrix;

namespace DataMatrixTest
{
    [TestClass]
    public class MatrixTests
    {
        //[DataTestMethod]
        //[DataRow(new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2 } }, new int[] { 1, 2, 3, 6, 2, 3, 4, 8, 7 })]
        //[DataRow(new int[,] { { 1, 2, 3, 4, 5 }, { 8, 7, 6, 2, 1 }, { 4, 3, 2, 8, 5 } }, new int[] { 1, 2, 3, 4, 5, 1, 5, 8, 2, 3, 4, 8, 7, 6, 2 })]
        //public void ElementsInSpiralOrder(Matrix input, int[] expected)
        //{
        //    MatrixDiagonal matrixTrace = new MatrixDiagonal();
        //    int[] output = matrixTrace.GetMainDiagonal(input);
        //    CollectionAssert.AreEqual(expected, output);
        //}

        //[DataTestMethod]
        //[DataRow(new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2 } }, new int[] { 1, 7, 2 })]
        //[DataRow(new int[,] { { 1, 2, 3, 4, 5 }, { 8, 7, 6, 2, 1 }, { 4, 3, 2, 8, 5 } }, new int[] { 1, 7, 2 })]
        //public void MainDiagonal(Matrix input, int[] expected)
        //{
        //    MatrixDiagonal matrixTrace = new MatrixDiagonal();
        //    int[] output = matrixTrace.GetMainDiagonal(input);
        //    CollectionAssert.AreEqual(expected, output);
        //}

        [TestMethod]
        [DataRow(3, 3, 3, 3)]
        [DataRow(46, 31, 46, 31)]
        [DataRow(234, 393, 234, 393)]
        public void RowAndCols(int row, int cols, int expectedRow, int expectedCols)
        {
            Matrix matrix = new Matrix(row, cols);
            int actualRow = matrix.Rows;
            int actualCols = matrix.Cols;
            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCols, actualCols);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0, 3)]
        [DataRow(1, -1)]
        public void OutOfRangeRowAndCols(int row, int cols)
        {
            Matrix matrix = new Matrix(row, cols);
        }

        [TestMethod]
        //[DataRow(new Matrix(new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2 } }), 10)]
        public void MatrixTrace(Matrix matrix, int trace)
        {

        }

    }
}