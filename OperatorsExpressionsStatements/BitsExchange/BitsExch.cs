// Problem 15.	* Bits Exchange
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExch
{
    static void Main()
    {
        Console.Write("Please input your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Convert.ToString(num, 2));
        int mask = 0;
        int bit = 0;
        int p = 0;
        int numP = 0;

        //take bit 3,4,5 and put them in the place of 24,25,26
        for (int i = 0; i < 3; i++)
        {
            p = 3 + i;
            numP = num >> p;
            bit = numP & 1;
            if (bit == 1)
            {
                mask = 1 << 24 + i;
                num = num | mask;
            }
            else
            {
                mask = ~(1 << 24 + i);
                num = num & mask;
            }
        }

        //take bit 24,25,26 and put them in the place of 3,4,5
        for (int i = 0; i < 3; i++)
        {
            p = 24 + i;
            numP = num >> p;
            bit = numP & 1;
            if (bit == 1)
            {
                mask = 1 << 3 + i;
                num = num | mask;
            }
            else
            {
                mask = ~(1 << 3 + i);
                num = num & mask;
            }
        }
        Console.WriteLine("Your new number is: {0}", num);
        Console.WriteLine(Convert.ToString(num, 2));
    }
}
