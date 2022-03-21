using System;
using System.Collections.Generic;
using System.Text;

namespace UserDefinedException
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {

        }

    }
}
