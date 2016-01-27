// Problem 12.	Extract Bit from Integer
// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInt
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
        Console.WriteLine("The value of the position \"p\" is: " + result);
    }
}
