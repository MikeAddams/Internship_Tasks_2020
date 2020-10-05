using ConsoleApp2.SpecialExceptions;
using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1,
                   input2;

            Console.WriteLine("Input#1: ");
            input1 = Console.ReadLine();

            Console.WriteLine("\nInput#2: ");
            input2 = Console.ReadLine();

            try
            {
                int result = 0;
                Calculator calc = new Calculator();

                validateInput(input1, input2);
                
                result = calc.Add(input1, input2);
                Console.WriteLine($"\n{input1} + {input2} = {result}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static void validateInput(string input1, string input2)
        {
            if (!Regex.IsMatch(input1, @"^[0-9]+$") || !Regex.IsMatch(input2, @"^[0-9]+$"))
            {
                int.TryParse(input1, out int n1);
                int.TryParse(input1, out int n2);

                if (n1 < 1 || n2 < 1)
                {
                    throw new NotPositiveNumberException("One of the inputs is not a number or positive");
                }
            }
        }
    }
}
