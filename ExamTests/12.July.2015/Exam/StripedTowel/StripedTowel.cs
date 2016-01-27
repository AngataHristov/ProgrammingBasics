using System;

class drawing
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int bottomWidth = size * 2;
        int topWidth = size + 1;
        int height = 3 * size + 1;

        Console.WriteLine("{0}{1}{0}", new string(' ', (bottomWidth - topWidth) / 2), new string('*', topWidth));

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', (bottomWidth - topWidth) / 2), new string(' ', size - 1));
        }

        int whiteSpace = 0;
        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', ((bottomWidth - topWidth) / 2) - whiteSpace), new string(' ', size - 1 + whiteSpace + whiteSpace));
            whiteSpace++;
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("*{0}*", new string('.', bottomWidth - 2));
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("*{0}*", new string('@', bottomWidth - 2));
        }

        Console.WriteLine("{0}", new string('*', bottomWidth));

    }
}

