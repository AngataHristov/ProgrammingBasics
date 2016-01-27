using System;

class CompoundInterest
{
    static void Main()
    {
        double p = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());

        double BL = (double)p * Math.Pow(1 + i, n);
        double FL = (double)p * Math.Pow(1 + f, 1);

        if (FL <= BL)
        {
            Console.WriteLine("{0:F2} Friend", FL);
        }
        else
        {
            Console.WriteLine("{0:F2} Bank", BL);
        }
    }
}
