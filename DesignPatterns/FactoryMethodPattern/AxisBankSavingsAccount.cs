using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    // Concrete Product
    public class AxisBankSavingsAccount : ISavingsAccount
    {
        public AxisBankSavingsAccount()
        {
            AccountNumber = "864572746483645";
            Balance = 2000;
        }
    }
}
