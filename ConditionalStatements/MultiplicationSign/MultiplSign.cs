// Problem 4.	Multiplication Sign
// Write a program that shows the sign(+, - or 0) of the product of three real numbers,
// without calculating it.Use a sequence of if operators.

using System;

class MultiplSign
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if ((firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) || (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) || (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) || (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0))
        {
            Console.WriteLine("Positive!");
        }
        else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("Zero");
        }
        else
        {
            Console.WriteLine("Negative!");
        }
    }
}
