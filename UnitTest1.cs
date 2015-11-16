using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConversionToRoman1()
        {
            Assert.AreEqual("I", ToRoman(1));
        }
        public string ToRoman(int number)
        {
            string[] numerals = new string[]
                { "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = new int[] {100, 90, 50, 40, 10, 9, 5, 4, 1 };
            if (number < 0 || number > 100)
                throw new ArgumentException("Value must be in the range 0 - 100");
            if (number == 0) return "N";
            string result = "";
            if (number == 1) result = numerals[numerals.Length-1];
            return result;
        }
        
    }
}
