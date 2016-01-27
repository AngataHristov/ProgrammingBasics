// Problem 1.	Exchange If Greater
// Write an if-statement that takes two integer variables a and b and exchanges their 
// values if the first one is greater than the second one.As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double c = a;
            a = b;
            b = c;
            Console.WriteLine("a= {0}, b= {1}", a, b);
        }
        else
        {
            Console.WriteLine("a= {0}, b= {1}", a, b);
        }
        Console.WriteLine();
    }
}
