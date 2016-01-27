// Problem 1.	Sum of 3 Numbers
// Write a program that reads 3 real numbers from the console and prints their sum.Examples:

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secomdNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double sum = firstNumber + secomdNumber + thirdNumber;
        Console.WriteLine("The sum is: {0}",sum);
        Console.WriteLine();
    }
}
