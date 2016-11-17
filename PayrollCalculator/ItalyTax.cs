using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculator
{
    public class ItalyTax : PayrollCalculatorBase
    {
        public override decimal CalculateIncomeTax()
        {        
            IncomeTax = (GrossAmount * 25) / 100;

            return IncomeTax;
        }

        public override decimal CalculateUniversalSocialCharge()
        {
            SocialCharge = (GrossAmount * (decimal)9.19) / 100;

            return SocialCharge;
        }

        public override decimal CalculatePension()
        {
            Pension = 0;
            return Pension;
        }
    }
}
