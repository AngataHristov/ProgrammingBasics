// Problem 7.	* Sum of 5 Numbers
// Write a program that enters 5 numbers(given in a single line, separated by a space),
// calculates and prints their sum.Examples:

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers, separated by a space: ");
        string[] input = Console.ReadLine().Split();
        double sum = new double();

        for (int i = 0; i < input.Length; i++)
        {
            sum += Convert.ToDouble(input[i]);
        }
        Console.WriteLine("The sum is: {0:F2}", sum);
    }
}
