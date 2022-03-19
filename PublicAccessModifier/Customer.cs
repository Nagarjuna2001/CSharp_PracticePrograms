using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateAccessModifier
{
    public class Customer
    {
        public Customer()
        {

        }

        private int customerId;

        public int ID
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }
    }
}
