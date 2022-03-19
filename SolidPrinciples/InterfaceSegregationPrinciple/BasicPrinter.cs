using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    public class BasicPrinter : IPrintScanContent
    {
        public BasicPrinter() { }

        public bool PrintContent(string Content)
        {
            Console.WriteLine("Content is printed using Basic printer");
            return true;
        }
        public bool ScanContent(string Content)
        {
            Console.WriteLine("Content is Scanned using Basic printer");
            return true;
        }
        public bool PhotoCopyContent(string Content)
        {
            Console.WriteLine("Content photocopy is taken using Basic printer");
            return true;
        }
    }
}
