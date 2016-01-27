using System;

class KnightPath
{
    static void Main()
    {
        int[,] matrix = new int[9, 9];
        string input = Console.ReadLine();
        int currentRow = 0;
        int currentCol = matrix.GetLength(1) - 2;

        while (input != "stop")
        {
            switch (input)
            {
                case "left up":
                    matrix[currentRow - 1, currentCol - 2] = 1;
                    currentRow = currentRow - 1;
                    currentCol = currentCol - 2;
                    break;
                case "left down":
                    matrix[currentRow + 1, currentCol - 2] = 1;
                    currentRow = currentRow + 1;
                    currentCol = currentCol - 2;
                    break;
                case "right up":
                    matrix[currentRow - 1, currentCol + 2] = 1;
                    currentRow = currentRow - 1;
                    currentCol = currentCol + 2;
                    break;
                case "right down":
                    matrix[currentRow + 1, currentCol + 2] = 1;
                    currentRow = currentRow + 1;
                    currentCol = currentCol + 2;
                    break;
                case "up left":
                    matrix[currentRow - 1, currentCol - 2] = 1;
                    currentRow = currentRow - 1;
                    currentCol = currentCol - 2;
                    break;
                case "up right":
                    matrix[currentRow - 1, currentCol + 2] = 1;
                    currentRow = currentRow - 1;
                    currentCol = currentCol + 2;
                    break;
                case "down left":
                    matrix[currentRow + 1, currentCol - 2] = 1;
                    currentRow = currentRow + 1;
                    currentCol = currentCol - 2;
                    break;
                case "down right":
                    matrix[currentRow + 1, currentCol + 2] = 1;
                    currentRow = currentRow + 1;
                    currentCol = currentCol + 2;
                    break;
                default:
                    break;
            }
            input = Console.ReadLine();
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
