using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Modul17GoFSOLIDPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Calculator calculator = new Calculator();

            calculator.CalculateInterest(new SalaryAccount());

            calculator.CalculateInterest(new SimpleAccount());
        }
    }
}
