using DecoratorPattern.Component;
using System;


namespace DecoratorPattern.ConcreteComponent
{
    // ConcreteComponent
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override double GetCarPrice() => 10000.00;
        public override string GetDescription() => Description;
    }
}
