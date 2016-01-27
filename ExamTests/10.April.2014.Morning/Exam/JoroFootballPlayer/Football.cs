using System;

class Football
{
    static void Main()
    {
        string yearType = Console.ReadLine();

        int numberOfHolidays = int.Parse(Console.ReadLine());

        int hometownWeekends = int.Parse(Console.ReadLine());

        double holidayPlays = 0.5 * numberOfHolidays;

        double hometownPlays = (double)hometownWeekends * 1;

        double normalPlays = (double)(52 - hometownWeekends) * 2 / 3;

        double result = holidayPlays + hometownPlays + normalPlays;

        if (yearType == "t")
        {
            result += 3;
        }

        Console.WriteLine("{0}",Math.Floor(result));
    }
}

