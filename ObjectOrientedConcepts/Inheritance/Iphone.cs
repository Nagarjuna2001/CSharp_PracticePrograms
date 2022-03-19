using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Iphone : MobilePhone
    {
        public Iphone(string message) : base(message) { }
        public void OperatingSystemForIphones()
        {
            Console.WriteLine("Operating System used in Iphones is iOS");
        }
    }
}
