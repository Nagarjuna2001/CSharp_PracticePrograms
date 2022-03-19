using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.Interfaces
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}
