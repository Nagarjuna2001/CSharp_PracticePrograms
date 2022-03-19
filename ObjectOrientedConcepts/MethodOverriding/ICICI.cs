using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class ICICI : ReserveBankOfIndia
    {
        public ICICI() { }

        public override float GetInterestRate()
        {
            return 8.5f;
        }
    }
}
