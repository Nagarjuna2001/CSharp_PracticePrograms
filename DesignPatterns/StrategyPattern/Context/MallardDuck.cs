using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehaviour flyBehaviour) : base(flyBehaviour) { }

        public override void display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
