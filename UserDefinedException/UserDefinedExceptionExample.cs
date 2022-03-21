using System;

namespace UserDefinedException
{
    public class UserDefinedExceptionExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age to proceed forward :");
            int age = int.Parse(Console.ReadLine());

            try
            {
                ValidateAge(age);
            }
            catch(InvalidAgeException invalidAgeException)
            {
                Console.WriteLine(invalidAgeException.Message);
            }
            catch(NegativeAgeException negativeAgeException)
            {
                Console.WriteLine(negativeAgeException.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ValidateAge(int age)
        {
            if (age > 0 && age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
            else if (age < 0)
            {
                throw new NegativeAgeException("Sorry, Age cannot be negative");
            }
        }
    }
}
