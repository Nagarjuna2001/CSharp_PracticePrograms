using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    public class Derived : Base
    {
        public Derived() { }
        public new void printToConsole()
        {
            Console.WriteLine("Derived class method is called");
        }
    }
}
