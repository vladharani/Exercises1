using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject5
{
    [TestClass]
    public class ChessTable
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 8;
            double NumberOfSquares = 0;
            for (int i=1;i<=n;i++)
            {
                NumberOfSquares += Math.Pow(i, 2);
            }

            Assert.AreEqual(204, NumberOfSquares);
        }
    }
}
