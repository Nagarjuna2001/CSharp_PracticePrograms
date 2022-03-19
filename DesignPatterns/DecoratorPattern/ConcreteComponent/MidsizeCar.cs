using DecoratorPattern.Component;
using System;


namespace DecoratorPattern.ConcreteComponent
{
    // ConcreteComponent
    public class MidsizeCar : Car
    {
        public MidsizeCar()
        {
            Description = "Midsize Car";
        }

        public override double GetCarPrice() => 20000.00;
        public override string GetDescription() => Description;
    }
}
