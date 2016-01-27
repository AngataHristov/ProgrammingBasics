// Problem 4.	Rectangles
// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Recs
{
    static void Main()
    {
        Console.Write("Enter rectangle’s width:");
        string inputOne = Console.ReadLine();

        Console.Write("Enter rectangle’s height:");
        string inputTwo = Console.ReadLine();

        double width = new double();
        double height = new double();

        bool isNumberOne = double.TryParse(inputOne, out width);
        bool isNumberTwo = double.TryParse(inputTwo, out height);

        if (isNumberOne && isNumberTwo)
        {
            if (width > 0 && height > 0)
            {
                double perimeter = (double)2 * (width + height);
                double area = (double)width * height;
                Console.WriteLine("Perimeter={0:F2}", perimeter);
                Console.WriteLine("Area={0:F2}", area);
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
