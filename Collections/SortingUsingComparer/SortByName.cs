using System;
using System.Collections.Generic;
using System.Text;

namespace SortingUsingComparer
{
    public class SortByName : IComparer<Customer>
    {
        public SortByName() { }

        public int Compare(Customer cust1, Customer cust2)
        {
            return cust1.Name.CompareTo(cust2.Name);
        }

    }
}
