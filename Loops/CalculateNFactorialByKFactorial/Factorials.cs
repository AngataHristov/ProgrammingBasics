// Problem 6.	Calculate N! / K!
// Write a program that calculates n! / k! for given n and k(1 < k<n< 100). Use only one loop.

using System;
using System.Numerics;

class Factorials
{
    static void Main()
    {
        Console.Write("Enter positive intteger number for n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter positive intteger number for k(1 < k<n< 100): ");
        int k = int.Parse(Console.ReadLine());

        if (k <= 1 || k >= n || n >= 100)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            BigInteger product = 0;
            BigInteger nFac = 1;

            for (int i = k + 1; i <= n; i++)
            {
                nFac *= i;
            }
            product = nFac;
            Console.WriteLine("The product is: {0}", product);
        }
        Console.WriteLine();
    }
}
