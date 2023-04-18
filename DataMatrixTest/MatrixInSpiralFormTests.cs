using DataMatrix;
using MatrixTraceApp;

namespace DataMatrixTest
{
    [TestClass]
    public class MatrixInSpiralFormTests
    {
        [TestMethod]
        public void QuickTest()
        {
            int[,] input = new int[,] { { 1, 2, 3, 4 }, { 8, 7, 6, 5 }, { 4, 3, 2, 9 } };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 9, 2, 3, 4, 8, 7, 6 };
            MatrixInSpiralForm matrixInSpiralForm = new MatrixInSpiralForm();
            Matrix matrix = new Matrix(input);
            int[] actual = matrixInSpiralForm.GetElementsInSpiralOrder(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DynamicData(nameof(InputData_ElementsInSpiralOrder), DynamicDataSourceType.Method)]
        public void ElementsInSpiralOrder(int[,] input, int[] expected)
        {
            MatrixInSpiralForm matrixInSpiralForm = new MatrixInSpiralForm();
            Matrix matrix = new Matrix(input);
            int[] actual = matrixInSpiralForm.GetElementsInSpiralOrder(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> InputData_ElementsInSpiralOrder()
        {
            return new[]
            {
                    new object[] 
                    {
                        new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } },
                        new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                    },
                    new object[]
                    {
                        new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10} },
                        new int[] { 1, 2, 4, 6, 8, 10, 9, 7, 5, 3 }
                    }
            };

        }
    }
}