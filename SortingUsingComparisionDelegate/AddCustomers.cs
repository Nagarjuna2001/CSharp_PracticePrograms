using System;
using System.Collections.Generic;
using System.Text;

namespace SortingUsingComparisionDelegate
{
    public class AddCustomers
    {
        Customer[] GroupOfCustomers;
        public AddCustomers(int totalNumberOfCustomers)
        {
            GroupOfCustomers = new Customer[totalNumberOfCustomers];
        }

        public Customer[] AddGroupOfCustomers()
        {
            GroupOfCustomers[0] = new Customer()
            {
                ID = 101,
                Name = "Steve",
                salary = 3000
            };

            GroupOfCustomers[1] = new Customer()
            {
                ID = 102,
                Name = "John",
                salary = 4500
            };

            GroupOfCustomers[2] = new Customer()
            {
                ID = 103,
                Name = "Jane",
                salary = 4000
            };

            GroupOfCustomers[3] = new Customer()
            {
                ID = 104,
                Name = "Alice",
                salary = 7000
            };

            GroupOfCustomers[4] = new Customer()
            {
                ID = 105,
                Name = "Bob",
                salary = 5500
            };

            return GroupOfCustomers;
        }

    }
}
