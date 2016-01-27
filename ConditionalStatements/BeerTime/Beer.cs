// Problem 10.	* Beer Time
// A beer time is after 1:00 PM and before 3:00 AM.Write a program that enters a time in format “hh:mm tt”
// (an hour in range[01...12], a minute in range[00…59] and AM / PM designator) and prints “beer time” or
// “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed.
// Note that you may need to learn how to parse dates and times.

using System;
using System.Threading;
using System.Globalization;
class Beer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a time in format hh:mm tt: ");
        string input = Console.ReadLine();
        DateTime dateTime = new DateTime();
        bool isTime = DateTime.TryParse(input, out dateTime);

        if (isTime)
        {
            if ((dateTime.Hour >= 1 && dateTime.Hour <= 12) && (dateTime.Minute >= 1 && dateTime.Minute <= 59)
                && (dateTime.Second >= 1 && dateTime.Second <= 59))
            {
                if (dateTime.Hour >= 3 && dateTime.Hour <= 13)
                {
                    Console.WriteLine("Beer time!");
                }
                else
                {
                    Console.WriteLine("Non-beer time");
                }
            }
            else
            {
                Console.WriteLine("Invalid time");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
