using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    interface IPrintFaxContent
    {
        bool FaxContent(string ReceivedContent);
    }
}
