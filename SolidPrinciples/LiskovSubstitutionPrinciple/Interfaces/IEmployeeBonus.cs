using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.Interfaces
{
    public interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
