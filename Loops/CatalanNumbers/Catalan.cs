// Problem 8.	Catalan Numbers
// In combinatorics, the Catalan numbers are calculated by the following formula:
//   (2n!)/((n+1)!*n!) for n>=0
// Write a program to calculate the nth Catalan number by given n(1 < n< 100). 

using System;
using System.Numerics;

class Catalan
{
    static void Main()
    {
        Console.WriteLine("Calculation of the Catalan numbers: C = (2n!)/((n+1)!*n!)");
        // (2n!)/((n+1)!*n!)=(2n!)/(n!*(n+1)*n!)
        Console.Write("Enter integer number n: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 1 || n >= 100)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            BigInteger nFac = 1;
            BigInteger result = 0;
            BigInteger doubleNFac = 1;

            for (int i = 1; i <= n; i++)
            {
                nFac *= i;
            }
            for (int i = 2; i <= 2 * n; i++)
            {
                doubleNFac *= i;
            }
            result = doubleNFac / (nFac * (n + 1) * nFac);
            Console.WriteLine("C= {0}", result);
        }
    }
}
