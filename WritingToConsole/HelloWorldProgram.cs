using System;

namespace WritingToConsole
{
    public class HelloWorldProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string LanguageToBeLearnt = "C#";
            Console.Write("The Programming Language required for building applications in Dot Net framework is {0}", LanguageToBeLearnt);
        }
    }
}
