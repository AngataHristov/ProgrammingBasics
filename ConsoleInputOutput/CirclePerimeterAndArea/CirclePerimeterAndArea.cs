// Problem 3.	Circle Perimeter and Area
// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with
// 2 digits after the decimal point.Examples:

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        string radius = Console.ReadLine();
        double r;
        bool isNumber = double.TryParse(radius, out r);

        if (isNumber)
        {
            double perimeter = (double)2 * r * Math.PI;
            double area = (double)Math.PI * Math.Pow(r, 2);
            Console.WriteLine("The prerimeter is: {0:0.00}",perimeter);
            Console.WriteLine("The area is: {0:0.00}", area);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        Console.WriteLine();
    }
}
