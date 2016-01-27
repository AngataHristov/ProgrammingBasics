using System;
using System.Linq;
using System.Collections.Generic;

class PaintBall
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[,] canvas = new int[10, 10];

        for (int row = 0; row < canvas.GetLength(0); row++)
        {
            for (int col = 0; col < canvas.GetLength(1); col++)
            {
                canvas[row, col] = 1;
            }
        }

        while (input.ToLower() != "end")
        {
            int counter = 0;

            if (string.IsNullOrWhiteSpace(input))
            {
                input = Console.ReadLine();
                continue;
            }
            int[] target = input.Split(' ').Select(int.Parse).ToArray();

            int targetRow = target[0];

            if (targetRow <= 0)
            {
                targetRow = 0;
            }
            int targetCol = target[1] - 1;

            if (targetCol <= 0)
            {
                targetCol = 0;
            }
            int targetRad = target[2];

            int beginingRow = targetRow - targetRad;
            int endingRow = targetRow + targetRad + 1;
            int beginingCol = targetCol - targetRad;
            int endingCol = targetCol + targetRad + 1;

            if (beginingRow < 0)
            {
                beginingRow = 0;
            }
            if (beginingCol < 0)
            {
                beginingCol = 0;
            }
            if (endingRow >= canvas.GetLength(0))
            {
                endingRow = canvas.GetLength(0) - 1;
            }
            if (endingCol >= canvas.GetLength(1))
            {
                endingCol = canvas.GetLength(1) - 1;
            }

            for (int row = beginingRow; row < endingRow; row++)
            {
                for (int col = beginingCol; col < endingCol; col++)
                {
                    if (counter % 2 == 0)
                    {
                        canvas[row, col] = 0;
                    }
                    else
                    {
                        canvas[row, col] = 1;
                    }
                }
            }
            input = Console.ReadLine();
            counter++;
        }

        // for (int row = 0; row < canvas.GetLength(0); row++)
        // {
        //     for (int col = 0; col < canvas.GetLength(1); col++)
        //     {
        //         Console.Write(canvas[row, col]);
        //     }
        //     Console.WriteLine();
        // }

        List<int> lineNumbers = new List<int>();

        for (int row = 0; row < canvas.GetLength(0); row++)
        {
            List<int> currentLine = new List<int>();

            for (int col = 0; col < canvas.GetLength(1); col++)
            {
                currentLine.Add(canvas[row, col]);
            }

            int dec = new int();

            for (int i = 0; i < currentLine.Count; i++)
            {
                if (currentLine[currentLine.Count - i - 1] == 0)
                {
                    continue;
                }
                dec += (int)Math.Pow(2, i);
            }
            lineNumbers.Add(dec);
        }
        int totalSum = new int();

        foreach (int number in lineNumbers)
        {
            // Console.WriteLine(number);
            totalSum += number;
        }
        Console.WriteLine(totalSum);
    }
}
