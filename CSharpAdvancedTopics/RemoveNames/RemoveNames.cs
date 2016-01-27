// Problem 6.	Remove Names
// Write a program that takes as input two lists of names and removes from the first list all names given in the second list.
// The input and output lists are given as words, separated by a space, each list at a separate line.

using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Enter list of names split by a single space: ");
        string[] firstInput = Console.ReadLine().Split();
        string[] secondInput = Console.ReadLine().Split();

        List<string> firstList = new List<string>();
        List<string> seconList = new List<string>();
        List<string> finalList = new List<string>();

        for (int i = 0; i < firstInput.Length; i++)
        {
            firstList.Add(firstInput[i]);
        }

        for (int i = 0; i < secondInput.Length; i++)
        {
            seconList.Add(secondInput[i]);
        }

        foreach (string name in firstList)
        {
            if (seconList.Contains(name))
            {
                continue;
            }
            else
            {
                finalList.Add(name);
            }
        }
        string names = string.Join(" ", finalList);
        Console.WriteLine(names);
    }
}
