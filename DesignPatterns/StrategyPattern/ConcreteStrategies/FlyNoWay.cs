using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyNoWay : IFlyBehaviour
    {
        public FlyNoWay() { }

        public void fly()
        {
            Console.WriteLine("I can't fly !!");
        }
    }
}
