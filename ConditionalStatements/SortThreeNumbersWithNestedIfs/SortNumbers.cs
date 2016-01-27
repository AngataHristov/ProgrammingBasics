// Problem 7.	Sort 3 Numbers with Nested Ifs
// Write a program that enters 3 real numbers and prints them sorted in 
// descending order.Use nested if statements.Don’t use arrays and the built-in sorting functionality. 

using System;

class SortNumbers
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
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }
        Console.WriteLine();
    }
}
