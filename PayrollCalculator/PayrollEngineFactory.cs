using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculator
{
    public class PayrollEngineFactory
    {
        public static PayrollCalculatorBase Create(PayrollCountryEnum ruleSet)
        {
            PayrollCalculatorBase payrollCountrySelector = null;
            switch (ruleSet)
            {
                case PayrollCountryEnum.IRELAND:
                    payrollCountrySelector = new IrelandTax();
                    break;
                case PayrollCountryEnum.ITALY:
                    payrollCountrySelector = new ItalyTax();
                    break;
                case PayrollCountryEnum.GERMANY:
                    payrollCountrySelector = new GermanyTax();
                    break;
                default:
                    break;
            }
            return payrollCountrySelector;
        }
    }
}
