// Problem 4.	Number Comparer
// Write a program that gets two numbers from the console and prints
// the greater of them.Try to implement this without if statements.Examples

using System;
using System.Threading;
using System.Globalization;
class NumComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

        Console.Write("Enter the first number: ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter the second number: ");
        string secondNumber = Console.ReadLine();

        double a = new double();
        double b = new double();
        bool isFirstNumber = double.TryParse(firstNumber, out a);
        bool isSecondNumber = double.TryParse(secondNumber, out b);

        if (isFirstNumber && isSecondNumber)
        {
            Console.WriteLine(Math.Max(a, b));
        }
        else
        {
            Console.WriteLine("Invalid input! Enter a number!");
        }
        Console.WriteLine();
    }
}
