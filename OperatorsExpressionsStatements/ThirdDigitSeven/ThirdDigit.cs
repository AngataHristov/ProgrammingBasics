// Problem 5.	Third Digit is 7?
// Write an expression that checks for given integer if its third digit from right-to-left is 7. 

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter integer number:");
        string input = Console.ReadLine();
        int number = new int();
        bool isNumber = int.TryParse(input, out number);
        if (isNumber)
        {
            int remainder = number / 100;
            int result = remainder % 10;
            if (result == 7)
            {
                Console.WriteLine("Third digit is 7? ----> true");
            }
            else
            {
                Console.WriteLine("Third digit is 7? ----> false");
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
