using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.SpecialExceptions
{
    class NegativeNumberException : Exception
    {
        public override string Message { get; }
        public NegativeNumberException(string message)
            :base(message)
        {
            Message = "\n" + message;
        }
    }
}
