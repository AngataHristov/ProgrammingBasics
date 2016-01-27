// Problem 13.	Binary to Decimal Number
// Using loops write a program that converts a binary integer number to its decimal form.The input is entered as string.
// The output should be a variable of type long. Do not use the built-in .NET functionality. 

using System;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter your binary number: ");
        string binary = Console.ReadLine();

        long dec = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '0')
            {
                continue;
            }

            dec += (long)Math.Pow(2, i);
        }

        Console.WriteLine(dec);
    }
}
