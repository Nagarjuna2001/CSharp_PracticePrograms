using System;

namespace Methods
{
    //MethodsInCSharp class contains methods showing the syntax of static and instance methods 

    class MethodsInCSharp
    {
        static void Main(string[] args)
        {
            MethodsInCSharp.PrintOddNumbersLessThanTarget(20);
            Console.WriteLine("Addition of 10 and 20 is {0}", MethodsInCSharp.AddTwoNumbers(10, 20));

            MethodsInCSharp ObjectToCallInstanceMethod = new MethodsInCSharp();
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

        //The below method is an example of instance method which are accessed using the instance of the class

        private void IsNumberDivisibleBySix(int number)
        {
            if (number % 6 == 0)
            {
                Console.WriteLine("{0} is divisible by 6", number);
            }
            else { 
                Console.WriteLine("{0} is not divisible by 6", number);
            }
        }
    }
}