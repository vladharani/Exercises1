using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Chance(6, 49));
        }
        double Chance(int k, int m) {
            int product = 1;
            for (int i = m - k + 1; i <= m; i++)
            {
                product = product * i;
            }
            return 1 / product;
        }
    }

}
