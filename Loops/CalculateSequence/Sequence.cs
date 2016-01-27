// Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
// Write a program that, for a given two integer numbers n and x, calculates the
// sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.Use only one loop.Print the result with 5 digits
// after the decimal point.

using System;

class Sequence
{
    static void Main()
    {
        Console.WriteLine("Calculation of the sequence: S = 1 + 1!/x + 2!/x2 + … + n!/x^n");
        Console.Write("Enter integer number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter integer number x: ");
        int x = int.Parse(Console.ReadLine());

        int factorial = 1;
        double sum = 1;
        int xPow = x;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            sum += (double)factorial / xPow;
            xPow *= x;
        }
        Console.WriteLine("The sum is: {0:F5}", sum);
    }
}
