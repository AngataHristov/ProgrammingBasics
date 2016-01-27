using System;
using System.Collections.Generic;

class Spiral
{
    static void Main()
    {
        Dictionary<char, int> Letters = new Dictionary<char, int>();
        Letters.Add('a', 1);
        Letters.Add('b', 2);
        Letters.Add('c', 3);
        Letters.Add('d', 4);
        Letters.Add('e', 5);
        Letters.Add('f', 6);
        Letters.Add('g', 7);
        Letters.Add('h', 8);
        Letters.Add('i', 9);
        Letters.Add('j', 10);
        Letters.Add('k', 11);
        Letters.Add('l', 12);
        Letters.Add('m', 13);
        Letters.Add('n', 14);
        Letters.Add('o', 15);
        Letters.Add('p', 16);
        Letters.Add('q', 17);
        Letters.Add('r', 18);
        Letters.Add('s', 19);
        Letters.Add('t', 20);
        Letters.Add('u', 21);
        Letters.Add('v', 22);
        Letters.Add('w', 23);
        Letters.Add('x', 24);
        Letters.Add('y', 25);
        Letters.Add('z', 26);
        Letters.Add('A', 1);
        Letters.Add('B', 2);
        Letters.Add('C', 3);
        Letters.Add('D', 4);
        Letters.Add('E', 5);
        Letters.Add('F', 6);
        Letters.Add('G', 7);
        Letters.Add('H', 8);
        Letters.Add('I', 9);
        Letters.Add('J', 10);
        Letters.Add('K', 11);
        Letters.Add('L', 12);
        Letters.Add('M', 13);
        Letters.Add('N', 14);
        Letters.Add('O', 15);
        Letters.Add('P', 16);
        Letters.Add('Q', 17);
        Letters.Add('R', 18);
        Letters.Add('S', 19);
        Letters.Add('T', 20);
        Letters.Add('U', 21);
        Letters.Add('V', 22);
        Letters.Add('W', 23);
        Letters.Add('X', 24);
        Letters.Add('Y', 25);
        Letters.Add('Z', 26);

        int size = int.Parse(Console.ReadLine());
        string keyword = Console.ReadLine();

        int rows = size;
        int cols = size;
        int index = 0;
        char[,] matrix = new char[rows, cols];

        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = rows * cols;
        for (int i = 1; i <= maxRotations; i++)
        {
            if ((direction == "right") && (col > size - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if ((direction == "down") && (row > size - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if ((direction == "left") && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if ((direction == "up") && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = keyword[index];
            if (index == keyword.Length - 1)
            {
                index = -1;
            }
            index++;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        // for (int r = 0; r < rows; r++)
        // {
        //     for (int c = 0; c < cols; c++)
        //     {
        //         Console.Write("{0, 4}", matrix[r, c]);
        //     }
        //     Console.WriteLine();
        // }

        List<int> lineWeight = new List<int>();

        for (int roow = 0; roow < rows; roow++)
        {
            int sum = new int();
            for (int cool = 0; cool < cols; cool++)
            {
                char currentSymbol = matrix[roow, cool];

                if (Letters.ContainsKey(currentSymbol))
                {
                    sum += Letters[currentSymbol] * 10;
                }
                else
                {
                    sum += (int)currentSymbol;
                }
            }
            lineWeight.Add(sum);
        }
        int max = new int();
        int maxIndex = new int();

        for (int i = 0; i < lineWeight.Count; i++)
        {
            if (lineWeight[i] > max)
            {
                max = lineWeight[i];
                maxIndex = i;
            }
        }
        Console.WriteLine("{0} - {1}", maxIndex, max);
    }
}

