// Problem 10.	Odd and Even Product
// You are given n integers(given in a single line, separated by a space). Write a program that checks whether the product
// of the odd elements is equal to the product of the even elements.Elements are counted from 1 to n, so the first
// element is odd, the second is even, etc.

using System;
using System.Linq;

class OddEven
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers in a single line, separate by a space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int oddNumsProduct = 1;
        int evenNumsProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenNumsProduct *= numbers[i];
            }
            else
            {
                oddNumsProduct *= numbers[i];
            }
        }
        if (oddNumsProduct == evenNumsProduct)
        {
            Console.WriteLine("Yes!");
            Console.WriteLine("The product is: {0}", evenNumsProduct);
        }
        else
        {
            Console.WriteLine("No!");
            Console.WriteLine("The even product is: {0}", evenNumsProduct);
            Console.WriteLine("The odd product is: {0}", oddNumsProduct);
        }
    }
}
