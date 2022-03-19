using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }
    }
}
