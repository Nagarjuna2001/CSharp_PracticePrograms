using System;
using System.Collections.Generic;
using System.Text;

namespace Open_ClosedPrinciple
{
    class PermanentEmployee : Employee
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
