using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicPrinter basicPrinter = new BasicPrinter();
            basicPrinter.PrintContent("Hello");
            basicPrinter.ScanContent("Mark");

            AdvancedPrinter advancedPrinter = new AdvancedPrinter();
            advancedPrinter.PrintContent("Hello");
            advancedPrinter.ScanContent("Mark");
            advancedPrinter.FaxContent("Fax some info");
        }
    }
}
