// Problem 1.	Odd or Even Integers
// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter integer number:");
        string input = Console.ReadLine();
        int number = new int();
        bool isNumber = int.TryParse(input, out number);
        if (isNumber)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Is Odd?--->false");
            }
            else
            {
                Console.WriteLine("Is Odd?--->true");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Enter a number!");
            Main();
        }

    }
}
