using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.SpecialExceptions
{
    class IsZeroException : Exception
    {
        public override string Message { get; }
        public IsZeroException(string message)
            : base(message)
        {
            Message = "\n" + message;
        }
    }
}
