// Problem 4.	Matrix of Palindromes
// Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns

using System;
using System.Linq;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Enter the height and the width of the matrix, split by single space: ");
        int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int rows = size[0];
        int cols = size[1];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0}{1}{0} ", new string((char)(row + 97), 1), new string((char)(row + col + 97), 1));
            }
            Console.WriteLine();
        }
    }
}

