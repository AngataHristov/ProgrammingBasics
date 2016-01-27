using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FootballStatistician
{
    public static int AddingPointsToTeam(
        string team,
        int arsenalPoints,
        int pointsToAdd,
        ref int chelseaPoints,
        ref int manchesterCityPoints,
        ref int manchesterUnitedPoints,
        ref int liverpoolPoints,
        ref int evertonPoints,
        ref int southamptonPoints,
        ref int tottenhamPoints)
    {
        switch (team)
        {
            case "Arsenal":
                arsenalPoints += pointsToAdd;
                break;
            case "Chelsea":
                chelseaPoints += pointsToAdd;
                break;
            case "ManchesterCity":
                manchesterCityPoints += pointsToAdd;
                break;
            case "ManchesterUnited":
                manchesterUnitedPoints += pointsToAdd;
                break;
            case "Liverpool":
                liverpoolPoints += pointsToAdd;
                break;
            case "Everton":
                evertonPoints += pointsToAdd;
                break;
            case "Southampton":
                southamptonPoints += pointsToAdd;
                break;
            case "Tottenham":
                tottenhamPoints += pointsToAdd;
                break;
        }
        return arsenalPoints;
    }

    public static void Main()
    {
        const int PointsPerWin = 3;
        const int PointsPerDraw = 1;

        //Console.WriteLine("Enter payment for the macht: ");
        decimal paymentPerMatch = decimal.Parse(Console.ReadLine());

        int arsenalPoints = 0;
        int chelseaPoints = 0;
        int manchesterCityPoints = 0;
        int manchesterUnitedPoints = 0;
        int liverpoolPoints = 0;
        int evertonPoints = 0;
        int southamptonPoints = 0;
        int tottenhamPoints = 0;

        int matchesCounter = 0;
        string input = string.Empty;

        while (true)
        {
            input = Console.ReadLine();

            if (input == "End of the league.")
            {
                break;
            }
            string[] arguments = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstTeam = arguments[0];
            string secondTeam = arguments[2];
            string machtResult = arguments[1];

            if (machtResult == "1")
            {
                arsenalPoints = AddingPointsToTeam(
                    firstTeam,
                    arsenalPoints,
                    PointsPerWin,
                    ref chelseaPoints,
                    ref manchesterCityPoints,
                    ref manchesterUnitedPoints,
                    ref liverpoolPoints,
                    ref evertonPoints,
                    ref southamptonPoints,
                    ref tottenhamPoints);
            }
            else if (machtResult == "2")
            {
                arsenalPoints = AddingPointsToTeam(
                  secondTeam,
                  arsenalPoints,
                  PointsPerWin,
                  ref chelseaPoints,
                  ref manchesterCityPoints,
                  ref manchesterUnitedPoints,
                  ref liverpoolPoints,
                  ref evertonPoints,
                  ref southamptonPoints,
                  ref tottenhamPoints);
            }
            else
            {
                arsenalPoints = AddingPointsToTeam(
                    firstTeam,
                    arsenalPoints,
                    PointsPerDraw,
                    ref chelseaPoints,
                    ref manchesterCityPoints,
                    ref manchesterUnitedPoints,
                    ref liverpoolPoints,
                    ref evertonPoints,
                    ref southamptonPoints,
                    ref tottenhamPoints);

                arsenalPoints = AddingPointsToTeam(
                    secondTeam,
                    arsenalPoints,
                    PointsPerDraw,
                    ref chelseaPoints,
                    ref manchesterCityPoints,
                    ref manchesterUnitedPoints,
                    ref liverpoolPoints,
                    ref evertonPoints,
                    ref southamptonPoints,
                    ref tottenhamPoints);
            }
            matchesCounter++;
        }
        decimal priceForAllMatchesInLeva = (matchesCounter * paymentPerMatch) * 1.94m;

        Console.WriteLine("{0:f2}lv.", priceForAllMatchesInLeva);
        Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
        Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
        Console.WriteLine("Everton - {0} points.", evertonPoints);
        Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
        Console.WriteLine("Manchester City - {0} points.", manchesterCityPoints);
        Console.WriteLine("Manchester United - {0} points.", manchesterUnitedPoints);
        Console.WriteLine("Southampton - {0} points.", southamptonPoints);
        Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);
    }
}
