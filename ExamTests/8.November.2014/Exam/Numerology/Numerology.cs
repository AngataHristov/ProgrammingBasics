using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

class Numerology
{
    static void Main()
    {
        Dictionary<char, int> Letters = new Dictionary<char, int>();
        Letters.Add('a', 1);
        Letters.Add('b', 2);
        Letters.Add('c', 3);
        Letters.Add('d', 4);
        Letters.Add('e', 5);
        Letters.Add('f', 6);
        Letters.Add('g', 7);
        Letters.Add('h', 8);
        Letters.Add('i', 9);
        Letters.Add('j', 10);
        Letters.Add('k', 11);
        Letters.Add('l', 12);
        Letters.Add('m', 13);
        Letters.Add('n', 14);
        Letters.Add('o', 15);
        Letters.Add('p', 16);
        Letters.Add('q', 17);
        Letters.Add('r', 18);
        Letters.Add('s', 19);
        Letters.Add('t', 20);
        Letters.Add('u', 21);
        Letters.Add('v', 22);
        Letters.Add('w', 23);
        Letters.Add('x', 24);
        Letters.Add('y', 25);
        Letters.Add('z', 26);
        Letters.Add('A', 1);
        Letters.Add('B', 2);
        Letters.Add('C', 3);
        Letters.Add('D', 4);
        Letters.Add('E', 5);
        Letters.Add('F', 6);
        Letters.Add('G', 7);
        Letters.Add('H', 8);
        Letters.Add('I', 9);
        Letters.Add('J', 10);
        Letters.Add('K', 11);
        Letters.Add('L', 12);
        Letters.Add('M', 13);
        Letters.Add('N', 14);
        Letters.Add('O', 15);
        Letters.Add('P', 16);
        Letters.Add('Q', 17);
        Letters.Add('R', 18);
        Letters.Add('S', 19);
        Letters.Add('T', 20);
        Letters.Add('U', 21);
        Letters.Add('V', 22);
        Letters.Add('W', 23);
        Letters.Add('X', 24);
        Letters.Add('Y', 25);
        Letters.Add('Z', 26);
        Letters.Add('0', 0);
        Letters.Add('1', 1);
        Letters.Add('2', 2);
        Letters.Add('3', 3);
        Letters.Add('4', 4);
        Letters.Add('5', 5);
        Letters.Add('6', 6);
        Letters.Add('7', 7);
        Letters.Add('8', 8);
        Letters.Add('9', 9);

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

        string[] input = Console.ReadLine().Split('.', ' ');

        int day = int.Parse(input[0]);
        int month = int.Parse(input[1]);
        int year = int.Parse(input[2]);
        string username = input[3];

        long result = day * month * year;

        if (month % 2 == 1)
        {
            result *= result;
        }

        for (int i = 0; i < username.Length; i++)
        {
            char currentSumbol = username[i];

            if (Letters.ContainsKey(currentSumbol))
            {
                if (char.IsLower(currentSumbol))
                {
                    result += Letters[currentSumbol];
                }
                if (char.IsUpper(currentSumbol))
                {
                    result += Letters[currentSumbol] * 2;
                }
                if (char.IsDigit(currentSumbol))
                {
                    result += Letters[currentSumbol];
                }
            }
        }
        while (result > 13)
        {
            int digitSum = 0;

            while (result > 0)
            {
                digitSum += (int)(result % 10);
                result /= 10;
            }

            result = digitSum;
        }
        Console.WriteLine(result);
    }
}
