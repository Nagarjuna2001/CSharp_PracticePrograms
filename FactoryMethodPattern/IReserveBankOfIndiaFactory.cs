using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public interface IReserverBankOfIndiaFactory
    {
        // Creator
        ISavingsAccount GetSavingsAccount(string acctNo);
    }
}
