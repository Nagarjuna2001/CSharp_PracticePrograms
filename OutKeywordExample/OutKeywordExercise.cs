using System;

namespace OutKeywordExample
{
    public class OutKeywordExercise
    {
        static void Main(string[] args)
        {
            int firstNum = 25, secondNum = 50, SumOfNumbers, ProductOfNumbers;

            PerformArithmeticOperations(firstNum, secondNum, out SumOfNumbers, out ProductOfNumbers);

            Console.WriteLine("Sum of numbers is : " + SumOfNumbers);
            Console.WriteLine("Product of numbers is : " + ProductOfNumbers);

        }
        public static void PerformArithmeticOperations(int firstNum,int secondNum,out int sum,out int product)
        {
            sum = firstNum + secondNum;
            product = firstNum * secondNum;
        }
    }
}
