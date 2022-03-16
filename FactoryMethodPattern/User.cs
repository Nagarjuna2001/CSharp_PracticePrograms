using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class User
    {
        static void Main(string[] args)
        {
            IReserverBankOfIndiaFactory factory = new SavingsAcctFactory();
            try
            {
                ISavingsAccount citiBankAccountDetails = factory.GetSavingsAccount("CITI321980");
                Console.WriteLine($"My Citi Bank Account number is {citiBankAccountDetails.AccountNumber} and balance is {citiBankAccountDetails.Balance}"); 
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("THE IFCS code provided is Invalid");
            }

            try
            {
                ISavingsAccount axisBankAccountDetails = factory.GetSavingsAccount("AXIS345600");
                Console.WriteLine($"My Axis Bank Account number is {axisBankAccountDetails.AccountNumber} and balance is {axisBankAccountDetails.Balance}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("THE IFCS code provided is Invalid");
            }
            
        }

    }
}
