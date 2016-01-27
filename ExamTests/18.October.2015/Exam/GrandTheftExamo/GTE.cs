using System;
using System.Collections.Generic;

class GTE
{
    static void Main()
    {
        int slappesThieves = 5;
        int numberOfEscapeAttempts = int.Parse(Console.ReadLine());
        List<long> numberOfThieves = new List<long>();
        List<long> numberOfBeers = new List<long>();

        for (int i = 0; i < 2 * numberOfEscapeAttempts; i++)
        {
            long currrentInput = long.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                numberOfThieves.Add(currrentInput);
            }
            else
            {
                numberOfBeers.Add(currrentInput);
            }
        }

        long totalBeers = new long();
        long totalSlappedThieves = new long();
        long totalEscapedThieves = new long();

        for (int i = 0; i < numberOfEscapeAttempts; i++)
        {
            totalBeers += numberOfBeers[i];

            if (numberOfThieves[i] < 5)
            {
                totalSlappedThieves += numberOfThieves[i];
                totalEscapedThieves += 0;
            }
            else
            {
                totalSlappedThieves += slappesThieves;
                totalEscapedThieves += numberOfThieves[i] - slappesThieves;
            }
        }
        long packs = totalBeers / 6;
        long bottles = totalBeers % 6;
        if (totalBeers < 6)
        {
            packs = 0;
            bottles = totalBeers;
        }

        Console.WriteLine("{0} thieves slapped.", totalSlappedThieves);
        Console.WriteLine("{0} thieves escaped.", totalEscapedThieves);
        Console.WriteLine("{0} packs, {1} bottles.", packs, bottles);
    }
}
