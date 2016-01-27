// Problem 3.	Longest Area in Array
// Write a program to find the longest area of equal elements in array of strings.You first should read 
// an integer n and n strings(each at a separate line), then find and print the longest sequence of equal
// elements(first its length, then its elements). If multiple sequences have the same maximal length,
// print the leftmost of them.

using System;

class LongestAeaIArray
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");

        int n = int.Parse(Console.ReadLine());

        string[] elements = new string[n];

        int maxArea = 1;
        int count = 1;
        string maxElement = string.Empty;

        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = Console.ReadLine();
        }

        for (int i = 0; i < elements.Length - 1; i++)
        {
            if (elements[i] == elements[i + 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxArea)
            {
                maxArea = count;
                maxElement = elements[i];
            }
        }
        Console.WriteLine(maxArea);

        for (int i = 0; i < maxArea; i++)
        {
            Console.WriteLine(maxElement);
        }
    }
}
