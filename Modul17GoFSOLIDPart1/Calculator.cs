using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul17GoFSOLIDPart1
{
    public class Calculator
    {
        public void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
