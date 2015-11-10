using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArchBuildingAreaProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(600.273, AreaCalculation(),0.01);
        }
        public static double AreaCalculation()
        {
            double columnAFirstCoordinate = 46.849631;
            double columnASecondCoordinate = 89.664434;

            double columnBFirstCoordinate = 57.689416;
            double columnBSecondCoordinate = 34.618486;

            double columnCFirstCoordinate = 73.643651;
            double columnCSecondCoordinate = 64.354384;

            double area = (columnAFirstCoordinate * columnBSecondCoordinate 
                         - columnAFirstCoordinate * columnCSecondCoordinate 
                         + columnBFirstCoordinate * columnCSecondCoordinate 
                         - columnBFirstCoordinate * columnASecondCoordinate 
                         + columnCFirstCoordinate * columnASecondCoordinate 
                         - columnCFirstCoordinate * columnBSecondCoordinate) / 2;
            return area;
        }
    }
}
