using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertToRomanNumerals
{
    [TestClass]
    public class ConvertToRomanNumerals
        // Abbreviation TestConvertToRomanNumerals = TCTRN
    {
        [TestMethod]
        public void TCTRNFromOneToTen()
        {
            Assert.AreEqual("VII", ToRoman(7));
        }
        [TestMethod]
        public void TCTRNFromTenToTwenty()
        {
            Assert.AreEqual("XIX", ToRoman(19));
        }
        [TestMethod]
        public void TCTRNFromTwentyToFifty()
        {
            Assert.AreEqual("XLIII", ToRoman(43));
        }
        [TestMethod]
        public void TCTRNFromFiftyToOneHundred()
        {
            Assert.AreEqual("LXIX", ToRoman(69));
        }
        [TestMethod]
        public void TCTRNFromOneHundredToFiveHundred1()
        {
            Assert.AreEqual("CLI", ToRoman(151));
        }
        [TestMethod]
        public void TCTRNFromOneHundredToFiveHundred2()
        {
            Assert.AreEqual("CDXXXII", ToRoman(432));
        }
        [TestMethod]
        public void TCTRNFromFiveHundredToOneThousand()
        {
            Assert.AreEqual("DCCCLIII", ToRoman(853));
        }
        [TestMethod]
        public void TCTRNFromOneThousandToFourThousandMinusOne()
        {
            Assert.AreEqual("MMMCCCXLII", ToRoman(3342));
        }
        
        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }

}
