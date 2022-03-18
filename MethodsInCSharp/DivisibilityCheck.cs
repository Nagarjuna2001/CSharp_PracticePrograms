using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsInCSharp
{
    class DivisibilityCheck
    {
        public DivisibilityCheck() { }

        //The below method is an example of instance method which is accessed using the instance of the class
        public void IsNumberDivisibleBySix(int number)
        {
            if (number % 6 == 0)
            {
                Console.WriteLine("{0} is divisible by 6", number);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 6", number);
            }
        }
    }
}
