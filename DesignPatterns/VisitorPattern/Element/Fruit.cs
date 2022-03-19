using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public abstract class Fruit
    {
        public abstract void Accept(IFruitVisitor visitor);
    }
}
