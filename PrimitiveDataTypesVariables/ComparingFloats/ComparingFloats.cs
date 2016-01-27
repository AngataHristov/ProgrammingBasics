// Problem 13.	* Comparing Floats
// Write a program that safely compares floating-point numbers(double) with precision eps = 0.000001.
// Note that we cannot directly compare two floating-point numbers a and b by a==b because of the
// nature of the floating-point arithmetic.Therefore, we assume two numbers are equal if they
// are more closely to each other than a fixed constant eps. Examples:

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool isEqual = true;
        double difference = Math.Abs(firstNumber - secondNumber);

        if (difference < eps)
        {
            Console.WriteLine("Equal (with precision eps=0.000001): {0}.The difference {1} < {2}.", isEqual, difference, eps);
        }
        else if (difference == eps)
        {
            isEqual = false;
            Console.WriteLine("Equal (with precision eps=0.000001): {0}.The difference {1} = {2}.", isEqual, difference, eps);
        }
        else
        {
            isEqual = false;
            Console.WriteLine("Equal (with precision eps=0.000001): {0}.The difference {1} > {2}.", isEqual, difference, eps);
        }
        Console.WriteLine();
    }
}
