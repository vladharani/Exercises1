using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiFareCalcProblem
{
    [TestClass]
    public class FirstTry
    {
        [TestMethod]
        public void TestDayShortDistanceFare()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(9, 5);
            Assert.AreEqual(25, taxiFare);
        }
        [TestMethod]
        public void TestNightShortDistanceFare()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(23, 5);
            Assert.AreEqual(35, taxiFare);
        }
        [TestMethod]
        public void TestNightMediumDistanceFare()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(23, 40);
            Assert.AreEqual(400, taxiFare);
        }
        [TestMethod]
        public void TestDayMediumDistanceFare()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(10, 30);
            Assert.AreEqual(240, taxiFare);
        }
        [TestMethod]
        public void TestDayLongDistanceFare()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(10, 70);
            Assert.AreEqual(420, taxiFare);
        }
        [TestMethod]
        public void TestNightLongDistance()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(23, 80);
            Assert.AreEqual(640, taxiFare);
        }
        public class TaxiFareCalc
        {

            int[] dayPrices = { 5, 8, 6 };
            int[] nightPrices = { 7, 10, 8 };

            public int Calculate(int hour, int distance)
            {
                int price = 0;
                int priceIndex = getPriceIndex(distance);
                //IsDayTime(hour) ? dayPrices[priceIndex] : nightPrices[priceIndex];

                if (IsDayTime(hour))
                {
                    price = dayPrices[priceIndex];
                }
                else
                {
                    price = nightPrices[priceIndex];
                }

                return price * distance;
            }
            bool IsDayTime(int hour)
            {
                return (hour >= 8) && (hour < 21);
            }

            int getPriceIndex(int distance)
            {
                if (distance <= 20) return 0;
                if (distance <= 40) return 1;
                return 2;
            }
        }
    }
}