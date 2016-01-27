// Problem 13.	Check a Bit at Given Position
// Write a Boolean expression that returns if the bit at position p(counting from 0,
// starting from the right) in given integer number n has value of 1. 

using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        string Bitwise = Convert.ToString(number, 2);
        Console.WriteLine(Bitwise);

        int mask = number >> p;
        int result = mask & 1;
        bool isOne = (result == 1);
        Console.WriteLine(isOne ? "true" : "false");
    }
}

