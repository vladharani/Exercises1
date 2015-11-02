using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiFareCalcProblem
{
    [TestClass]
    public class FirstTry
    {
        [TestMethod]
        public void Test1()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(9, 5);
            Assert.AreEqual(25, taxiFare);
        }
        [TestMethod]
        public void Test2()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(23, 5);
            Assert.AreEqual(35, taxiFare);
        }
        [TestMethod]
        public void Test3()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(23, 40);
            Assert.AreEqual(400, taxiFare);
        }
        [TestMethod]
        public void Test4()
        {
            TaxiFareCalc obj = new TaxiFareCalc();
            int taxiFare = obj.Calculate(10, 30);
            Assert.AreEqual(240, taxiFare);
        }
        public class TaxiFareCalc
        {
            public int Calculate(int hour, int distance)
            {
                int price = 0;

                if (hour>8 && hour<21 && distance <=20)
                {
                    price = 5;
                }
                else if (hour < 8 || hour > 21 && distance <= 20)
                {
                    price = 7;

                }
                else if (hour > 8 && hour < 21 && distance > 20 && distance < 60)
                {
                    price = 4;
                    distance = distance * 2;
                }
                else if (hour < 8 || hour > 21 && distance > 20 && distance < 60)
                {
                    price = 5;
                    distance = distance * 2;
                }
                else if (hour > 8 && hour < 21 && distance > 60)
                {
                    price = 3;
                    distance = distance * 2;
                }
                else if (hour < 8 || hour > 21 && distance > 60)
                {
                    price = 4;
                    distance = distance * 2;
                }
                return price * distance;
            }
        }
    }
}