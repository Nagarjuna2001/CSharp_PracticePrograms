using System;

namespace MethodHiding
{
    class Base
    {
        public void print()
        {
            Console.WriteLine("Base method is called");
        }
    }

    class Derived : Base
    {
        public new void print()
        {
            Console.WriteLine("Derived method is called");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base obj = new Derived();
            obj.print();

        }
    }
}
