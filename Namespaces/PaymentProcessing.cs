using System;
using System.Collections.Generic;
using System.Text;

namespace ReserveBankOfIndia
{
    namespace StateBankOfIndia
    {
        class PaymentProcessing
        {
            public static bool IsPaymentSuccessful()
            {
                return true;
            }
        }
    }

    namespace CentralBankOFIndia
    {
        class PaymentProcessing
        {
            public static bool IsPaymentSuccessful()
            {
                //Business logic
                return false;
            }
        }
    }
}
