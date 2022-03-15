using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public abstract class Employee : IEmployeeBonus,IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
       // public string EmployeeType { get; set; }

        public abstract decimal CalculateBonus(decimal salary);

        public abstract decimal GetMinimumSalary();


        public Employee(int id,string name)
        {
            this.ID = id;
            this.Name = name;
        }
        
        public override string ToString()
        {
            return string.Format("Name : {0}", this.Name);
        }

    }
}
