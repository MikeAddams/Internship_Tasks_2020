using ConsoleApp1.SpecialExceptions;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool exception = false;

            Console.WriteLine("input: ");
            input = Console.ReadLine();

            try
            {
                ValidateInput(input);
            }
            catch(Exception e)
            {
                exception = true;

                Console.WriteLine(e.Message);
            }

            if (!exception)
            {
                Console.WriteLine($"\nYour input: {input}");
            }

            Console.ReadKey();
        }

        static void ValidateInput(string input)
        {
            if (input.Any(char.IsDigit))
            {
                throw new ContainsNumberException("The sequence contains a number.");
            }
            
            if (!Regex.IsMatch(input, "^[a-zA-Z0-9 ]*$"))
            {
                throw new ContainsSpecialCharacterException("The sequence contains a special character.");
            }
            
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Name of the user cannon be empty or null.");
            }
        }
    }
}
