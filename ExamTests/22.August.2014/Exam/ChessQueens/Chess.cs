using System;
using System.Collections.Generic;

class Chess
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int distance = int.Parse(Console.ReadLine());

        int counter = new int();

        for (int row = 97; row < size + 97; row++)
        {
            for (int col = 0; col < size; col++)
            {
                for (int i = 97; i < size + 97; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if ((row == i && Math.Abs(col - j) == distance + 1) || (col == j && Math.Abs(row - i) == distance + 1) || (Math.Abs(col - j) == distance + 1) && Math.Abs(row - i) == distance + 1)
                        {
                            Console.WriteLine("{0}{1} - {2}{3}", (char)row, col + 1, (char)i, j + 1);
                            counter++;
                        }
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No valid positions");
        }
    }
}

