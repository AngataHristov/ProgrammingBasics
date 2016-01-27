// Problem 6.	The Biggest of Five Numbers
// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            Console.WriteLine(secondNumber);

        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine(thirdNumber);

        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            Console.WriteLine(fourthNumber);

        }
        else
        {
            Console.WriteLine(fifthNumber);
        }
        Console.WriteLine();
    }
}
