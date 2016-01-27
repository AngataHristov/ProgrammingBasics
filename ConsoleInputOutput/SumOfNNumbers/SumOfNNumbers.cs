// Problem 9.	* Sum of n Numbers
// Write a program that enters a number n and after that enters more n
// numbers and calculates and prints their sum.Note that you may need to use a for-loop.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter the number of members: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("The sum is: {0:F2}", sum);

        // Решение, със записване на числата в масив:
        // Console.Write("Enter the number of members: ");
        // int n = int.Parse(Console.ReadLine());
        // double[] numbers = new double[n];
        // double sum = 0;
        // 
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = double.Parse(Console.ReadLine());
        //     sum += numbers[i];
        // }
        // Console.WriteLine("The sum is: {0:F2}", sum);
    }
}
