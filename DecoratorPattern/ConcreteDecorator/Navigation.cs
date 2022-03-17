using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Navigation: CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";

        public override double GetCarPrice() => _car.GetCarPrice() + 5000;
    }
}
