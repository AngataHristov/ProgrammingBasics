using System;

class Headphones
{
    static void Main()
    {
        int diameter = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{1}*{0}", new string('-', diameter / 2), new string('*', diameter));

        for (int i = 0; i < diameter - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', diameter / 2), new string('-', diameter));
        }

        int outsideDashes = diameter / 2;
        int insideDashes = diameter;
        int asterisk = 1;
        for (int i = 0; i < (diameter / 2) + 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outsideDashes), new string('*', asterisk), new string('-', insideDashes));
            asterisk += 2;
            insideDashes -= 2;
            outsideDashes--;
        }
        asterisk -= 2;
        insideDashes += 2;
        outsideDashes++;
        for (int i = 0; i < diameter / 2; i++)
        {
            asterisk -= 2;
            insideDashes += 2;
            outsideDashes++;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outsideDashes), new string('*', asterisk), new string('-', insideDashes));

        }
    }
}
