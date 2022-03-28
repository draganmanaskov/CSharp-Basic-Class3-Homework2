using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            bool isValidParse = int.TryParse(Console.ReadLine(), out int number);

            if(!isValidParse)
            {
                Console.WriteLine("Error! Invalid Parse");
                return;
            }

            for(int i = 1; i <= number; i++)
            {
                if(i == 80)
                {
                    Console.WriteLine("The limit of 80 is reached");
                    break;
                }

                if(i % 5 == 0 )
                {
                    continue;
                }

                Console.WriteLine(i);
            }

        }
    }
}
