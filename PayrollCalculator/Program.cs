using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the hours worked:");
            string hours = Console.ReadLine();

            Console.WriteLine("Please enter the hourly rate:");
            string rate = Console.ReadLine();

            Console.WriteLine("Please enter the employee’s location:");
            string location = Console.ReadLine();

            var ruleSet = (PayrollCountryEnum)Enum.Parse(typeof(PayrollCountryEnum), location.ToUpper());

            PayrollCalculatorBase payBase = PayrollEngineFactory.Create(ruleSet);
            payBase.Hours = Convert.ToInt32(hours);                       
            payBase.Rate = Convert.ToInt32(rate);            

            Console.WriteLine("Employee location: " + location);
            Console.WriteLine();
            Console.WriteLine("Gross Amount: $" + payBase.GrossAmount);
            Console.WriteLine();
            Console.WriteLine("Less deductions");
            Console.WriteLine();
            Console.WriteLine("Income Tax: $" + payBase.CalculateIncomeTax());
            Console.WriteLine("Universal Social Charge: $ " + payBase.CalculateUniversalSocialCharge());
            Console.WriteLine("Pension: $" + payBase.CalculatePension());
            Console.WriteLine("Net Amount: $" + payBase.NetAmount);

            Console.ReadKey();
        }
    }
}
