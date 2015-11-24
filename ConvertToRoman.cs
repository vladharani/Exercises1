using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertToRomanNumerals
{
    [TestClass]
    public class ConvertToRoman
    {
        [TestMethod]
        public void TestConversionToRomanNumeralsFromOneToNine()
        {
            Assert.AreEqual("IX", NumberToRomanNumerals(9));
        }
        [TestMethod]
        public void TestConversionToRomanNumeralsFromTenToNinetyNine()
        {
            Assert.AreEqual("XCIV", NumberToRomanNumerals(94));
        }
        [TestMethod]
        public void TestConversionToRomanNumeralsFromHundredToThousand()
        {
            Assert.AreEqual("CMXCIV", NumberToRomanNumerals(994));
        }
        [TestMethod]
        public void TestConversionToRomanNumeralsThousand()
        {
            Assert.AreEqual("M", NumberToRomanNumerals(1000));
        }
        public string NumberToRomanNumerals(int number)
        {
            string[] digits = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundreds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "M" };
            string result = "";

            if (number > 100)
            {
                int wholeHundreds = number / 100;
                result = hundreds[wholeHundreds];
                number = number - wholeHundreds * 100;
            }
            if (number > 10)
            {
                int wholeTens = number / 10;
                result += tens[wholeTens];
                number = number - wholeTens * 10;
            }
            if (number < 10)
            {
                result += digits[number];
            }
            return result;

        }
    }
}

