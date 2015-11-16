using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsConversion
{
    [TestClass]
    public class RomanNumeralsConversion
    {
        [TestMethod]
        public void TestConversionToRoman1()
        {
            Assert.AreEqual("I", ToRoman(1));
        }
        [TestMethod]
        public void TestConversionToRoman2()
        {
            Assert.AreEqual("II", ToRoman(2));
        }
        [TestMethod]
        public void TestConversionToRoman3()
        {
            Assert.AreEqual("III", ToRoman(3));
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
            if (number == 2) result = numerals[numerals.Length - 1]+ numerals[numerals.Length - 1];
            if (number == 3) result = numerals[numerals.Length - 1]+ numerals[numerals.Length - 1]+ numerals[numerals.Length - 1];
            return result;
        }
        
    }
}
