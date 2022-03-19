using System;
using System.Collections.Generic;
using System.Text;

namespace SortingComplexTypes
{
    public class Customer : IComparable<Customer>
    {
        public Customer() { }

        public int ID { set; get; }
        public string Name { set; get; }
        public int salary { set; get; }

        public int CompareTo(Customer customer)
        {
            if (this.salary > customer.salary)
            {
                return 1;
            }
            else if (this.salary < customer.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
