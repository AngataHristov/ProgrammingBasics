using System;

class KingThieves
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        int linesCount = size / 2;
        int symbolCounts = 1;

        for (int i = 0; i < (size / 2) + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', linesCount), new string(symbol, symbolCounts));
            linesCount--;
            symbolCounts += 2;
        }
        linesCount++;
        symbolCounts -= 2;

        for (int i = 0; i < (size / 2); i++)
        {
            linesCount++;
            symbolCounts -= 2;
            Console.WriteLine("{0}{1}{0}", new string('-', linesCount), new string(symbol, symbolCounts));
        }
    }
}
