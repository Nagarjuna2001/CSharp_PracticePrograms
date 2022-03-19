using System;

namespace SingletonDesignPattern
{
    public class User
    {
        static void Main(string[] args)
        {
            PanCard o1 = PanCard.GetInstance();
            PanCard o2 = PanCard.GetInstance();


            Console.WriteLine(o1.GetPanCardNumber());
            Console.WriteLine(o2.GetPanCardNumber());
            Console.WriteLine(o1 == o2);
        }
    }
}
