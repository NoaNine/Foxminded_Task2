using DataMatrix;

namespace DataMatrixTest
{
    [TestClass]
    public class MatrixTests
    {
        [DataTestMethod]
        //[DynamicData(nameof(InputDataMatrixTraceTest), DynamicDataSourceType.Property)]
        [DataRow(new Matrix(new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2 } }), 10)]
        public void MatrixTrace(int[,] matrix, int trace)
        {

        }

        [DataTestMethod]
        public void Matrix()
        {

        }

        [DataTestMethod]
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

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0, 3)]
        [DataRow(1, -1)]
        public void OutOfRangeRowAndCols(int row, int cols)
        {
            Matrix matrix = new Matrix(row, cols);
        }

        public static IEnumerable<object[]> InputDataMatrixTraceTest
        {
            get
            {
                return new[]
                {
                    new object[] { new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2 } }, 10 },             
                    new object[] { new int[,] { { 1, 2, 3, 5, 6, 7, 8 }, { 8, 7, 6, 5, 7, 1, 2 } }, 8 }, 
                    new object[] { new int[,] { { 0, 0 }, { 0, 2 }, { 0, 0 }, { 0, 0 } }, 2 }             
                };
            }
        }
    }
}