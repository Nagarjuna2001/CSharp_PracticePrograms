using System;

namespace StaticClasses
{
    public class StaticClassesExercise
    {
        static void Main()
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");
            Console.Write(":");

            string selection="";
            bool validConverterSelected = false;
            do
            {
                validConverterSelected = true;
                try
                {
                    selection = Console.ReadLine();
                    if (selection != "1" && selection != "2") throw new Exception("Please select a valid option");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    validConverterSelected = false;
                }
            }
            while (!validConverterSelected);

            double tempInFahrenheit, tempInCelsius = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    tempInFahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine() ?? "0");
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", tempInFahrenheit);
                    break;

                case "2":
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    tempInCelsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine() ?? "0");
                    Console.WriteLine("Temperature in Celsius: {0:F2}", tempInCelsius);
                    break;

                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }
        }
    }
}
