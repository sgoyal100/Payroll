using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollCalculator;

namespace PayrollCalulatorUnitTest
{
    [TestClass]
    public class UnitTestIreland
    {
        [TestMethod]
        public void TestGrossAmount()
        {
            PayrollCalculatorBase target = new IrelandTax();
            target.Hours = 8;
            target.Rate = 10;

            Assert.AreEqual((decimal)80, target.GrossAmount);
        }
        [TestMethod]
        public void TestIncomeTax()
        {
            PayrollCalculatorBase target = new IrelandTax();
            target.Hours = 8;
            target.Rate = 10;

            Assert.AreEqual((decimal)20, target.CalculateIncomeTax());
        }
        [TestMethod]
        public void TestSocialCHarge()
        {
            PayrollCalculatorBase target = new IrelandTax();
            target.Hours = 8;
            target.Rate = 10;

            Assert.AreEqual((decimal)5.6, target.CalculateUniversalSocialCharge());
        }
        [TestMethod]
        public void TestPension()
        {
            PayrollCalculatorBase target = new IrelandTax();
            target.Hours = 8;
            target.Rate = 10;

            Assert.AreEqual((decimal)3.2, target.CalculatePension());
        }
        [TestMethod]
        public void TestNetAmount()
        {
            PayrollCalculatorBase target = new IrelandTax();
            target.Hours = 8;
            target.Rate = 10;

            target.CalculateIncomeTax();
            target.CalculateUniversalSocialCharge();
            target.CalculatePension();


            Assert.AreEqual((decimal)51.2, target.NetAmount);
        }
    }
}
