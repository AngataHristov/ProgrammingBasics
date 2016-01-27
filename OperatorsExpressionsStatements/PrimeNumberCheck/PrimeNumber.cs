// Problem 8.	Prime Number Check
// Write an expression that checks if given positive integer number n(n ≤ 100)
// is prime(i.e.it is divisible without remainder only to itself and 1). 

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        string input = Console.ReadLine();
        int number = new int();
        bool isNumber = int.TryParse(input, out number);
        if (isNumber && number > 0 && number <= 100)
        {
            int divider = 2;
            bool IsPrime = true;
            while (divider <= Math.Sqrt(number))
            {
                double remainder = number % divider;
                if (remainder == 0)
                {
                    IsPrime = false;
                    break;
                }
                else
                {
                    divider++;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("The number {0} is prime.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not prime.", number);
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Enter a positive number n<=100!");
            Main();
        }
        Console.WriteLine();
    }
}
