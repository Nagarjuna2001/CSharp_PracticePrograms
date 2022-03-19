using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueCollectionClass
{
    public class FunctionsInQueueCollection
    {
        static void Main(string[] args)
        {
            AddCustomers customerList = new AddCustomers(5);
            Customer[] GroupOfCustomers = customerList.AddGroupOfCustomers();

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
    }

}
