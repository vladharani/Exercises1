using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoutingPointProblem
{
    [TestClass]
    public class RoutingCoordinates
    {
        [TestMethod]
        public void TestRoutingCoordinates()
        {
            Assert.AreEqual(pointCoordinates(2, 5), pointCoordinates(2, 3));
        }
        static object pointCoordinates(int x, int y)
        {

            string[] commandString = new string[] { "up", "left", "down", "down", "up", "left", "right", "right", "up", "up" };

            for (int index = 0; index < commandString.Length; index++)
            {
                if (commandString[index] == "up") { y += 1; }
                else if (commandString[index] == "down") { y -= 1; }
                else if (commandString[index] == "right") { x += 1; }
                else if (commandString[index] == "left") { x -= 1; }
            }
            return pointCoordinates(x, y);
        }

    }
}