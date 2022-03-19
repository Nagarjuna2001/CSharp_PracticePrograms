using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectedAccessModifier
{
    public class CorporateCustomer : Customer
    {
        public CorporateCustomer() { }

        public void PrintID()
        {
            //3 ways to access protected member from derived class
            //1st method => using base keyword
            base.customerId = 200;

            //2nd method => using this keyword
            this.customerId = 100;
            Console.WriteLine(customerId);

            //3rd method => using object of derived class
            CorporateCustomer CorporateCustomer = new CorporateCustomer();
            CorporateCustomer.customerId = 150;

            Console.WriteLine(CorporateCustomer.customerId);
        }
    }
}
