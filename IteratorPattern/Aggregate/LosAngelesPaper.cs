using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    // ConcreteAggregate
    public class LosAngelesPaper : INewspaper
    {        
        private string[] reporters;
        public LosAngelesPaper()
        {
            reporters = new[] { "Ronald Smith - LA",
                                 "Danny Glover - LA",
                                 "Yolanda Adams - LA",
                                 "Jerry Straight - LA",
                                 "Rhonda Lime - LA",
                                };
        }

        public IIterator CreateIterator()
        {
            return new LosAngelesPaperIterator(reporters);
        }
    }
}
