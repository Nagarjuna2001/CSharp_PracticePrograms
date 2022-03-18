using System;

namespace MethodsInCSharp
{
    //MethodsInCSharp class contains methods showing the syntax of static and instance methods 

    class MethodsInCSharp
    {
        static void Main(string[] args)
        {
            //Calling the static methods using classname
            MethodsInCSharp.PrintOddNumbersLessThanTarget(20);
            Console.WriteLine("Addition of 10 and 20 is {0}", MethodsInCSharp.AddTwoNumbers(10, 20));


            //Calling the instance methods using instance of the class
            DivisibilityCheck ObjectToCallInstanceMethod = new DivisibilityCheck();
            ObjectToCallInstanceMethod.IsNumberDivisibleBySix(36);
        }

        //The below methods are examples of static methods which are accessed using the Class Name
        private static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        private static void PrintOddNumbersLessThanTarget(int target)
        {
            Console.WriteLine("Odd Numbers starting in the range 1 to {0} are :", target);
            int nextOddNumber = 1;

            while (nextOddNumber <= target)
            {
                Console.WriteLine(nextOddNumber);
                nextOddNumber += 2;
            }
        }

       
    }
}