using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class FruitPartitioner : IFruitVisitor
    {
        public List<Orange> Oranges { get; set; }
        public List<Apple> Apples { get; set; }
        public List<Banana> Bananas { get; set; }

        public FruitPartitioner()
        {
            Oranges = new List<Orange>();
            Apples = new List<Apple>();
            Bananas = new List<Banana>();
        }

        public void Visit(Orange fruit)
        {
            Oranges.Add(fruit);
        }

        public void Visit(Apple fruit)
        {
            Apples.Add(fruit);
        }

        public void Visit(Banana fruit)
        {
            Bananas.Add(fruit);
        }
    }
}
