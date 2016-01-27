//Problem 15.	 Age after 10 Years
//Write a program to read your birthday from the console and print how old you are
//now and how old you will be after 10 years.

using System;
using System.Globalization;
using System.Threading;

class AgeAfterYears
{
    static void Main()
    {
        Console.Write("Enter your birthday year: ");
        // int BirthYear = int.Parse(Console.ReadLine());
        // int Age = DateTime.Now.Year - BirthYear;
        // Console.WriteLine("Your age is: {0}", Age);
        // int AgeAfterTenYears = Age + 10;
        // Console.WriteLine("Your age after 10 years would be: {0}", AgeAfterTenYears);
        // Console.WriteLine();
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

        string Input = Console.ReadLine();
       
        DateTime date = DateTime.Parse(Input);
        int Age = DateTime.Now.Year - date.Year;
        Console.WriteLine("Your age is: {0}", Age);
        int AgeAfterTenYears = Age + 10;
        Console.WriteLine("Your age after 10 years would be: {0}", AgeAfterTenYears);
        Console.WriteLine();
    }
}

