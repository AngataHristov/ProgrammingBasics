using System;

class MagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int resultsCount = 0;

        for (int num1 = 111; num1 <= 777; num1++)
        {
            int num2 = num1 + diff;
            int num3 = num2 + diff;

            if (IsValidNumber(num1) && IsValidNumber(num2) && IsValidNumber(num3) && (num3 < 777) && SumOfDigits(num1) + SumOfDigits(num2) + SumOfDigits(num3) == sum)
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                resultsCount++;
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static bool IsValidNumber(int num)
    {
        string digits = num.ToString();

        foreach (char symbol in digits)
        {
            if (symbol < '1' || symbol > '7')
            {
                return false;
            }
        }
        return true;
    }

    private static int SumOfDigits(int num)
    {
        int sum = new int();

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
