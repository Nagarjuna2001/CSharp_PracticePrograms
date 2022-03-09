using System;

namespace ConstructorChaining
{
    class Base
    {
        public int id;
        public Base(int num)
        {
            this.id = num;
            Console.WriteLine("Base constructor is called");
        }
    }
    class Derived : Base
    {
        public Derived() : base(101)
        {
            Console.WriteLine("Derived constructor is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived obj = new Derived();
            Console.WriteLine(obj.id);
        }
    }
}