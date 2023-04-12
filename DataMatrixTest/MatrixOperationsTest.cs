using DataMatrix;

namespace DataMatrixTest
{
    [TestClass]
    public class MatrixOperationsTest
    {
        [TestMethod]
        public void ElementsInSpiralOrder()
        {

        }

        [TestMethod]
        public void MainDiagonal()
        {
            int[,] input = new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2, } };
            int[] expected = new int[] { 1, 7, 2 };
            MatrixOperations matrixTrace = new MatrixOperations();
            int[] output = matrixTrace.GetMainDiagonal(input);
            CollectionAssert.AreEqual(expected, output);
        }

        [TestMethod]
        public void SecondaryDiagonal()
        {

        }

        [TestMethod]
        public void CheckIsEmpty()
        {

        }

        [TestMethod]
        public void CheckIsNull()
        {

        }

    }
}