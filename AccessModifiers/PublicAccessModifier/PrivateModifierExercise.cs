using System;

namespace PrivateAccessModifier
{
    public class PrivateModifierExercise
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.ID = 101;
            Console.WriteLine(customer.ID);

            //the below line gives a compiler error because it is inaccessible due to its protection level
            //Console.WriteLine(customer.customerId);
        }
    }
}
