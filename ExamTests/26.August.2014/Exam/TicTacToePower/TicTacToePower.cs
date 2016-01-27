using System;
using System.Collections.Generic;

class TicTacToePower
{
    static void Main()
    {
        int cordX = int.Parse(Console.ReadLine());
        int cordY = int.Parse(Console.ReadLine());
        int firstCellValue = int.Parse(Console.ReadLine());

        int[,] table = new int[3, 3];

        int[,] indexes = new int[3, 3];

        int counter = new int();

        for (int row = 0; row < table.GetLength(0); row++)
        {
            for (int col = 0; col < table.GetLength(1); col++)
            {
                table[row, col] = firstCellValue;
                firstCellValue++;
            }
        }

        for (int i = 0; i < indexes.GetLength(0); i++)
        {
            for (int j = 0; j < indexes.GetLength(1); j++)
            {
                counter++;
                indexes[i, j] = counter;
            }
        }      

        long result = (long)Math.Pow(table[cordY, cordX], indexes[cordY, cordX]);

        Console.WriteLine(result);
    }
}

