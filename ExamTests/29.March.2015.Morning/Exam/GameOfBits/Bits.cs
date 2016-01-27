using System;
using System.Collections.Generic;
using System.Text;

class Bits
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        string numberToBin = Convert.ToString(number, 2);

        List<string> text = new List<string>();

        string command = Console.ReadLine();

        while (command != "Game Over!")
        {
            StringBuilder fixedNum = new StringBuilder();

            List<char> extractedNumber = new List<char>();

            if (command == "Odd")
            {
                for (int i = numberToBin.Length - 1; i >= 0; i -= 2)
                {
                    extractedNumber.Add(numberToBin[i]);
                }
                extractedNumber.Reverse();
            }

            if (command == "Even")
            {
                for (int i = numberToBin.Length - 2; i >= 0; i -= 2)
                {
                    extractedNumber.Add(numberToBin[i]);
                }
                extractedNumber.Reverse();
            }

            foreach (char element in extractedNumber)
            {
                fixedNum.Append(element);
            }
            numberToBin = fixedNum.ToString();

            text.Add(fixedNum.ToString());

            command = Console.ReadLine();
        }

        int counter = new int();

        string lastNum = text[text.Count - 1];

        foreach (char symbol in lastNum)
        {
            if (symbol == '1')
            {
                counter++;
            }
        }

        long dec = new long();

        for (int i = 0; i < lastNum.Length; i++)
        {
            if (lastNum[lastNum.Length - i - 1] == '0')
            {
                continue;
            }

            dec += (long)Math.Pow(2, i);
        }

        Console.WriteLine("{0} -> {1}", dec, counter);
    }
}
