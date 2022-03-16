using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    // Concrete Creators
    public class SavingsAcctFactory : IReserverBankOfIndiaFactory
    {
        public SavingsAcctFactory() { }
        
        public ISavingsAccount GetSavingsAccount(string IFSC)
        {
            if (IFSC.Contains("CITI")) { return new CitiBankSavingsAccount(); }
            else
            if (IFSC.Contains("AXIS")) { return new AxisBankSavingsAccount(); }
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }

}
