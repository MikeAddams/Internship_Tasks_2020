using System;

namespace Flow_Control2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1,
                   input2;

            Console.WriteLine("input#1 : ");
            input1 = Console.ReadLine();
            Console.WriteLine("input#2 : ");
            input2 = Console.ReadLine();

            if( !int.TryParse(input1, out int result1) || !int.TryParse(input2, out int result2) )
                Console.WriteLine("\nInput error!");
            else if( result1 < 1 || result2 < 1 )
                Console.WriteLine("\nOne of the inputs is either 0 or a negative number.");
            else if( result1 > 0 && result2 > 0 && result1 + result2 >= 42 )
                Console.WriteLine($"\n{result1} + {result2} = {result1+result2}");
            else
                Console.WriteLine("Sum of numbers is less than 42");

            Console.ReadKey();
        }
    }
}