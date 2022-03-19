using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyWithWings : IFlyBehaviour
    {
        public FlyWithWings() { }

        public void fly()
        {
            Console.WriteLine("I'm flying !!");
        }
    }
}
