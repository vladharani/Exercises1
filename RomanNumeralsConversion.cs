using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsConversion
{
    [TestClass]
    public class RomanNumeralsConversion
    {
        [TestMethod]
        public void TestConversionToRoman01()
        {
            Assert.AreEqual("I", ToRoman(1));
        }
        [TestMethod]
        public void TestConversionToRoman02()
        {
            Assert.AreEqual("II", ToRoman(2));
        }
        [TestMethod]
        public void TestConversionToRoman03()
        {
            Assert.AreEqual("III", ToRoman(3));
        }
        [TestMethod]
        public void TestConversionToRoman04()
        {
            Assert.AreEqual("IV", ToRoman(4));
        }
        [TestMethod]
        public void TestConversionToRoman05()
        {
            Assert.AreEqual("V", ToRoman(5));
        }
        [TestMethod]
        public void TestConversionToRoman06()
        {
            Assert.AreEqual("VI", ToRoman(6));
        }
        [TestMethod]
        public void TestConversionToRoman07()
        {
            Assert.AreEqual("VII", ToRoman(7));
        }
        [TestMethod]
        public void TestConversionToRoman08()
        {
            Assert.AreEqual("VIII", ToRoman(8));
        }
        [TestMethod]
        public void TestConversionToRoman09()
        {
            Assert.AreEqual("IX", ToRoman(9));
        }
        [TestMethod]
        public void TestConversionToRoman10()
        {
            Assert.AreEqual("X", ToRoman(10));
        }
        [TestMethod]
        public void TestConversionToRoman11()
        {
            Assert.AreEqual("XI", ToRoman(11));
        }
        [TestMethod]
        public void TestConversionToRoman12()
        {
            Assert.AreEqual("XII", ToRoman(12));
        }
        [TestMethod]
        public void TestConversionToRoman13()
        {
            Assert.AreEqual("XIII", ToRoman(13));
        }
        public string ToRoman(int number)
        {
            string[] numerals = new string[]
                { "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            if (number < 0 || number > 100)
                throw new ArgumentException("Value must be in the range 0 - 100");
            if (number == 0) return "N";
            string result = "";
            if (number == 1) result = numerals[numerals.Length - 1];
            if (number == 2) result = numerals[numerals.Length - 1]+ numerals[numerals.Length - 1];
            if (number == 3) result = numerals[numerals.Length - 1]+ numerals[numerals.Length - 1]+ numerals[numerals.Length - 1];
            if (number == 4) result = numerals[numerals.Length - 2];
            if (number == 5) result = numerals[numerals.Length - 3];
            if (number == 6) result = numerals[numerals.Length - 3] + numerals[numerals.Length - 1];
            if (number == 7) result = numerals[numerals.Length - 3] + numerals[numerals.Length - 1] + numerals[numerals.Length - 1];
            if (number == 8) result = numerals[numerals.Length - 3] + numerals[numerals.Length - 1] + numerals[numerals.Length - 1] + numerals[numerals.Length - 1];
            if (number == 9) result = numerals[numerals.Length - 4];
            if (number == 10) result = numerals[numerals.Length - 5];
            if (number == 11) result = numerals[numerals.Length - 5] + numerals[numerals.Length - 1];
            if (number == 12) result = numerals[numerals.Length - 5] + numerals[numerals.Length - 1] + numerals[numerals.Length - 1];
            if (number == 13) result = numerals[numerals.Length - 5] + numerals[numerals.Length - 1] + numerals[numerals.Length - 1] + numerals[numerals.Length - 1];
            

            return result;
            
        }
        
    }
}
