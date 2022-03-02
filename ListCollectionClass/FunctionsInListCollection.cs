using System;
using System.Collections.Generic;
using System.Linq;

namespace ListCollectionClass
{
    class FunctionsInListCollection
    {
        static void Main(string[] args)
        {
            Customer[] GroupOfCustomers = new Customer[5];
            FunctionsInListCollection.CreateGroupOfCustomers(GroupOfCustomers);

            List<Customer> ListOfCustomers = AddCustomersToList(GroupOfCustomers);

            Customer retrievedCustomer = RetrieveElementUsingIndex(ListOfCustomers);
            Console.WriteLine("Retrieved Customer is " + retrievedCustomer.Name);


            //Code to remove all entries in the dictionary
            // customers.Clear();

            InsertElementIntoList(ListOfCustomers, GroupOfCustomers);

            FindIndexOfElementInList(ListOfCustomers, GroupOfCustomers);

            CheckIfElementPresentInList(ListOfCustomers, GroupOfCustomers);

            CustomersWithSalaryAbove5k(ListOfCustomers);

            ConvertListToArray(ListOfCustomers);

            RemoveElementFromList(ListOfCustomers, GroupOfCustomers);

            ConvertListToDictionary(ListOfCustomers);
        }

        private static void CustomersWithSalaryAbove5k(List<Customer> ListOfCustomers)
        {
            //code to find the first element in the list that matches a condition specified by lambda expression
            Customer searchCustomer = ListOfCustomers.Find(cust => cust.salary >= 5000);
            Console.WriteLine("Name is {0}", searchCustomer.Name);

            //code to find all elements in the list that matches a condition specified by lambda expression
            List<Customer> CustomerList = ListOfCustomers.FindAll(cust => cust.salary >= 5000);
            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine("Name is {0}", customer.Name);
            }
        }
        private static void InsertElementIntoList(List<Customer> ListOfCustomers,Customer[] GroupOfCustomers)
        {
            ListOfCustomers.Insert(1, GroupOfCustomers[4]);
        }
        private static Customer RetrieveElementUsingIndex(List<Customer> ListOfCustomers)
        {
            //Code to get value of an element using index
            return ListOfCustomers[1];
        }
        private static void CheckIfElementPresentInList(List<Customer> ListOfCustomers, Customer[] GroupOfCustomers)
        {
            //code to check if an element is present in the list
            if (ListOfCustomers.Contains(GroupOfCustomers[1]))
            {
                Console.WriteLine("Item is present int the list");
            }
            else
            {
                Console.WriteLine("Item is not present in the list");
            }
        }
        private static void RemoveElementFromList(List<Customer> ListOfCustomers,Customer[] GroupOfCustomers)
        {
            //code to remove an item from the list
            ListOfCustomers.Remove(GroupOfCustomers[4]);
        }

        private static void ConvertListToArray(List<Customer> ListOfCustomers)
        {
            //code to convert a list to an array
            Customer[] customerArray = ListOfCustomers.ToArray();
            foreach (Customer customer in customerArray)
            {
                Console.WriteLine("ID is {0} , Name is {1}", customer.ID, customer.Name);
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
        private static void ConvertListToDictionary(List<Customer> ListOfCustomers)
        {
            //code to convert list to dictionary
            Dictionary<int, Customer> IdToCustomerMapping = ListOfCustomers.ToDictionary(key => key.ID);

            foreach (KeyValuePair<int, Customer> kvp in IdToCustomerMapping)
            {
                Console.WriteLine("Key is {0}", kvp.Key);
            }

        }
        private static void FindIndexOfElementInList(List<Customer> ListOfCustomers, Customer[] GroupOfCustomers)
        {
            //code to find the index of a particular element - returns the first matching element
            Console.WriteLine(ListOfCustomers.IndexOf(GroupOfCustomers[4]));

            //code to find the index of a particular element in a given range - returns the first matching element in that range
            Console.WriteLine(ListOfCustomers.IndexOf(GroupOfCustomers[4], 2, 4));
        }
    }

    class Customer
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int salary { set; get; }
    }
}
