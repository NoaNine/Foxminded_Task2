using MatrixTraceApp;

namespace MatrixTraceAppTest
{
    [TestClass]
    public class MatrixInSpiralFormTests
    {
        [TestMethod]
        public void QuickTest()
        {
            int[,] input = new int[,] { { 1, 2, 3, 4 }, { 8, 7, 6, 5 }, { 4, 3, 2, 9, } };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 9, 2, 3, 4, 8, 7, 6 };
            MatrixTraceApp.InputData matrixTrace = new MatrixTraceApp.InputData();
            int[] output;
            //Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void MatrixTrace()
        {
            int[,] input = new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2, } };
            int expected = 10;
            MatrixTraceApp.InputData matrixTrace = new MatrixTraceApp.InputData();
            int output;
            //Assert.AreEqual(expected, output);
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