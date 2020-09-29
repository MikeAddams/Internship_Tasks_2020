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

            }
            else
                Console.WriteLine("empty input");

        }
    }
}
