using System;

class Car
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = 3 * size;

        Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));

        int firstRearDots = size - 1;
        int firstMidDots = size;

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', firstRearDots), new string('.', firstMidDots));

            firstRearDots--;
            firstMidDots += 2;
        }

        Console.WriteLine("{0}{1}{0}", new string('*', size / 2 + 1), new string('.', 2 * size - 2));

        for (int i = 0; i < size / 2 - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', width - 2));
        }

        Console.WriteLine("{0}", new string('*', width));

        for (int i = 0; i < size / 2 - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', size / 2), new string('.', size / 2 - 1), new string('.', size - 2));
        }

        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', size / 2), new string('*', size / 2 + 1), new string('.', size - 2));
    }
}
