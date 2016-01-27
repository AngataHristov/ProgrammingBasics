// Problem 6.	Four-Digit Number
// Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following:
// •	Calculates the sum of the digits(in our example 2+0+1+1 = 4).
// •	Prints on the console the number in reversed order: dcba(in our example 1102).
// •	Puts the last digit in the first position: dabc(in our example 1201).
// •	Exchanges the second and the third digits: acbd(in our example 2101).

using System;

class FourDigitNum
{
    static void Main()
    {
        Console.Write("Enter a four-digit number in format abcd(e.g. 2011): ");
        string input = Console.ReadLine();
        int number = new int();
        bool isNumber = int.TryParse(input, out number);
        if (isNumber)
        {
            int firstDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = (number / 100) % 10;
            int fourthDigit = (number / 1000) % 10;
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("Sum of digits={0}", sum);
            Console.WriteLine("Reversed number: {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("Last digit in front:{0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
            Console.WriteLine("Second and third digits exchanged:{0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
        else
        {
            Console.WriteLine("Invalid input! Enter a number!");
            Main();
        }
        Console.WriteLine();
    }
}
