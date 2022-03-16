using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class SBI : ReserveBankOfIndia
    {
        public SBI() { }

        public override float GetInterestRate()
        {
            return 7.5f;
        }
    }
}
