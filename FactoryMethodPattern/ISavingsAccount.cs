using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    // Product
    public abstract class ISavingsAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
