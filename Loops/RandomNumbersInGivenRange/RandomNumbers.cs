// Problem 11.	Random Numbers in Given Range
// Write a program that enters 3 integers n, min and max(min ≤ max) and prints n random numbers in the range[min...max]. 

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("Enter number of the random numbers: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the min range number: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter the max range number: ");
        int max = int.Parse(Console.ReadLine());

        if (min >= max)
        {
            Console.WriteLine("Invalid input!");
        }
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            int number = rnd.Next(min, max + 1);
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}
