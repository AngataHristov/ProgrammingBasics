// Problem 8.	Longest Word in a Text
// Write a program to find the longest word in a text.

using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        Console.WriteLine("Enter the text:");
        string[] text = Console.ReadLine().Split();

        string longestWord = string.Empty;

        foreach (string word in text)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine("The longelst word is: {0}", longestWord);
    }
}
