using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);

    }
}
