using IteratorPattern.Aggregate;
using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class IteratorPatternExercise
    {
        static void Main(string[] args)
        {
            INewspaper newYorkPaper = new NewYorkPaper();
            INewspaper losAngelesPaper = new LosAngelesPaper();

            IIterator nypIterator = newYorkPaper.CreateIterator();
            IIterator lapIterator = losAngelesPaper.CreateIterator();

            Console.WriteLine("--------   NewYorkPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("--------   LosAngelesPaper");
            PrintReporters(lapIterator);

            Console.ReadLine();
        }

        static void PrintReporters(IIterator iterator) {
            iterator.First();
            while(!iterator.IsDone()){
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
