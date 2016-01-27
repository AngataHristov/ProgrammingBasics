// Problem 14.	Modify a Bit at Given Position
// We are given an integer number n, a bit value v(v= 0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to
// hold the value v at the position p from the binary representation of n while preserving all other bits in n. 

using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter integer number n: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter value v (0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        Console.Write("Enter position p: ");
        int p = int.Parse(Console.ReadLine());

        string Bitwise = Convert.ToString(number, 2);
        Console.WriteLine(Bitwise);

        if (v == 1)
        {
            int mask = 1 << p;
            int result = mask | number;
            int bit = result >> p;
            Console.WriteLine(bit);
            Console.WriteLine(result);
        }
        else
        {
            int mask = ~(1 << p);
            int result = mask & number;
            int bit = result >> p;
            Console.WriteLine(bit);
            Console.WriteLine(result);
        }
        Console.WriteLine();
    }
}
