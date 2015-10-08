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
            int Length = 10;
            int Width = 10;
            int FlooringLength = 4;
            int FlooringWidth = 4;
            double FlooringWithMargin = FlooringLength * FlooringWidth * 25 / 100;
            double Calculation = (Length * Width / FlooringWithMargin);
            Assert.AreEqual(25, Calculation);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int Length = 10;
            int Width = 10;
            int FlooringLength = 4;
            int FlooringWidth = 4;
            double FlooringWithMargin = FlooringLength * FlooringWidth * 25 / 100;
            double Calculation = (Length * Width / FlooringWithMargin);
            Assert.AreEqual(40, Calculation);
        }
    }
}