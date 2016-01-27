// Problem 9.	Matrix of Numbers
// Write a program that reads from the console a positive integer number n(1 ≤ n ≤ 20) 
// and prints a matrix like in the examples below.Use two nested loops.

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter positive integer number n(1 ≤ n ≤ 20): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 20)
        {
            Console.WriteLine("Invalid input!");
        }
        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col <= (n + row - 1); col++)
            {
                Console.Write("{0} ", col);
            }
            Console.WriteLine();
        }
    }
}
