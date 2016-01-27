// Problem 7.	Calculate N! / (K! * (N-K)!)
// In combinatorics, the number of ways to choose k different members out of a group of n different elements
// (also known as the number of combinations) is calculated by the following formula:
// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k(1 < k<n< 100).
// Try to use only two loops.

using System;

class Combinations
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
            double product = 0;
            int nFac = 1;
            int nKFac = 1;

            for (int i = k + 1; i <= n; i++)
            {
                nKFac *= i;
            }
            for (int i = 1; i <= n - k; i++)
            {
                nFac *= i;
            }
            product = (double)nKFac / nFac;
            Console.WriteLine("The product is: {0}", product);
        }
        Console.WriteLine();
    }
}
