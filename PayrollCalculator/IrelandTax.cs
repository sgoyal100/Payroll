using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculator
{
    public class IrelandTax : PayrollCalculatorBase
    {
        public override decimal CalculateIncomeTax()
        {
            decimal newGrossAmount = GrossAmount;
            if (newGrossAmount > 600)
            {
                IncomeTax = (600 * 25) / 100;
                newGrossAmount -= 600;
                IncomeTax += (newGrossAmount * 40) / 100;
            }
            else
            {
                IncomeTax = (newGrossAmount * 25) / 100;
            }            

            return IncomeTax;
        }

        public override decimal CalculateUniversalSocialCharge()
        {
            decimal newGrossAmount = GrossAmount;
            if (newGrossAmount > 500)
            {
                SocialCharge = (500 * 7) / 100;
                newGrossAmount -= 500;
                SocialCharge += (newGrossAmount * 8) / 100;
            }
            else
            {
                SocialCharge = (newGrossAmount * 7) / 100;
            }               
            return SocialCharge;
        }

        public override decimal CalculatePension()
        {
            Pension = (GrossAmount * 4) / 100;

            return Pension;
        }

    }
}
