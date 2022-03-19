using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Apple : Fruit
    {
        public Apple() { }

        public override void Accept(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
