using System;

class RockLq
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int width = 3 * size;
        int height = 2 * size;

        Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));

        int outsideDots = size - 2;
        int insideDots = size + 2;

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outsideDots), new string('.', insideDots));
            outsideDots -= 2;
            insideDots += 4;
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('.', size - 2), new string('.', size));

        int newOutDots = size - 4;
        int otherOutDot = 1;
        for (int i = 0; i < (size / 2) - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', newOutDots), new string('.', otherOutDot), new string('.', size));
            newOutDots -= 2;
            otherOutDot += 2;
        }

        int downOutDost = size - 1;
        int downInDots = size;
        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', downOutDost), new string('.', downInDots));
            downOutDost--;
            downInDots += 2;
        }
        Console.WriteLine("{0}", new string('*', width));
    }
}
