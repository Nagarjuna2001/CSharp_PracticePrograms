using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ContractEmployee(int id,string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return string.Format("Name : {0}", this.Name);
        }
        public decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
