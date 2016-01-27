using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class CalorieIntake
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentUICulture;

        //Console.WriteLine("Enter weight in pounds (lbs.):");
        double W = double.Parse(Console.ReadLine());

        //Console.WriteLine("Enter height in inches:");
        double H = double.Parse(Console.ReadLine());

        // Console.WriteLine("Enter age:");
        double A = double.Parse(Console.ReadLine());

        //Console.WriteLine("Enter gender:");
        char G = char.Parse(Console.ReadLine());

        //Console.WriteLine("Enter workouts per week:");
        double E = double.Parse(Console.ReadLine());

        double weightInKg = (double)W / 2.2;
        double heightInCm = (double)H * 2.54;

        double BMR = new double();
        double DCI = new double();

        if (G == 'm')
        {
            BMR = 66.5 + (13.75 * weightInKg) + (5.003 * heightInCm) - (6.755 * A);
        }
        if (G == 'f')
        {
            BMR = 655 + (9.563 * weightInKg) + (1.850 * heightInCm) - (4.676 * A);
        }
        if (E == 0)
        {
            DCI = BMR * 1.2;
        }
        else if (E >= 1 && E <= 3)
        {
            DCI = BMR * 1.375;
        }
        else if (E >= 4 && E <= 6)
        {
            DCI = BMR * 1.55;
        }
        else if (E >= 7 && E <= 9)
        {
            DCI = BMR * 1.725;
        }
        else if (E > 9)
        {
            DCI = BMR * 1.9;
        }
        else
        {
            DCI = BMR * 1.2;
        }
        Console.WriteLine("{0:0}", Math.Floor(DCI));
    }
}

