// Problem 11.	* Numbers in Interval Dividable by Given Number
// Write a program that reads two positive integer numbers and prints
// how many numbers p exist between them such that the reminder of the division by 5 is 0. Examples

using System;

class NumsInIntervalDivByGivenNum
{
    static void Main()
    {
        Console.Write("Enter the first positive integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the first positive integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int counter = new int();

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("Between {0} and {1} \"p\" exist {2} times.", firstNumber, secondNumber, counter);
    }
}

