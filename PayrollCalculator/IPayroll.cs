using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculator
{
    public interface IPayroll
    {
        decimal Hours { get; set; }
        decimal Rate { get; set; }

        decimal GrossAmount { get; }

        decimal IncomeTax { get; set; }
        decimal SocialCharge { get; set; }
        decimal Pension { get; set; }

        decimal NetAmount { get; }
    }
}
