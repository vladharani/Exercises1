using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12, MeetingDay(4, 6));
        }
        int MeetingDay(int friend1, int friend2)
        {
            int daycounter;
            if (friend1 > friend2)

                daycounter = friend1;
            else

                daycounter = friend2;
            while (!(daycounter % friend1 == 0 && daycounter % friend2 == 0))
            {
                daycounter = daycounter + 1;
            }

            return daycounter;

        }
    }

}
