using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1.SpecialExceptions
{
    class ContainsSpecialCharacterException : Exception
    {
        public override string Message { get; }
        public ContainsSpecialCharacterException(string message) 
            : base(message)
        {
            Message = "\n" + message;
            //Console.WriteLine("The sequence contains a special character.");
        }
    }
}
