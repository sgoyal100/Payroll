using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculator
{
    public abstract class PayrollCalculatorBase : IPayroll, IPayrollCalculator
    {
        public decimal Hours { get; set; }
        public decimal Rate { get; set; }

        public decimal GrossAmount
        {
            get
            {
                return Hours * Rate;
            }
        }

        public decimal IncomeTax { get; set; }
        public decimal SocialCharge { get; set; }
        public decimal Pension { get; set; }

        public decimal NetAmount
        {
            get
            {
                return GrossAmount - IncomeTax - SocialCharge - Pension;
            }
        }

        public abstract decimal CalculateIncomeTax();

        public abstract decimal CalculateUniversalSocialCharge();

        public abstract decimal CalculatePension();
    }
}
