using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculator
{
    public class GermanyTax : PayrollCalculatorBase
    {

        public override decimal CalculateIncomeTax()
        {
            decimal newGrossAmount = GrossAmount;
            if (newGrossAmount > 400)
            {
                IncomeTax = (400 * 25) / 100;
                newGrossAmount -= 400;
                IncomeTax += (newGrossAmount * 32) / 100;
            }
            else
            {
                IncomeTax = (newGrossAmount * 25) / 100;
            }             

            return IncomeTax;
        }

        public override decimal CalculateUniversalSocialCharge()
        {
            SocialCharge = 0;
            return SocialCharge;
        }

        public override decimal CalculatePension()
        {
            Pension = (GrossAmount * 2) / 100;

            return Pension;
        }
    }
}
