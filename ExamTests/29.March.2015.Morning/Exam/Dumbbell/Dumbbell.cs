using System;

class Dumbbell
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', size / 2), new string('&', (size / 2) + 1), new string('.', size));

        int rearDots = (size / 2) - 1;
        int asterisk = size / 2;
        for (int i = 0; i < (size / 2) - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', rearDots), new string('*', asterisk), new string('.', size));
            rearDots--;
            asterisk++;
        }

        Console.WriteLine("&{0}&{1}&{0}&", new string('*', size - 2), new string('=', size));

        for (int i = 0; i < (size / 2) - 1; i++)
        {
            rearDots++;
            asterisk--;
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', rearDots), new string('*', asterisk), new string('.', size));
        }

        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', size / 2), new string('&', (size / 2) + 1), new string('.', size));
    }
}
