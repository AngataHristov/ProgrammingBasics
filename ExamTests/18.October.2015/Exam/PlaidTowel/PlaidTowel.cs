using System;

class PlaidTowel
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char backgroundSymbol = char.Parse(Console.ReadLine());
        char rhombusSymbol = char.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, size), new string(rhombusSymbol, 1), new string(backgroundSymbol, 2 * size - 1));


        for (int j = 0; j < 2; j++)
        {
            int firstBackground = size - 1;
            int secondBackground = 1;
            int middleBackground = 2 * size - 3;

            for (int i = 0; i < size - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}", new string(backgroundSymbol, firstBackground), new string(rhombusSymbol, 1), new string(backgroundSymbol, secondBackground), new string(rhombusSymbol, 1), new string(backgroundSymbol, middleBackground));
                firstBackground--;
                secondBackground += 2;
                middleBackground -= 2;
            }

            Console.WriteLine("{0}{1}{0}{1}{0}", new string(rhombusSymbol, 1), new string(backgroundSymbol, 2 * size - 1));

            for (int i = 0; i < size - 1; i++)
            {
                firstBackground++;
                secondBackground -= 2;
                middleBackground += 2;
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}", new string(backgroundSymbol, firstBackground), new string(rhombusSymbol, 1), new string(backgroundSymbol, secondBackground), new string(rhombusSymbol, 1), new string(backgroundSymbol, middleBackground));
            }

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, size), new string(rhombusSymbol, 1), new string(backgroundSymbol, 2 * size - 1));

        }

    }
}
