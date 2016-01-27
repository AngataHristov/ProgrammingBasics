using System;

class books
{
    static void Main()
    {
        int numberOfPagesInBook = int.Parse(Console.ReadLine());
        int numberOfCampDays = int.Parse(Console.ReadLine());
        int numberOfPagesPerDay = int.Parse(Console.ReadLine());

        int normalDays = 30 - numberOfCampDays;
        int numberOfPagesPerMonth = normalDays * numberOfPagesPerDay;
        double product = (double)numberOfPagesInBook / numberOfPagesPerMonth;
        int totalMonths = (int)Math.Ceiling(product);
        int years = totalMonths / 12;
        int months = totalMonths % 12;

        if (numberOfCampDays < 30)
        {
            Console.WriteLine("{0} years {1} months", years, months);
        }
        else
        {
            Console.WriteLine("never");
        }
    }
}
