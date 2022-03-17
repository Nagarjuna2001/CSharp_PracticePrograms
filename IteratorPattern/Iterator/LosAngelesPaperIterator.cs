using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public class LosAngelesPaperIterator : IIterator
    {
        private string[] reporters;
        private int currentIndex;

        public LosAngelesPaperIterator(string[] _reporters)
        {
            this.reporters = _reporters;
            currentIndex = 0;
        }
        public string CurrentItem()
        {
            return reporters[currentIndex];
        }

        public void First()
        {
            currentIndex = 0;
        }

        public bool IsDone()
        {
            return currentIndex >= reporters.Length;
        }

        public string Next()
        {
            return reporters[currentIndex++];
        }
    }
}
