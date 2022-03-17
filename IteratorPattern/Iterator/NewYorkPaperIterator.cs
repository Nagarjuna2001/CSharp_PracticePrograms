using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public class NewYorkPaperIterator : IIterator
    {
        private List<string> reporters;
        private int currentIndexPosition;

        public NewYorkPaperIterator(List<string> _reporters)
        {
            this.reporters = _reporters;
            currentIndexPosition = 0;
        }

        public string CurrentItem()
        {
            return reporters.ElementAt(currentIndexPosition);
        }

        public void First()
        {
            currentIndexPosition = 0;
        }

        public bool IsDone()
        {
            return currentIndexPosition >= reporters.Count;
        }

        public string Next()
        {
            return reporters.ElementAt(currentIndexPosition++);
        }
    }
}
