using System;

namespace RefKeywordExample
{
    public class RefKeywordExercise
    {
        static void Main(string[] args)
        {
            int valueOfA = 100;
            Console.WriteLine("Value before method call is: " + valueOfA);

            RefKeywordExercise.ModifyValueOfA(ref valueOfA);

            Console.WriteLine("Value before method call is: " + valueOfA);
        }
        public static void ModifyValueOfA(ref int valueOfA)
        {
            valueOfA = valueOfA + 900;
            Console.WriteLine("Value inside method is: " + valueOfA);
        }
    }
}
