using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    public class Base
    {
        public Base() { }
        public void printToConsole()
        {
            Console.WriteLine("Base class method is called");
        }
    }
}
