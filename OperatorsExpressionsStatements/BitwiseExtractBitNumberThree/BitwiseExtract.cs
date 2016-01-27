// Problem 11.	Bitwise: Extract Bit #3
// Using bitwise operators, write an expression for finding the value of the bit #3
// of a given unsigned integer. The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0. 

using System;

class BitwiseExtract
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        string Bitwise = Convert.ToString(number, 2);
        Console.WriteLine(Bitwise);
        int position = 3;
        int mask = number >> position;
        int result = mask & 1;
        Console.WriteLine("The value of the bit #3 is: " + result);
    }
}
