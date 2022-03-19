using System;

namespace VisitorPattern
{
    public class VisitorPatternExercise
    {
        static void Main(string[] args)
        {
            FruitPartitioner partitioner = new FruitPartitioner();

            var fruits = new Fruit[] { new Orange(), new Apple(), new Banana(), new Banana(), new Banana(), new Orange() };

            foreach(Fruit fruit in fruits)
            {
                fruit.Accept(partitioner);
            }

            Console.WriteLine("Oranges.Count : " + partitioner.Oranges.Count);
            Console.WriteLine("Apples.Count : " + partitioner.Apples.Count);
            Console.WriteLine("Bananas.Count : " + partitioner.Bananas.Count);
        }
    }
}
