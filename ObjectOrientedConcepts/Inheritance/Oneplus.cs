using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Oneplus : MobilePhone
    {
        public Oneplus(string message) : base(message) { }
        public void OperatingSystemForOneplus()
        {
            Console.WriteLine("Oneplus provides Android Operating system");
        }
    }
}
