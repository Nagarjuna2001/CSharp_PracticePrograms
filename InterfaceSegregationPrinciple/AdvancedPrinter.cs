using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    class AdvancedPrinter : IPrintScanContent,IPrintFaxContent
    {
        public bool PrintContent(string Content)
        {
            Console.WriteLine("Content is printed using advanced printer");
            return true;
        }
        public bool ScanContent(string Content)
        {
            Console.WriteLine("Content is Scanned using advanced printer");
            return true;
        }
        public bool PhotoCopyContent(string Content)
        {
            Console.WriteLine("Content photocopy is taken using advanced printer");
            return true;
        }

        public bool FaxContent(string Content)
        {
            Console.WriteLine("Content fax completed successfully using advanced printer");
            return true;
        }
    }
}
