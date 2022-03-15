using System;
using System.Collections.Generic;
using System.Text;

namespace Open_ClosedPrinciple
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
       // public string EmployeeType { get; set; }

        public abstract decimal CalculateBonus(decimal salary);

        public Employee(int id,string name)
        {
            this.ID = id;
            this.Name = name;
            //this.EmployeeType = employeeType;
        }

        public override string ToString()
        {
            return string.Format("Name : {0}", this.Name);
        }

        /*
         * Wrong way of writing the same code which makes it open for modification if a new employee type is added
        public decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * 0.5M;
        }*/
    }
}
