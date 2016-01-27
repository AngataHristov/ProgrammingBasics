using System;

class DoubleDowns
{
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());

        int[] numbers = new int[numberOfInputs];

        int rightDiagonalCouples = new int();
        int leftDiagonalCouples = new int();
        int verticalCouples = new int();



        for (int i = 0; i < numberOfInputs; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }

        for (int num = 0; num < numbers.Length - 1; num++)
        {
            int currentNum = numbers[num];
            int nextNum = numbers[num + 1];

            for (int bits = 0; bits < 32; bits++)
            {
                int firstBit = currentNum >> bits & 1;
                int secondBit = nextNum >> bits & 1;

                if (firstBit == 1 && secondBit == 1)
                {
                    verticalCouples++;
                }
                if (bits > 0 && (currentNum >> bits & 1) == 1 && (nextNum >> (bits - 1) & 1) == 1)
                {
                    rightDiagonalCouples++;
                }
                if (bits < 31 && (currentNum >> bits & 1) == 1 && (nextNum >> (bits + 1) & 1) == 1)
                {
                    leftDiagonalCouples++;

                }
            }
        }
        Console.WriteLine(rightDiagonalCouples);
        Console.WriteLine(leftDiagonalCouples);
        Console.WriteLine(verticalCouples);
    }
}
