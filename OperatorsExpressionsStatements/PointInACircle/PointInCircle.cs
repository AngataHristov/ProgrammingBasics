// Problem 7.	Point in a Circle
// Write an expression that checks if given point(x, y) is inside a circle K({ 0, 0}, 2). 

using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter x cordinate: ");
        string inputOne = Console.ReadLine();

        Console.Write("Enter y cordinate: ");
        string inputTwo = Console.ReadLine();

        double x = new double();
        double y = new double();

        bool isNumberOne = double.TryParse(inputOne, out x);
        bool isNumberTwo = double.TryParse(inputTwo, out y);

        if (isNumberOne && isNumberTwo)
        {
            double result = (double)(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            if (result <= 2)
            {
                Console.WriteLine("The point is inside the circle!");
            }
            else
            {
                Console.WriteLine("The point is outside the circle!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Enter numbers!");
            Main();
        }
    }
}
