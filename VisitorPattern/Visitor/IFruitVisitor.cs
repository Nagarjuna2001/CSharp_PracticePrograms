using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface IFruitVisitor
    {
        void Visit(Orange fruit);
        void Visit(Apple fruit);
        void Visit(Banana fruit);
    }
}
