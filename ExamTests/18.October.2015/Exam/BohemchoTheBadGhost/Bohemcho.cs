using System;
using System.Linq;
using System.Text;

class Bohemcho
{
    public static int CalcLights(long number)
    {
        int counter = 0;
        string num = Convert.ToString(number, 2);

        foreach (char symbol in num)
        {
            if (symbol == '1')
            {
                counter++;
            }
        }
        return counter;
    }

    public static void Main()
    {
        string input = Console.ReadLine();

        long finalScore = 0;

        int lightsOnCount = 0;

        while (input != "Stop, God damn it")
        {
            uint currentFloor = uint.Parse(input);

            int[] apartaments = Console.ReadLine().Split(new char[] { ' ', ',', '!', '@' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < apartaments.Length; i++)
            {
                currentFloor = currentFloor ^ ((uint)1 << apartaments[i]);
            }     

            finalScore += currentFloor;

            lightsOnCount += CalcLights(currentFloor);

            input = Console.ReadLine();
        }

        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", lightsOnCount, finalScore);
    }
}

