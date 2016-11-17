using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollCalculator;

namespace PayrollCalulatorUnitTest
{
    [TestClass]
    public class UnitTestGermany
    {
        [TestMethod]
        public void TestGrossAmount()
        {
            PayrollCalculatorBase target = new GermanyTax();
            target.Hours = 8;
            target.Rate = 10;

            Assert.AreEqual((decimal)80, target.GrossAmount);
        }
        [TestMethod]
        public void TestIncomeTax()
        {
            PayrollCalculatorBase target = new GermanyTax();
            target.Hours = 8;
            target.Rate = 10;

            Assert.AreEqual((decimal)20, target.CalculateIncomeTax());
        }
        [TestMethod]
        public void TestSocialCHarge()
        {
            PayrollCalculatorBase target = new GermanyTax();
            target.Hours = 8;
            target.Rate = 10;

            Assert.AreEqual((decimal)0, target.CalculateUniversalSocialCharge());
        }
        [TestMethod]
        public void TestPension()
        {
            PayrollCalculatorBase target = new GermanyTax();
            target.Hours = 8;
            target.Rate = 10;

            Assert.AreEqual((decimal)1.6, target.CalculatePension());
        }
        [TestMethod]
        public void TestNetAmount()
        {
            PayrollCalculatorBase target = new GermanyTax();
            target.Hours = 8;
            target.Rate = 10;

            target.CalculateIncomeTax();
            target.CalculateUniversalSocialCharge();
            target.CalculatePension();


            Assert.AreEqual((decimal)58.4, target.NetAmount);
        }
    }
}
