using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class Detective
{
    static void Main()
    {
        string secredWord = Console.ReadLine();
        string message = Console.ReadLine();

        int mask = new int();
        int asciiSum = new int();
        string decruptMessage = string.Empty;

        foreach (char symbol in secredWord)
        {
            asciiSum += symbol;
        }

        do
        {
            mask = 0;

            while (asciiSum > 0)
            {
                mask += asciiSum % 10;
                asciiSum /= 10;
            }
            asciiSum = mask;

        } while (mask / 10 > 0);

        for (int i = message.Length - 1; i >= 0; i--)
        {

            if (message[i] % mask == 0)
            {
                decruptMessage += (char)(message[i] + mask);
            }
            else
            {
                decruptMessage += (char)(message[i] - mask);
            }
        }
        Console.WriteLine(decruptMessage);
    }
}
