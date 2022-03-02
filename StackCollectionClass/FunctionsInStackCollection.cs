using System;
using System.Collections.Generic;
using System.Linq;

namespace StackCollectionClass
{
    class FunctionsInStackCollection
    {
        static void Main(string[] args)
        {
            Customer[] GroupOfCustomers = new Customer[5];
            CreateGroupOfCustomers(GroupOfCustomers);

            Stack<Customer> StackOfCustomers = PushCustomersIntoStack(GroupOfCustomers);

            PopElementFromStack(StackOfCustomers);

            PrintPeekElementOfStack(StackOfCustomers);

            CheckIfElementPresentInStack(StackOfCustomers,GroupOfCustomers);

            PrintNumberOfElementsOnStack(StackOfCustomers);

            //Iterating elements in the stack
            foreach (Customer customer in StackOfCustomers)
            {
                Console.WriteLine("ID is {0} , Name is {1} , Salary is {2}", customer.ID, customer.Name, customer.salary);
            }
            
        }

        private static void PrintNumberOfElementsOnStack(Stack<Customer> StackOfCustomers)
        {
            // Code to find the number of items in the stack
            Console.WriteLine(StackOfCustomers.Count());
        }
        private static void CheckIfElementPresentInStack(Stack<Customer> StackOfCustomers,Customer[] GroupOfCustomers)
        {
            //code to check if an element is present in the stack
            if (StackOfCustomers.Contains(GroupOfCustomers[1]))
            {
                Console.WriteLine("Item is present in the Stack");
            }
            else
            {
                Console.WriteLine("Item is not present in the Stack");
            }
        }
        private static void PrintPeekElementOfStack(Stack<Customer> StackOfCustomers)
        {
            //code to return the top element in the stack without removing it
            Customer TopMostElementOfStack = StackOfCustomers.Peek();
            Console.WriteLine(TopMostElementOfStack.ID);
        }
        private static void PopElementFromStack(Stack<Customer> StackOfCustomers)
        {
            //Code to remove and return the top element present in the Stack
            Customer cust = StackOfCustomers.Pop();
            Console.WriteLine("Popped element ID is {0}", cust.ID);
        }
        private static Stack<Customer> PushCustomersIntoStack(Customer[] GroupOfCustomers)
        {
            Stack<Customer> stackOfCustomers = new Stack<Customer>();
            foreach (Customer customer in GroupOfCustomers)
            {
                stackOfCustomers.Push(customer);
            }
            return stackOfCustomers;
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