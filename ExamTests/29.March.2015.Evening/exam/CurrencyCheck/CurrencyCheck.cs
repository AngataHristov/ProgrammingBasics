using System;

class CurrencyCheck
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());

        double rublesInLv = (double)r * 0.035;
        double dollarsInLV = (double)d * 1.5;
        double eurosInLv = (double)e * 1.95;
        double bInLv = (double)b / 2;
        double mInLv = (double)m;

        double lowestPrice = double.MaxValue;
        lowestPrice = Math.Min(rublesInLv, lowestPrice);
        lowestPrice = Math.Min(dollarsInLV, lowestPrice);
        lowestPrice = Math.Min(rublesInLv, lowestPrice);
        lowestPrice = Math.Min(bInLv, lowestPrice);
        lowestPrice = Math.Min(mInLv, lowestPrice);

        Console.WriteLine("{0:F2}", lowestPrice);
    }
}
