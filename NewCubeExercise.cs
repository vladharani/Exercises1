using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int k = 3;
            int i = 0;
            int result = 192;
            
            do
            {
                double Power = Math.Pow(result, 3);
                if (Power % 1000 == 888)
                {
                    i++;
                }
                result++;
            } while (i <= k);

            Assert.AreEqual(943, result);
        }
    }
}
