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

        [DataTestMethod]
        [DataRow(new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2 } }, new int[] { 1, 7, 2 })] // Compiler Error CS0182 
        [DataRow(new int[,] { { 1, 2, 3, 4, 5 }, { 8, 7, 6, 2, 1 }, { 4, 3, 2, 8, 5 } }, new int[] { 1, 7, 2 })] // An attribute argument must be a constant expression,
        public void MainDiagonal(int[,] input, int[] expected)                                         //  typeof expression or array creation expression of an attribute parameter type
        {
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