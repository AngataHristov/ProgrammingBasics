// Problem 3.	Min, Max, Sum and Average of N Numbers
// Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
// the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).
// The input starts by the number n(alone in a line) followed by n lines, each holding an integer number.
// The output is like in the examples below.

using System;

class MinMaxSumAvr
{
    static void Main()
    {
        Console.Write("Enter the number of the members: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int sum = new int();
        double average = new double();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter an integer number: ");
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        average = (double)sum / n;

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("average={0:F2}", average);
    }
}
