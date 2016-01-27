// Problem 1.	Difference between Dates
// Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them

using System;
using System.Threading;
using System.Globalization;

class Dates
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();
        string format = "d.MM.yyyy";

        DateTime firstDate = DateTime.ParseExact(firstInput, format, CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondInput, format, CultureInfo.InvariantCulture);

        TimeSpan ts = secondDate - firstDate;
        
        int difference = ts.Days;

        Console.WriteLine("Days between: {0} ", difference);
    }
}
