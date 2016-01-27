using System;

class Sunglasses
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('*', size * 2), new string(' ', size));

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', size * 2 - 2), new string(' ', size));
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('/', size * 2 - 2), new string('|', size));

        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', size * 2 - 2), new string(' ', size));
        }

        Console.WriteLine("{0}{1}{0}", new string('*', size * 2), new string(' ', size));
    }
}

