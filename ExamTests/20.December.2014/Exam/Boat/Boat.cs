using System;

class Boat
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int sailWidth = size * 2;
        int sailHeight = size;
        int leftDots = size - 1;
        int asterisk = 1;

        for (int i = 0; i < (size / 2 + 1); i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', leftDots), new string('*', asterisk), new string('.', size));
            leftDots -= 2;
            asterisk += 2;
        }
        leftDots += 2;
        asterisk -= 2;
        for (int i = 0; i < size / 2; i++)
        {
            leftDots += 2;
            asterisk -= 2;
            Console.WriteLine("{0}{1}{2}", new string('.', leftDots), new string('*', asterisk), new string('.', size));
        }
        int bodyWidth = size * 2;
        int bodyHeight = size / 2;

        for (int i = 0; i < bodyHeight; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', i), new string('*', bodyWidth), new string('.', i));
            bodyWidth -= 2;
        }
    }
}
