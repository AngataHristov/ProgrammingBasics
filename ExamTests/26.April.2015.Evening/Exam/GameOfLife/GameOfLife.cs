using System;

class GameOfLife
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxR = 10;
        int maxC = 10;
        int[,] matrix = new int[maxR, maxC];
        int[,] resultMatrix = new int[maxR, maxC];

        int row, col;
        for (int i = 0; i < n; i++)
        {
            row = int.Parse(Console.ReadLine());
            col = int.Parse(Console.ReadLine());
            matrix[row, maxC - 1 - col] = 1;
            // resultMatrix[row, maxC - 1 - col] = 1;
        }


        int count = 0;
        for (int r = 0; r < maxR; r++)
        {
            for (int c = 0; c < maxC; c++)
            {
                for (int r2 = r - 1; r2 <= r + 1; r2++)
                {
                    for (int c2 = c - 1; c2 <= c + 1; c2++)
                    {
                        if (r2 < 0 || r2 >= maxC ||
                            c2 < 0 || c2 >= maxR ||
                            (r == r2 && c == c2))
                        {
                            continue;
                        }
                        count += matrix[r2, c2];
                    }
                }

                if ((count == 2 || count == 3) && matrix[r, c] == 1)
                {
                    resultMatrix[r, c] = 1;
                }

                else if (count == 3 && matrix[r, c] == 0)
                {
                    resultMatrix[r, c] = 1;
                }
                count = 0;
            }
        }

        for (int r = 0; r < maxR; r++)
        {
            for (int c = 0; c < maxC; c++)
            {
                Console.Write("{0}", resultMatrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}

