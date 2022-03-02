using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class ContractEmployee : BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

        public override int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHoursWorked;
        }
    }
}
