using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorPatternExample
    {
        static void Main(string[] args)
        {
            Car compactCar = new CompactCar();
            compactCar = new Navigation(compactCar);
            compactCar = new Sunroof(compactCar);
            compactCar = new LeatherSeats(compactCar);

            Console.WriteLine(compactCar.GetDescription());
            Console.WriteLine($"{compactCar.GetCarPrice()}");
            Console.ReadKey();
        }
    }
}
