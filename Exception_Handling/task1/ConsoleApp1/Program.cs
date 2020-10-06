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

            Console.WriteLine("input: ");
            input = Console.ReadLine();

            try
            {
                ValidateInput(input);

                Console.WriteLine($"\nYour input: {input}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
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
