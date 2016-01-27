// Problem 3.	Divide by 7 and 5
// Write a Boolean expression that checks for given integer if
// it can be divided(without remainder) by 7 and 5 in the same time.

using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter integer number:");
        string input = Console.ReadLine();
        int number = new int();
        bool isNumber = int.TryParse(input, out number);
        if (isNumber)
        {
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("Divided by 7 and 5? ---> true");
            }
            else
            {
                Console.WriteLine("Divided by 7 and 5? ---> false");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Enter a number!");
            Main();
        }
        Console.WriteLine();
    }
}
