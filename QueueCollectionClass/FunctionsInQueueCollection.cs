using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueCollectionClass
{
    class FunctionsInQueueCollection
    {
        static void Main(string[] args)
        {
            Customer[] GroupOfCustomers = new Customer[5];
            CreateGroupOfCustomers(GroupOfCustomers);

            Queue<Customer> QueueOfCustomers = EnqueueCustomersIntoQueue(GroupOfCustomers);

            Customer DequeuedCustomer = DequeueCustomerFromQueue(QueueOfCustomers);
            Console.WriteLine(DequeuedCustomer.ID);

            CheckIfElementPresentInQueue(QueueOfCustomers, GroupOfCustomers);

            Customer TemporaryCustomer = PeekElementInQueue(QueueOfCustomers);
            Console.WriteLine(TemporaryCustomer.ID);

            //Code to find the number of items in the Queue
            Console.WriteLine(QueueOfCustomers.Count());

            //Iterating elements in the queue
            foreach (Customer customer in QueueOfCustomers)
            {
                Console.WriteLine("ID is {0} , Name is {1} , Salary is {2}", customer.ID, customer.Name, customer.salary);
            }
        }
        private static void CheckIfElementPresentInQueue(Queue<Customer> QueueOfCustomers,Customer[] GroupOfCustomers)
        {
            //code to check if an element is present in the Queue
            if (QueueOfCustomers.Contains(GroupOfCustomers[1]))
            {
                Console.WriteLine("Item is present int the Queue");
            }
            else
            {
                Console.WriteLine("Item is not present in the Queue");
            }
        }
        private static Customer PeekElementInQueue(Queue<Customer> QueueOfCustomers)
        {
            //code to return the first element in the queue without removing it
            return QueueOfCustomers.Peek();
        }
        private static Customer DequeueCustomerFromQueue(Queue<Customer> QueueOfCustomers)
        {
            return QueueOfCustomers.Dequeue();
        }
        private static Queue<Customer> EnqueueCustomersIntoQueue(Customer[] GroupOfCustomers)
        {
            //code to add elements in a Queue

            Queue<Customer> QueueOfCustomers = new Queue<Customer>();
            foreach (Customer customer in GroupOfCustomers)
            {
                QueueOfCustomers.Enqueue(customer);
            }
            return QueueOfCustomers;
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
