using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul17GoFSOLIDPart1
{
    public interface IAccount
    {
        // тип учетной записи
        string Type { get; set; }

        // баланс учетной записи
        double Balance { get; set; }

        // процентная ставка
        double Interest { get; set; }

        void CalculateInterest();
    }
}
