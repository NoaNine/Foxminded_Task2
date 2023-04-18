using DataMatrix;

namespace DataMatrixTest
{
    public class StorageDataMatrix
    {
        public static IEnumerable<object[]> InputData_MatrixTraceTest()
        {
            return new[]
            {
                    new object[] 
                    { 
                        new int[,] { { 1, 2, 3 }, { 8, 7, 6 }, { 4, 3, 2 } }, 
                        10 
                    },
                    new object[] 
                    { 
                        new int[,] { { 1, 2, 3, 5, 6, 7, 8 }, { 8, 7, 6, 5, 7, 1, 2 } }, 
                        8 
                    },
                    new object[] 
                    { 
                        new int[,] { { 0, 0 }, { 0, 2 }, { 0, 0 }, { 0, 0 } }, 
                        2 
                    }
            };

        }

        public static IEnumerable<object[]> InputData_InputMatrixTest()
        {
            return new[]
            {
                    new object[] 
                    {
                        new int[,] { { 1, 2 }, { 8, 7 } },
                        new Matrix(new int[,] { { 1, 2 }, { 8, 7 } }), 
                        2, 
                        2
                    }
            };

        }
    }
}
