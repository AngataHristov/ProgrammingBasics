using System;
using System.Text;

class WeirdCombinations
{
    static void Main()
    {
        string input = Console.ReadLine();
        int positionOfElement = int.Parse(Console.ReadLine());

        char[] leters = input.ToCharArray();

        StringBuilder result = new StringBuilder(input.Length);
        int counter = new int();
        bool hasResult = false;

        foreach (char c1 in leters)
        {
            foreach (char c2 in leters)
            {
                foreach (char c3 in leters)
                {
                    foreach (char c4 in leters)
                    {
                        foreach (char c5 in leters)
                        {
                            if (counter == positionOfElement)
                            {
                                result.Append(c1);
                                result.Append(c2);
                                result.Append(c3);
                                result.Append(c4);
                                result.Append(c5);

                                Console.WriteLine(result.ToString());
                                hasResult = true;
                            }
                            counter++;
                        }
                    }
                }
            }
        }
        if (!hasResult)
        {
            Console.WriteLine("No");
        }
    }
}
