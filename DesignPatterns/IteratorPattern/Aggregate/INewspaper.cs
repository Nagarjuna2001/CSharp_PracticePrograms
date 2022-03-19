using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Aggregate
{
    // Aggregate
    public interface INewspaper
    {
        IIterator CreateIterator();
    }
}
