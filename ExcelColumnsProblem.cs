using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumnsProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            

            char[] characters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string result = string.Empty;
            int columnNumber = 563;
            int targetBase = characters.Length;


            do
            {
                result = characters[columnNumber % targetBase - 1] + result;
                columnNumber = columnNumber / targetBase;
            } while (columnNumber > 0);

            Assert.AreEqual("UQ", result);

        }
    }
}
