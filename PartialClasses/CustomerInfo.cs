using System;

namespace PartialClasses
{
    public partial class CustomerName
    {
        public string CustomerFirstName { set; get; }
        public string CustomerLastName { set; get; }
    }

    class CustomerInfo
    {
        static void Main(string[] args)
        {
            CustomerName NameOfCustomer = new CustomerName();
            NameOfCustomer.CustomerFirstName = "Steve";
            NameOfCustomer.CustomerLastName = "smith";

            Console.WriteLine("Full name is {0}", NameOfCustomer.getFullName(NameOfCustomer.CustomerFirstName, NameOfCustomer.CustomerLastName));
        }
    }
}
