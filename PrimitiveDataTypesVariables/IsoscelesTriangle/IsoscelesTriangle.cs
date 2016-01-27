// Problem 8.	Isosceles Triangle
// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//    ©
//   © ©
//  © © ©
// © © © ©

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char symbol ='\u00A9';
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("   {0}",symbol);
        Console.WriteLine("  {0} {1}", symbol,symbol);
        Console.WriteLine(" {0} {1} {2}", symbol,symbol,symbol);
        Console.WriteLine("{0} {1} {2} {3}", symbol,symbol,symbol,symbol);
    }
}
