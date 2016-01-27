// Problem 2.	Sorting Numbers
// Write a program that reads a number n and a sequence of n integers, sorts them and prints them.

using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter the number of integer numbers: ");

        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        Console.WriteLine("The sorted numbers are: ");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();
    }
}
