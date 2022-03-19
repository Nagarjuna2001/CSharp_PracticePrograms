using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Orange : Fruit
    {
        public Orange() { }

        public override void Accept(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
