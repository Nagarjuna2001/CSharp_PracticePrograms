using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id,string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05M;
        }
        public override decimal GetMinimumSalary()
        {
            return 10000;
        }
    }
}
