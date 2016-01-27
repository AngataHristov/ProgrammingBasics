﻿using System;

class Matrix
{
    static void Main()
    {
        string input = Console.ReadLine();

        string bigNumber = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            bigNumber += Convert.ToInt32(input[i]) % 10;
        }

        string newNumber = string.Empty;

        for (int i = 0; i < bigNumber.Length; i++)
        {
            int currentNumber = int.Parse(bigNumber[i].ToString());

            if (currentNumber % 2 == 0)
            {
                newNumber += currentNumber * currentNumber;
            }
            else
            {
                int nextNumber = 0;
                int previousNumber = 0;

                if (bigNumber.Length != 1)
                {
                    if (i > 0)
                    {
                        previousNumber = int.Parse(bigNumber[i - 1].ToString());
                    }
                    if (i < bigNumber.Length - 1)
                    {
                        nextNumber = int.Parse(bigNumber[i + 1].ToString());
                    }
                    int numberAfrerMath = currentNumber + previousNumber + nextNumber;
                    newNumber += numberAfrerMath;
                }
            }
        }
        string way = Console.ReadLine();
        int length = newNumber.Length;
        int[,] matrix = new int[length, length];

        switch (way)
        {
            case "\\":
                for (int i = 0; i < length; i++)
                {
                    matrix[i, i] = int.Parse(newNumber[i].ToString());
                }
                break;
            case "/":
                for (int i = 0; i < length; i++)
                {
                    matrix[length - 1 - i, i] = int.Parse(newNumber[i].ToString());
                }
                break;
            default:
                break;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
