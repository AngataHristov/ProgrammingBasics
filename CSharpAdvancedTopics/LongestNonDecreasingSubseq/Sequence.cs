// Problem 5.	* Longest Non-Decreasing Subsequence
// Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence.
// In other words, you should remove a minimal number of numbers from the starting sequence, so that the resulting 
// sequence is non-decreasing.In case of several longest non-decreasing sequences, print the leftmost of them.
// The input and output should consist of a single line, holding integer numbers separated by a space.

using System;
using System.Collections.Generic;
using System.Linq;

class Sequence
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integer numbers, split by a single space: ");
        int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Array.Sort(sequence);

        List<int> listOfNumbers = new List<int>();

        for (int i = 0; i < sequence.Length; i++)
        {
            listOfNumbers.Add(sequence[i]);
        }
        List<int> otherListOfNumbers = new List<int>();

        foreach (int number in listOfNumbers)
        {
            if (otherListOfNumbers.Contains(number))
            {
                continue;
            }
            else
            {
                otherListOfNumbers.Add(number);
            }
        }

        int currentEqualLength = 1;
        int maxEqualLength = new int();
        int equalNumber = new int();

        int currentIncreaseLength = 1;
        int maxIncreaseLength = new int();
        int increaseNumber = new int();

        for (int i = 0; i < otherListOfNumbers.Count - 1; i++)
        {
            int currentNumber = otherListOfNumbers[i];

            if (currentNumber == otherListOfNumbers[i + 1])
            {
                currentEqualLength++;
            }
            else
            {
                currentEqualLength = 1;
            }
            if (currentEqualLength > maxEqualLength)
            {
                maxEqualLength = currentEqualLength;
                equalNumber = currentNumber;
            }

            if (currentNumber == (otherListOfNumbers[i + 1] - 1))
            {
                currentIncreaseLength++;
            }
            else
            {
                currentIncreaseLength = 1;
            }
            if (currentIncreaseLength > maxIncreaseLength)
            {
                maxIncreaseLength = currentIncreaseLength;
                increaseNumber = currentNumber;
            }
        }
        if (maxEqualLength > maxIncreaseLength)
        {
            for (int i = 0; i < maxEqualLength; i++)
            {
                Console.Write("{0} ", equalNumber);
            }
        }
        else
        {
            int num = increaseNumber - maxIncreaseLength + 2;

            for (int i = 0; i < maxIncreaseLength; i++)
            {
                Console.Write("{0} ", num);
                num++;
            }
        }
    }
}
