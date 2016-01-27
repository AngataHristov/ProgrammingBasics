using System;
using System.Linq;

class JumpingSums
{
    static void Main()
    {
        int[] intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int jumps = int.Parse(Console.ReadLine());

        int maxSum = int.MinValue;

        for (int i = 0; i < intArr.Length; i++)
        {
            int value = intArr[i];
            int currentIndex = i;
            int nextIndex = (currentIndex + value) % intArr.Length;
            int sum = 0;

            for (int j = 0; j <= jumps; j++)
            {
                sum += value;
                value = intArr[nextIndex];
                currentIndex = nextIndex;
                nextIndex = (currentIndex + value) % intArr.Length;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine("max sum = {0}", maxSum);
    }
}

