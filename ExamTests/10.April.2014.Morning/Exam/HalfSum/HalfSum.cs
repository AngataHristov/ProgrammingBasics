using System;
using System.Linq;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] firstSequence = new int[n];
        int[] secondSequence = new int[n];

        int firstSum = new int();
        int secondSum = new int();

        for (int i = 0; i < n; i++)
        {
            firstSequence[i] = int.Parse(Console.ReadLine());

            firstSum += firstSequence[i];
        }

        for (int i = 0; i < n; i++)
        {
            secondSequence[i] = int.Parse(Console.ReadLine());

            secondSum += secondSequence[i];
        }

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstSum - secondSum));
        }
    }
}
