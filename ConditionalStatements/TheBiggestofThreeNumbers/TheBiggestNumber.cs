// Problem 5.	The Biggest of 3 Numbers
// Write a program that finds the biggest of three numbers.

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

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("The biggest number is: {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", thirdNumber);
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The biggest number is: {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", thirdNumber);
            }
        }
        Console.WriteLine();
    }
}
