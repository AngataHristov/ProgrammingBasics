using System;
using System.Text;
using System.Collections.Generic;
using System.Numerics;

class PetarsGame
{
    static void Main()
    {
        ulong startingNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        const int divider = 5;
        BigInteger sum = new long();
        string numAsString;
        List<object> result = new List<object>();

        for (ulong i = startingNumber; i < endNumber; i++)
        {
            ulong remainder = i % divider;

            if (remainder == 0)
            {
                sum += i;
            }
            else
            {
                sum += remainder;
            }
        }
        numAsString = sum.ToString();
        string digitToReplace;

        if (sum % 2 == 0)
        {
            digitToReplace = numAsString[0].ToString();
        }
        else
        {
            digitToReplace = numAsString[numAsString.Length - 1].ToString();
        }
        numAsString = numAsString.Replace(digitToReplace, text);
        Console.WriteLine(numAsString);
    }
}
