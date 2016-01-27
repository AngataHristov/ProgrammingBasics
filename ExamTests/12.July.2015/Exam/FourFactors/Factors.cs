using System;

class Factors
{
    static void Main()
    {
        //Console.WriteLine("Enter Field Goals: ");
        long FG = long.Parse(Console.ReadLine());
        //Console.WriteLine("Enter Field Goal Attempts: ");
        long FGA = long.Parse(Console.ReadLine());
        //Console.WriteLine("3-Point Field Goals: ");
        long ThreeP = long.Parse(Console.ReadLine());
        //Console.WriteLine("Turnovers: ");
        long TOV = long.Parse(Console.ReadLine());
        //Console.WriteLine("Offensive Rebounds: ");
        long ORB = long.Parse(Console.ReadLine());
        //Console.WriteLine("Opponent Defensive Rebounds: ");
        long oppDRB = long.Parse(Console.ReadLine());
        //Console.WriteLine("Free Throws: ");
        long FT = long.Parse(Console.ReadLine());
        //Console.WriteLine("Free Throw Attempts: ");
        long FTA = long.Parse(Console.ReadLine());

        double eFGP = (double)(FG + 0.5 * ThreeP) / FGA;
        double TOVP = (double)(TOV) / (FGA + 0.44 * FTA + TOV);
        double ORVP = (double)(ORB) / (ORB + oppDRB);
        double FTP = (double)FT / FGA;

        Console.WriteLine("eFG% {0:F3}", eFGP);
        Console.WriteLine("TOV% {0:F3}", TOVP);
        Console.WriteLine("ORB% {0:F3}", ORVP);
        Console.WriteLine("FT% {0:F3}", FTP);
    }
}
