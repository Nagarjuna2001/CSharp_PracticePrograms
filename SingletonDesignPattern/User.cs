using System;

namespace SingletonDesignPattern
{
    class User
    {
        static void Main(string[] args)
        {
            PanCard o1 = PanCard.GetInstance();
            PanCard o2 = PanCard.GetInstance();

            Console.WriteLine(o1 == o2);
        }
    }
}
