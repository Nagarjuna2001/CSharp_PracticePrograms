using System;
using RBI_SBI = ReserveBankOfIndia.StateBankOfIndia;
using RBI_CBI = ReserveBankOfIndia.CentralBankOFIndia;

namespace Namespaces
{
    class ClassToResolveNamingConflicts
    {
        static void Main(string[] args)
        {
            // One way to resolve naming conflict is to use the shorthand notation in the using directive 
            bool checkIfPaymentSuccessfulBySBI = RBI_SBI.PaymentProcessing.IsPaymentSuccessful();
            bool checkIfPaymentSuccessfulByCBI = RBI_CBI.PaymentProcessing.IsPaymentSuccessful();

            if (checkIfPaymentSuccessfulBySBI)
            {
                Console.WriteLine("Payment completed successfully by SBI");
            }
            else
            {
                Console.WriteLine("Payment failed by SBI");
            }

            if (checkIfPaymentSuccessfulByCBI)
            {
                Console.WriteLine("Payment completed successfully by CBI");
            }
            else
            {
                Console.WriteLine("Payment failed by CBI");
            }

            //The other way is to use the fully qualified names while calling the methods (which have the same name)

            
        }
    }
}
