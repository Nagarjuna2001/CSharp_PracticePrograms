using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    // Concrete Product
    public class CitiBankSavingsAccount : ISavingsAccount
    {
        public CitiBankSavingsAccount()
        {
            AccountNumber = "62647391148368";
            Balance = 5000;
        }
    }
}
