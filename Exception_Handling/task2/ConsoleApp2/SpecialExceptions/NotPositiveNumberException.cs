using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.SpecialExceptions
{
    class NotPositiveNumberException : Exception
    {
        public override string Message { get; }
        public NotPositiveNumberException(string message)
            :base(message)
        {
            Message = "\n" + message;
        }
    }
}
