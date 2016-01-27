//Problem 16.	 Print Long Sequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
//You might need to learn how to use loops in C# (search in Internet).

using System;

class LongSequence
{
    static void Main()
    {
        Console.Write("The first 1000 members are: ");
        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0},".PadLeft(5), i);
            }
            else
            {
                Console.WriteLine("-{0},".PadLeft(1), i);
            }
        }
        Console.WriteLine();
    }
}
