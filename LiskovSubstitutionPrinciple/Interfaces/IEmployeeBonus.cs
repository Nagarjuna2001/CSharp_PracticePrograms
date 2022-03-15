using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.Interfaces
{
    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
