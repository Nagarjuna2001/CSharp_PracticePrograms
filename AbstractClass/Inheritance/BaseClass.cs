using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Inheritance
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.Write("base class method called");
        }
    }
    public class Derived : BaseClass
    {
        public Derived()
        {
            Print();
        }
        public new void Print()
        {
            Console.WriteLine("Derived class called");
        }
    }
    class Program
    {
        
    }
}
