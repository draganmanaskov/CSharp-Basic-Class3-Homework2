using System;

namespace Task1_FindStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            bool isValidParseOne = int.TryParse(Console.ReadLine(), out int numberOne);

            Console.WriteLine("Enter the second number:");
            bool isValidParseTwo = int.TryParse(Console.ReadLine(), out int numberTwo);

            if(!isValidParseOne || !isValidParseTwo)
            {
                Console.WriteLine("Invalid Inputs");
                return;
            }

            if(numberOne % 2 == 0 && numberTwo % 2 == 0)
            {
                Console.WriteLine($"Both of the numbers are even. The operation and result are {numberOne} + {numberTwo} = {numberOne + numberTwo}");
            }
            else if (numberOne % 2 != 0 && numberTwo % 2 != 0)
            {
                Console.WriteLine($"Both of the numbers are odd. The operation and result are {numberOne} * {numberTwo} = {numberOne * numberTwo}");
            }
            else
            {
                Console.WriteLine($"One of the numbers is odd. The operation and result are {numberOne} - {numberTwo} = {numberOne - numberTwo}");
            }
        }
    }
}
