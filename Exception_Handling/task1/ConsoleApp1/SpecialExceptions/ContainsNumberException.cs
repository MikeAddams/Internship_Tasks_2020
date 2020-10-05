using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SpecialExceptions
{
    class ContainsNumberException : Exception
    {
        public override string Message { get; }

        public ContainsNumberException(string message)
            : base(message)
        {
            Message = "\n" + message;
            //Console.WriteLine("The sequence contains a number.");
        }
    }
}
