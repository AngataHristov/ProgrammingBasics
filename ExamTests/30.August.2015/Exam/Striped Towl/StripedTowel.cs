using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StripedTowel
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int width = size;
        int height = size + size / 2;

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((row + col) % 3 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
