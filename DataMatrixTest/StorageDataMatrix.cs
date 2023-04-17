using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMatrixTest
{
    public class StorageDataMatrix
    {
        public IEnumerable<object[]> InputDataMatrixTraceTest()
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
