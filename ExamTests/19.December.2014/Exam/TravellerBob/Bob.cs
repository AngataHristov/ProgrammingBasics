using System;

class Bob
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int c = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());

        int contractMonthsTravels = c * 4 * 3;
        int familyMonthsTravels = f * 2 * 2;
        int restMontrhs = 12 - f - c;
        double normalMonthsTravels = (double)restMontrhs * 12 * 3 / 5;

        if (yearType == "leap")
        {
            double sum = (contractMonthsTravels + familyMonthsTravels + normalMonthsTravels);
            double result = sum * 0.05 + sum;
            Console.WriteLine("{0}", Math.Floor(result));
        }
        else
        {
            double result = (contractMonthsTravels + familyMonthsTravels + normalMonthsTravels);
            Console.WriteLine("{0}", Math.Floor(result));

        }
    }
}
