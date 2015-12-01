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
            Assert.AreEqual(startingPoint(2, 3), startingPoint(2,3));
        }
        string[] commandString = new string[] { "up", "left" };
        static object startingPoint(int x=2, int y=3)
        {
            string[] move = new string[] { "up", "left" };
            int index = 0;
            while (index < move.Length)
                {
                    if (move[index] == "up") { y += 1; }
                    else if (move[index] == "down") { y -= 1; }
                    else if (move[index] == "right") { x += 1; }
                    else x -= 1;
                
                }
            return startingPoint(x, y);
                    
        }
    }
}
