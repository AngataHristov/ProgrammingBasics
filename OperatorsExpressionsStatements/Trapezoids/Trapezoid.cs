// Problem 9.	Trapezoids
// Write an expression that calculates trapezoid's area by given sides a and b and height h. 

using System;

class Trapezoid
{
    static void Main()
    {
        Console.Write("Enter side a: ");
        string inputOne = Console.ReadLine();

        Console.Write("Enter side b: ");
        string inputTwo = Console.ReadLine();

        Console.Write("Enter trapezoid's height: ");
        string inputThree = Console.ReadLine();

        double a = new double();
        double b = new double();
        double height = new double();

        bool isNumberOne = double.TryParse(inputOne, out a);
        bool isNumberTwo = double.TryParse(inputTwo, out b);
        bool isNumberThree = double.TryParse(inputThree, out height);

        if (isNumberOne && isNumberTwo && isNumberThree)
        {
            if (a > 0 && b > 0 && height > 0)
            {
                double area = (double)((a + b) / 2) * height;
                Console.WriteLine("Area={0:F3}", area);
            }
            else
            {
                Console.WriteLine("Enter positive numbers, bigger than zero!");
                Main();
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Enter numbers!");
            Main();
        }
    }
}

