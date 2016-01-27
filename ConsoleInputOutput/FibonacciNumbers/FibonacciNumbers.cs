// Problem 10.	 * Fibonacci Numbers
// Write a program that reads a number n and prints on the console the first n
// members of the Fibonacci sequence(at a single line, separated by spaces) :
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233,….
// Note that you may need to learn how to use loops.Examples:

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write(" Enter integer number: ");
        int n = int.Parse(Console.ReadLine());
        int firstMember = 0;
        int secondMember = 1;
        int thirdMember;
        if (n == 1)
        {
            Console.WriteLine("The first Fibonacci Numbers is: 0");
        }
        else if (n == 0)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            Console.Write("The first {0} Fibonacci Numbers are: {1} {2} ", n, firstMember, secondMember);

            for (int i = 3; i <= n; i++)
            {
                thirdMember = firstMember + secondMember;
                Console.Write("{0} ", thirdMember);
                firstMember = secondMember;
                secondMember = thirdMember;
            }
        }

        Console.WriteLine();
    }
}
