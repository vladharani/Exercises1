using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentPaymentProblem
{
    [TestClass]
    public class RentPayment
    {
        [TestMethod]
        public void TestDaysDueFew()
        {
            RentAmountDueCalc obj = new RentAmountDueCalc();
            int PayableRentAmount = obj.Calculate(100, 1);
            Assert.AreEqual(102, PayableRentAmount);
        }
        [TestMethod]
        public void TestDaysDueMany()
        {
            RentAmountDueCalc obj = new RentAmountDueCalc();
            int PayableRentAmount = obj.Calculate(100, 32);
            Assert.AreEqual(420, PayableRentAmount);
        }
        [TestMethod]
        public void TestDaysDueAverage()
        {
            RentAmountDueCalc obj = new RentAmountDueCalc();
            int PayableRentAmount = obj.Calculate(100, 15);
            Assert.AreEqual(175, PayableRentAmount);
        }
        [TestMethod]
        public void TestDaysDueExtreme()
        {
            RentAmountDueCalc obj = new RentAmountDueCalc();
            int PayableRentAmount = obj.Calculate(100, 1422);
            Assert.AreEqual(14320, PayableRentAmount);
        }
    }

    public class RentAmountDueCalc
    {
        public int Calculate(int rentAmount, int daysDue)
        {
            int penalties = 0;
            if (daysDue <= 10)
            {
                penalties = ((2 * rentAmount) / 100) * daysDue;
            }
            else if (daysDue > 10 && daysDue <= 30)
            {
                penalties = ((5 * rentAmount) / 100) * daysDue;
            }
            else if (daysDue > 30)
            {
                penalties = ((10 * rentAmount) / 100) * daysDue;
            }
            return penalties + rentAmount;
        }
    }
}