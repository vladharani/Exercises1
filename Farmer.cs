using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(592900, Solve(1,230,-770000));
        }
        double Solve(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
            double x2 = (-b + Math.Sqrt(delta)) / 2 * a;
        if (x1>0)
            return x1*x1;
        else
            return x2*x2;
            
        }
    }
}
