using System;
using System.Collections.Generic;
using System.Text;

namespace UserDefinedException
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException(string message) : base(message) { }
    }
}
