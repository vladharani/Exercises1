using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankInterest
{
    [TestClass]
    public class BankInterest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double BankLoanAmount = 40000;
            double BankLoanPeriodYrs = 20;
            double BankLoanInterest = 0.0757;
            double RequiredPaymentMonth = 39;
            double BankLoanPeriodMonths = BankLoanPeriodYrs*12;
            double MonthlyRateFixPart = BankLoanAmount / BankLoanPeriodMonths;
           
            double MonthlyRateInterestPart = BankLoanInterest * (BankLoanAmount - (RequiredPaymentMonth - 1) * MonthlyRateFixPart) / 12;        
            double MonthlyRateAmount = MonthlyRateInterestPart + MonthlyRateFixPart;
            
            Assert.AreEqual(379, Convert.ToInt32(MonthlyRateAmount));
        }
    }
}
