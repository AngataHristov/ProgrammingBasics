using System;

class HalfByteSwapper
{
    static void Main()
    {
        int[] numbers = new int[4];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        while (true)
        {
            string[] from = Console.ReadLine().Split(' ');

            if (from[0] == "end")
            {
                break;
            }

            string[] to = Console.ReadLine().Split(' ');

            int firstNumber = int.Parse(from[0]);
            int secondNumber = int.Parse(to[0]);
            int firstGroup = int.Parse(from[1]);
            int secondGroup = int.Parse(to[1]);

            int fromMask = 15 << firstGroup;
            int toMask = 15 << secondGroup;
            int fromByte = (numbers[firstNumber] & fromMask) >> firstGroup;
            int toByte = (numbers[secondNumber] & toMask) >> secondGroup;


            numbers[firstNumber] &= ~fromMask;
            numbers[secondNumber] &= ~toMask;


            numbers[firstNumber] |= toByte << firstGroup;
            numbers[secondNumber] |= fromByte << secondGroup;
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
