using System;

namespace ProtectedAccessModifier
{
    public class ProtectedModifierExercise
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            //Console.WriteLine(customer.customerId);          Not accessible as this class is not derived from Customer class

            CorporateCustomer Customer = new CorporateCustomer();
            Customer.PrintID();
        }
    }
}
