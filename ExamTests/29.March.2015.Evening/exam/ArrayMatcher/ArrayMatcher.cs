using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class ArrayMatcher
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');

        string command = input[2];
        char[] leftCharachter = input[0].ToArray();
        char[] rightCharachter = input[1].ToArray();
        List<char> text = new List<char>();

        if (command == "join")
        {
            for (int i = 0; i < leftCharachter.Length; i++)
            {
                for (int j = 0; j < rightCharachter.Length; j++)
                {
                    if (leftCharachter[i] == rightCharachter[j])
                    {
                        text.Add(leftCharachter[i]);
                    }
                }
            }
        }
        if (command == "right exclude")
        {
            List<char> repeatSymbols = new List<char>();

            for (int i = 0; i < leftCharachter.Length; i++)
            {
                for (int j = 0; j < rightCharachter.Length; j++)
                {
                    if (leftCharachter[i] == rightCharachter[j])
                    {
                        repeatSymbols.Add(leftCharachter[i]);
                    }
                }
            }
            for (int i = 0; i < leftCharachter.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < repeatSymbols.Count; j++)
                {
                    if (leftCharachter[i]!=repeatSymbols[j])
                    {
                        counter++;
                    }
                }
                if (counter==repeatSymbols.Count)
                {
                    text.Add(leftCharachter[i]);
                }
            }
        }
        if (command == "left exclude")
        {
            List<char> repeatSymbols = new List<char>();

            for (int i = 0; i < rightCharachter.Length; i++)
            {
                for (int j = 0; j < leftCharachter.Length; j++)
                {
                    if (rightCharachter[i] == leftCharachter[j])
                    {
                        repeatSymbols.Add(rightCharachter[i]);
                    }
                }
            }
            for (int i = 0; i < rightCharachter.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < repeatSymbols.Count; j++)
                {
                    if (rightCharachter[i] != repeatSymbols[j])
                    {
                        counter++;
                    }
                }
                if (counter == repeatSymbols.Count)
                {
                    text.Add(rightCharachter[i]);
                }
            }
        }
        text.Sort();
        Console.WriteLine(string.Join("",text));
    }
}
