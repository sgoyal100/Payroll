using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculator
{
    public interface IPayrollCalculator
    {
        decimal CalculateIncomeTax();
        decimal CalculateUniversalSocialCharge();
        decimal CalculatePension();
    }    
}
