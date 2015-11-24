using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoordinateAreaCalculationProblem
{
    [TestClass]
    public class CoordinateAreaCalculation
    {
        [TestMethod]
        public void TestCoordinateAreaCalculation()
        {
            Assert.AreEqual(18, AreaCalculation(2,2,4,10,8,8),0.01);
        }
        public static double AreaCalculation(double ax, double ay, double bx, double by, double cx, double cy)
        {
            double area = -(ax * by - ax * cy + bx * cy - bx * ay + cx * ay  - cx * by) / 2;
            return area;
        }
    }
}
