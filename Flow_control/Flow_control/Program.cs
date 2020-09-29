using System;

namespace Flow_control
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Your alphanumerical input: ");
            str = Console.ReadLine();

            if( !string.IsNullOrEmpty(str) )
            {
                if( str.StartsWith("A") || str.StartsWith("c") )
                {
                    str = str.Remove(0, 1);

                    Console.WriteLine("\nFirst character was removed\nCurrent string => " + str);
                }
                else if( Char.IsNumber(str, 0) )
                {
                    int n = int.Parse(str.Substring(0, 1));

                    if (n < 5)
                        Console.WriteLine("First char is a number lower than 5");
                }
                else
                    Console.WriteLine("The input does not meet the requirements.");

            }
            else
                Console.WriteLine("empty input");

            Console.ReadKey();
        }
    }
}
