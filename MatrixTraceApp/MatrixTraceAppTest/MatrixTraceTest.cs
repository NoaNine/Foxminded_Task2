using MatrixTraceApp;

namespace MatrixTraceAppTest
{
    [TestClass]
    public class MatrixTraceTest
    {
        [TestMethod]
        public void QuickTest()
        {
            int[,] input = new int[,] { { 1, 2, 3, 4 }, { 8, 7, 6, 5 }, { 4, 3, 2, 9, } }; ;
            int[] expected = new int[] { 1, 2, 3, 4, 5, 9, 2, 3, 4, 8, 7, 6 };
            MatrixTrace matrixTrace = new MatrixTrace();
            int[] output;
            Assert.AreEqual(expected, output);
        }
    }
}