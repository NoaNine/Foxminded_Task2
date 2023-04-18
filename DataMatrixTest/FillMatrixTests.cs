using DataMatrix;

namespace DataMatrixTest
{
    [TestClass]
    public class FillMatrixTests
    {
        [TestMethod]
        public void AllMatrixElementsSameNumber()
        {
            int size = 3;
            int range = 5;
            Matrix matrix = new Matrix(size, size);
            FillMatrix fillMatrix = new FillMatrix(range, range);
            fillMatrix.GetFilledMatrixWithRandomNumbers(matrix);
            AreEqualElementArray(range, matrix);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentException()
        {
            FillMatrix fillMatrix = new FillMatrix(3, 2);
        }

        private void AreEqualElementArray(int expectedNumber, Matrix actualMatrix)
        {
            for (int i = 0; i < actualMatrix.Rows; i++)
            {
                for (int j = 0; j < actualMatrix.Cols; j++)
                {
                    Assert.AreEqual(expectedNumber, actualMatrix[i, j]);
                }
            }
        }
    }
}
