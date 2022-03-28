using System;

namespace Task2_SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLimit = 6;

            int[] numberArray = new int[numberLimit];

            int sumOfEven = 0;

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

                //We can do this here or we can create anothere foreach loop
                //if the number is even add it to the sum variable
                if (number % 2 == 0)
                {
                    sumOfEven += number;
                }

            }

            Console.WriteLine($"The result is: {sumOfEven}");
        }
    }
}
