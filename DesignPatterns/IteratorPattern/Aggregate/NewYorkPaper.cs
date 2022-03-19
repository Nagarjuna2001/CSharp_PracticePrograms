using System;
using System.Collections.Generic;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    // ConcreteAggregate
    public class NewYorkPaper : INewspaper
    {        
        private List<string> reporters;
        public NewYorkPaper()
        {
            reporters = new List<string>
                        {"John Mesh - NY",
                         "Susanna Lee - NY",
                         "Paul Randy - NY",
                         "Kim Fields - NY",
                         "Sky Taylor - NY"
                        };            
        }

        public IIterator CreateIterator()
        {
            return new NewYorkPaperIterator(reporters); 
        }
    }
}
