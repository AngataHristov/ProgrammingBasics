using System;

class Counter
{
    static void Main()
    {
        int countOfSets = int.Parse(Console.ReadLine());
        int countOfNumbersInEachSet = int.Parse(Console.ReadLine());
        string info = Console.ReadLine();

        int oddNumsCount = new int();
        int evenNumsCount = new int();
        int set = new int();

        for (int i = 0; i < countOfSets; i++)
        {
            int currentOddCount = new int();
            int currentEvenCount = new int();

            for (int j = 0; j < countOfNumbersInEachSet; j++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (info == "even" && currentNumber % 2 == 0)
                {
                    currentEvenCount++;
                }

                if (info == "odd" && currentNumber % 2 != 0)
                {
                    currentOddCount++;
                }
            }

            if (oddNumsCount < currentOddCount)
            {
                oddNumsCount = currentOddCount;
                set = i + 1;
            }

            if (evenNumsCount < currentEvenCount)
            {
                evenNumsCount = currentEvenCount;
                set = i + 1;
            }
        }

        string numberAsString = string.Empty;

        switch (set)
        {
            case 1:
                numberAsString = "First";
                break;
            case 2:
                numberAsString = "Second";
                break;
            case 3:
                numberAsString = "Third";
                break;
            case 4:
                numberAsString = "Fourth";
                break;
            case 5:
                numberAsString = "Fifth";
                break;
            case 6:
                numberAsString = "Sixth";
                break;
            case 7:
                numberAsString = "Seventh";
                break;
            case 8:
                numberAsString = "Eighth";
                break;
            case 9:
                numberAsString = "Ninth";
                break;
            case 10:
                numberAsString = "Tenth";
                break;
            default:
                break;
        }

        if (info == "even")
        {
            if (evenNumsCount != 0)
            {
                Console.WriteLine("{0} set has the most {1} numbers: {2}", numberAsString, info, evenNumsCount);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else if (info == "odd")
        {
            if (oddNumsCount != 0)
            {
                Console.WriteLine("{0} set has the most {1} numbers: {2}", numberAsString, info, oddNumsCount);
            }
            else
            {
                Console.WriteLine("No");

            }
        }
    }
}
