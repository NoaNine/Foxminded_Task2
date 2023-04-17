using MatrixTraceApp;

namespace MatrixTraceAppTest
{
    [TestClass]
    public class MatrixInSpiralFormTests
    {
        [TestMethod]
        public void ElementsInSpiralOrder()
        {
            int[,] input = new int[,] { { 1, 2, 3, 4 }, { 8, 7, 6, 5 }, { 4, 3, 2, 9, } };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 9, 2, 3, 4, 8, 7, 6 };
            int[] output;
            //CollectionAssert.AreEqual(expected, output);
        }
    }
}