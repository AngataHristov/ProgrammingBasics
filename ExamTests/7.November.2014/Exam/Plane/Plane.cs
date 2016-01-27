using System;

class Plane
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = 3 * size;
        int height = size * 3 - size / 2;

        Console.WriteLine("{0}*{0}", new string('.', size + size / 2));

        int firstRearDots = size - 1 + size / 2;
        int firstMiddleDots = 1;
        for (int i = 0; i < (size / 2) + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', firstRearDots), new string('.', firstMiddleDots));
            firstRearDots--;
            firstMiddleDots += 2;
        }

        for (int i = 0; i < (size / 2); i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', firstRearDots), new string('.', firstMiddleDots));
            firstRearDots -= 2;
            firstMiddleDots += 4;
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('.', size - 2), new string('.', size));

        int secondRearDots = size - 4;
        int secondMiddleDots = 1;
        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', secondRearDots), new string('.', secondMiddleDots), new string('.', size));

            secondMiddleDots += 2;
            secondRearDots -= 2;
        }

        int thirdRearDots = size - 1;
        int thirdMiddleDots = size;
        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', thirdRearDots), new string('.', thirdMiddleDots));
            thirdRearDots--;
            thirdMiddleDots += 2;
        }

        Console.WriteLine("{0}", new string('*', width));
    }
}
