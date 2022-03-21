using System;

namespace ConstReadonlyKeywords
{
    public class ConstReadOnlyKeywordsExample
    {
        public const int OneMetreInCM = 100;
        public static readonly double PI;
        static ConstReadOnlyKeywordsExample()
        {
            PI = 3.142;
        }
        static void Main(string[] args)
        {
            //OneMetreInCM = 50;              This line gives a compiler error as the const variable is not allowed to change its value
            ConstReadOnlyKeywordsExample exampleObject = new ConstReadOnlyKeywordsExample();

            Console.WriteLine(OneMetreInCM);
            Console.WriteLine(PI);
            
        }
    }
}
