using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingUsingComparisionDelegate
{
    class SortingCustomerList
    {
        static void Main(string[] args)
        {
            Customer[] GroupOfCustomers = new Customer[5];
            CreateGroupOfCustomers(GroupOfCustomers);

            List<Customer> ListOfCustomers = AddCustomersToList(GroupOfCustomers);

            //Elements before sorting
            foreach (Customer customer in ListOfCustomers)
            {
                Console.WriteLine("ID is {0} , Name is {1} , Salary is {2}", customer.ID, customer.Name, customer.salary);
            }

            //sorting the customer objects in the list based on the Names
            Comparison<Customer> sortByName = new Comparison<Customer>(SortFunction);
            ListOfCustomers.Sort(sortByName);

            Console.WriteLine("--------------------------------------------------");

            //Elements after sorting
            foreach (Customer customer in ListOfCustomers)
            {
                Console.WriteLine("ID is {0} , Name is {1} , Salary is {2}", customer.ID, customer.Name, customer.salary);
            }

        }
        private static int SortFunction(Customer cust1, Customer cust2)
        {
            return cust1.Name.CompareTo(cust2.Name);
        }
        private static List<Customer> AddCustomersToList(Customer[] GroupOfCustomers)
        {
            List<Customer> ListOfCustomers = new List<Customer>();
            foreach (Customer customer in GroupOfCustomers)
            {
                ListOfCustomers.Add(customer);
            }

            return ListOfCustomers;
        }
        private static void CreateGroupOfCustomers(Customer[] GroupOfCustomers)
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
        }
    }

    class Customer
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int salary { set; get; }

    }
}


