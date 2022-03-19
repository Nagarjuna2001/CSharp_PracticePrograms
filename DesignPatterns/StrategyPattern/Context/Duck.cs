using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        IFlyBehaviour flyBehaviour;
        public Duck(IFlyBehaviour flyBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
        }
        public void performFly()
        {
            flyBehaviour.fly();
        }

        public abstract void display();
        public void Swim()
        {
            Console.WriteLine("All ducks can swim (float)");
        }
    }
}
