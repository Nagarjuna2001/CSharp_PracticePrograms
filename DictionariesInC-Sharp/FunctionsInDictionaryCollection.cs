using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesInCSharp
{
    public class FunctionsInDictionaryCollection
    {
        static void Main(string[] args)
        {
            //Commonly used functions present in Dictionary Collection to manipulate the customer the data present in the collection

            AddCustomers customerList = new AddCustomers(5);
            Customer[] GroupOfCustomers = customerList.AddGroupOfCustomers();

            //Syntax to create a dictionary and add key value pairs in a dictionary
            Dictionary<int, Customer>  CustomerDataDictionary = new Dictionary<int, Customer>();

            foreach(Customer customer in GroupOfCustomers)
            {
                CustomerDataDictionary.Add(customer.ID, customer);
            }


            //Code to get value of an element with a specific key
            Console.WriteLine("Name of customer with ID=103 is "+CustomerDataDictionary[103].Name);

            try { 
                Console.WriteLine("Name of customer with ID=106 is " + CustomerDataDictionary[106].Name);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Customer with ID 106 does not exist");
            }

            //Code to find the number of customers whose salary is greater than 5000 in the dictionary
            Console.WriteLine(CustomerDataDictionary.Count(customer => customer.Value.salary >= 5000));

            //Code if you are not sure whether a key is present in the dictionary
            //but do not want the code to throw any exception 
            int TemporaryCustomerID = 105;
            if (CustomerDataDictionary.TryGetValue(TemporaryCustomerID, out Customer ExistingCustomer))
            {
                Console.WriteLine("Details of customer with ID as {0} : Name is {1} Salary is {2}",TemporaryCustomerID, ExistingCustomer.Name, ExistingCustomer.salary);
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }

            //Code to remove all entries in the dictionary
            CustomerDataDictionary.Clear();
            Console.WriteLine(CustomerDataDictionary.Count);

            //Code to convert an array of type Customer into a dictionary with customer ID as key and Customer type as its associated value 
            Customer[] customers = customerList.AddGroupOfCustomers();
            Dictionary<int, Customer> dict = customers.ToDictionary(customer => customer.ID, customer => customer);

            foreach (KeyValuePair<int, Customer> CustomerData in dict)
            {
                Console.WriteLine("Key is {0} and value is {1}", CustomerData.Key, CustomerData.Value.Name);
            }
        }
        
    }
}