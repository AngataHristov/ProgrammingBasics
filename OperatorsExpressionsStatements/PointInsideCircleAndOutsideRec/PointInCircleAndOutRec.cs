// Problem 10.	Point Inside a Circle & Outside of a Rectangle
// Write an expression that checks for given point(x, y) if it is
// within the circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2). 

using System;

class PointInCircleAndOutRec
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
            bool IsInCircle = (Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2))) <= 1.5;
            bool IsOutsideRec = y > 1;
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Inside K & outside of R ---> No!");
            }
            else if (IsInCircle && IsOutsideRec)
            {
                Console.WriteLine("Inside K & outside of R ---> Yes!");
            }
            else
            {
                Console.WriteLine("Inside K & outside of R ---> No!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Enter numbers!");
            Main();
        }
    }
}
