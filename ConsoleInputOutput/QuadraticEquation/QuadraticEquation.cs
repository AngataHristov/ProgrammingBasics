// Problem 6.	* Quadratic Equation
// Write a program that reads the coefficients a, b and c of a quadratic
// equation ax2 + bx + c = 0 and solves it(prints its real roots). Examples:

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("The quadratic equation is in type \"ax2 + bx + c = 0\"");

        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        double Discriminant = (double)Math.Pow(b, 2) - 4 * (a) * (c);
        double x = new double();
        double x1 = new double();
        double x2 = new double();

        if (a == 0)
        {
            x = (double)(-c) / b;
            Console.WriteLine("The equation is linear, x=-c/b={0:0.00} ", x);
        }
        if (Discriminant == 0)
        {
            Console.WriteLine("x1=x2={0:00}", (double)(b) / (2 * (a)));
        }
        else if (Discriminant < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else
        {
            x1 = (double)(-b - (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
            x2 = (double)(-b + (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
            Console.WriteLine("D={0:0.00}", Discriminant);
            Console.WriteLine("x1={0:0.00}, x2={1:0.00}", x1, x2);
        }
        Console.WriteLine();
    }
}
