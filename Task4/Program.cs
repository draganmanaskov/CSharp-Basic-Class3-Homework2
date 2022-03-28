using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLimit = 10;

            int[] numberArray = new int[numberLimit];


            for (int i = 0; i < numberLimit; i++)
            {
                Console.WriteLine($"Enter integer no.{i + 1}");
                bool isValidParse = int.TryParse(Console.ReadLine(), out int number);

                //ask the user again, until we get a valid input
                if (!isValidParse)
                {
                    Console.WriteLine("Invalid Input! Please Enter a number");
                    i--;
                    continue;
                }

                //add number to array
                numberArray[i] = number;
            }

            int max = numberArray[0];
            int min = numberArray[0];
          

            foreach (int number in numberArray)
            {
                //find max
                if(number > max)
                {
                    max = number;
                }

                //find min
                if(number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"The maximum is: {max}");
            Console.WriteLine($"The minimum is: {min}");
        }
    }
}
