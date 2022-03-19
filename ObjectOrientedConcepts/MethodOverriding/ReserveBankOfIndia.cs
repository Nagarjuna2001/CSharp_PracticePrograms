using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class ReserveBankOfIndia
    {
        public ReserveBankOfIndia() { }
        public virtual float GetInterestRate()
        {
            return 7.0f;
        }
    }
}
