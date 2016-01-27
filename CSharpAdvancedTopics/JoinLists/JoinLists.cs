// Problem 7.	Join Lists
// Write a program that takes as input two lists of integers and joins them.The result should
// hold all numbers from the first list, and all numbers from the second list, without repeating numbers,
// and arranged in increasing order. The input and output lists are given as integers, separated by a space,
// each list at a separate line. 

using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Enter list of numbers split by a single space: ");
        int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> firstList = new List<int>();
        List<int> seconList = new List<int>();
        List<int> finalList = new List<int>();

        for (int i = 0; i < firstInput.Length; i++)
        {
            firstList.Add(firstInput[i]);
        }

        for (int i = 0; i < secondInput.Length; i++)
        {
            seconList.Add(secondInput[i]);
        }

        foreach (int number in firstList)
        {
            if (finalList.Contains(number))
            {
                continue;
            }
            else
            {
                finalList.Add(number);
            }
        }

        foreach (int number in seconList)
        {
            if (finalList.Contains(number))
            {
                continue;
            }
            else
            {
                finalList.Add(number);
            }
        }

        finalList.Sort();

        string numbers = string.Join(" ", finalList);

        Console.WriteLine(numbers);
    }
}
