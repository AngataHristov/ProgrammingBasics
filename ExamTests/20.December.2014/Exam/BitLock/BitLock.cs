using System;
using System.Linq;
using System.Collections.Generic;

class BitLock
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> checks = new List<int>();

        string command = Console.ReadLine();

        while (command.ToLower() != "end")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }

            string[] splitedCommand = command.Split(' ');

            if (splitedCommand[0] == "check")
            {
                int counter = new int();

                for (int row = 0; row < 8; row++)
                {
                    int bitPosition = int.Parse(splitedCommand[1]);

                    int currentBit = numbers[row] >> bitPosition & 1;

                    if (currentBit == 1)
                    {
                        counter++;
                    }
                }
                checks.Add(counter);
            }
            else
            {
                if (splitedCommand[1] == "right")
                {
                    int rows = int.Parse(splitedCommand[0]);

                    int rotation = int.Parse(splitedCommand[2]);

                    for (int bit = 0; bit < rotation; bit++)
                    {
                        int firstBit = numbers[rows] & 1;

                        numbers[rows] = numbers[rows] >> 1;

                        if (firstBit == 1)
                        {
                            numbers[rows] = numbers[rows] | (1 << 11);
                        }
                    }
                }
                if (splitedCommand[1] == "left")
                {
                    int rows = int.Parse(splitedCommand[0]);

                    int rotation = int.Parse(splitedCommand[2]);

                    for (int bit = 0; bit < rotation; bit++)
                    {
                        int lastBit = numbers[rows] >> 11 & 1;

                        numbers[rows] = numbers[rows] << 1;

                        if (lastBit == 1)
                        {
                            numbers[rows] = numbers[rows] | 1;

                            numbers[rows] = numbers[rows] & ~(1 << 12);
                        }
                    }
                }
            }
            command = Console.ReadLine();
        }

        foreach (int result in checks)
        {
            Console.WriteLine(result);
        }
        foreach (int number in numbers)
        {
            Console.Write("{0} ", number);
        }
    }
}
