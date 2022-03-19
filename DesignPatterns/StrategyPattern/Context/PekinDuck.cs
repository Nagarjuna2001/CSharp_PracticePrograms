using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class PekinDuck : Duck
    {
        public PekinDuck(IFlyBehaviour flyBehaviour) : base(flyBehaviour)
        {
            
        }
        public override void display()
        {
            Console.WriteLine("I'm a Pekin Duck");
        }
    }
}
