using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingComplexTypes
{
    class SortingCustomerList
    {
        static void Main(string[] args)
        {
            AddCustomers customerList = new AddCustomers(5);
            Customer[] GroupOfCustomers = customerList.AddGroupOfCustomers();

            List<Customer> ListOfCustomers = AddCustomersToList(GroupOfCustomers);

            //Elements before sorting
            foreach (Customer customer in ListOfCustomers)
            {
                Console.WriteLine("ID is {0} , Name is {1} , Salary is {2}", customer.ID, customer.Name, customer.salary);
            }

            //sorting the customer objects in the list
            ListOfCustomers.Sort();

            Console.WriteLine("--------------------------------------------------");

            //Elements after sorting
            foreach (Customer customer in ListOfCustomers)
            {
                Console.WriteLine("ID is {0} , Name is {1} , Salary is {2}", customer.ID, customer.Name, customer.salary);
            }

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
    }
}