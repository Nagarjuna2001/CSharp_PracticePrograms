using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    public interface IPrintFaxContent
    {
        bool FaxContent(string ReceivedContent);
    }
}
