using System;

namespace StrategyPattern
{
    public class StrategyPatternExercise
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck(new FlyWithWings());
            mallardDuck.display();
            mallardDuck.performFly();
            mallardDuck.Swim();

            Console.WriteLine("\n");

            Duck pekinDuck = new PekinDuck(new FlyNoWay());
            pekinDuck.display();
            pekinDuck.performFly();
            pekinDuck.Swim();

        }
    }
}
