using System;

class MagicWand
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int width = 3 * input + 2;

        int firstLineDots = width / 2;
        Console.WriteLine("{0}*{0}", new string('.', firstLineDots));

        int rearDots = 3 * input / 2;
        int middleDots = 1;

        for (int i = 0; i < input / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', rearDots), new string('.', middleDots));
            middleDots += 2;
            rearDots--;
        }

        Console.WriteLine("{0}{1}{0}", new string('*', input), new string('.', input + 2));

        int rearDotsTwo = 1;
        int middleDotsTwo = 3 * input - 2;
        for (int i = 0; i < input / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', rearDotsTwo), new string('.', middleDotsTwo));
            rearDotsTwo++;
            middleDotsTwo -= 2;
        }

        // Console.WriteLine("{0}*{1}**{2}**{1}*{0}", new string('.', input / 3), new string('.', input / 2), new string('.', input));

        int newRearDots = (input / 2) - 1;
        int someDots = 0;
        for (int i = 0; i < input / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', newRearDots), new string('.', input / 2), new string('.', someDots), new string('.', input));
            newRearDots--;
            someDots++;
        }

        Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', (input / 2) + 1), new string('.', input / 2), new string('.', input));

        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string('.', input));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', input), new string('*', input + 2));
    }
}
