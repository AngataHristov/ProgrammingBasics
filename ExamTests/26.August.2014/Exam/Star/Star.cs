using System;

class Star
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = 2 * size + 1;
        int height = (size * 2 - (size / 2 - 1));

        Console.WriteLine("{0}*{0}", new string('.', size));

        int firstRearDots = size - 1;
        int firstMiddleDots = 1;

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', firstRearDots), new string('.', firstMiddleDots));

            firstMiddleDots += 2;

            firstRearDots--;
        }

        Console.WriteLine("{0}{1}{0}", new string('*', size / 2 + 1), new string('.', size - 1));

        int secondRearDots = 1;
        int secondMiddleDots = size * 2 - 3;

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', secondRearDots), new string('.', secondMiddleDots));

            secondRearDots++;

            secondMiddleDots -= 2;
        }

        Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', size / 2), new string('.', size / 2 - 1));

        int thirdRearDots = size / 2 - 1;
        int thirdMiddleDots = 1;

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', thirdRearDots), new string('.', size / 2 - 1), new string('.', thirdMiddleDots));

            thirdRearDots--;

            thirdMiddleDots += 2;
        }

        Console.WriteLine("{0}{1}{0}", new string('*', size / 2 + 1), new string('.', size - 1));

    }
}
