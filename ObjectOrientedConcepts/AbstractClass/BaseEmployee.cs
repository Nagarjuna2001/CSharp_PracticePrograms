using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class BaseEmployee
    {
        public int ID { get; set; }
        public string FirstName { set; get; }

        public string LastName { set; get; }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public abstract int GetMonthlySalary();
    }
}
