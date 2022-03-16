using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class FullTimeEmployee : BaseEmployee
    {
        public FullTimeEmployee() { }
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
