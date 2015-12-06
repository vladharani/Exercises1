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
            string[] newCommands = new string[] { "up", "right" };
            NewFindLastPoint(startingPoint, newCommands);
            Assert.AreEqual(startingPoint(1, 1), startingPoint(0, 0));
            
        }

        public struct point
        {
            public int x;
            public int y;
            public point (int startingX, int startingY)
            {
                x = startingX;
                y = startingY;
            }
        }
        public point startingPoint = new point(0,0);
        
        public object NewFindLastPoint(point startingPoint,string[] newCommands)
        {
            for (int index = 0; index < newCommands.Length; index++)
            {
                if (newCommands[index] == "up") { y = startingY + 1; startingY = y; }
                else if (newCommands[index] == "down") { y = startingY - 1; startingY = y; }
                else if (newCommands[index] == "right") { x = startingX + 1; startingX = x; }
                else if (newCommands[index] == "left") { x = startingX + 1; startingX = x; }
            }
        }
    }
}