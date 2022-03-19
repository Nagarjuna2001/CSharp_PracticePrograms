using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Banana : Fruit
    {
        public Banana() { }

        public override void Accept(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
