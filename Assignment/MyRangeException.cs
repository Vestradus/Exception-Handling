using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class MyRangeException : Exception
    {
        public MyRangeException()
            : base("Please enter a double value.\n")
        {
            // Empty body
        } // End default constructor

        public MyRangeException(string messageValue)
            : base(messageValue)
        {
            // Empty body
        } // End one-argument constructor

        public MyRangeException(string messageValue,
            Exception inner)
            :base(messageValue, inner)
        {
            // Empty body
        } // End two-argument constructor
    }
}
