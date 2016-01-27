using System;

class BasketBattle
{
    static void Main()
    {
        string first = Console.ReadLine();
        int rounds = int.Parse(Console.ReadLine());
        bool simeonFirst = false;
        bool nakovFirst = false;
        int nakovPoints = new int();
        int simeonPoints = new int();
        string winner = string.Empty;
        int winningRound = new int();

        if (first == "Simeon")
        {
            simeonFirst = true;
        }
        else if (first == "Nakov")
        {
            nakovFirst = true;
        }

        for (int i = 1; i <= rounds; i++)
        {
            int firstPoints = int.Parse(Console.ReadLine());
            string firstSuccessInfo = Console.ReadLine();

            if (simeonFirst)
            {
                if (simeonPoints + firstPoints <= 500 && firstSuccessInfo == "success")
                {
                    simeonPoints += firstPoints;
                }
                if (simeonPoints == 500)
                {
                    winner = "Simeon";
                    winningRound = i;
                    break;
                }

                int secondPoints = int.Parse(Console.ReadLine());
                string secondSuccessInfo = Console.ReadLine();

                if (nakovPoints + secondPoints <= 500 && secondSuccessInfo == "success")
                {
                    nakovPoints += secondPoints;
                }
                if (nakovPoints == 500)
                {
                    winner = "Nakov";
                    winningRound = i;
                    break;
                }
            }

            if (nakovFirst)
            {
                if (nakovPoints + firstPoints <= 500 && firstSuccessInfo == "success")
                {
                    nakovPoints += firstPoints;
                }
                if (nakovPoints == 500)
                {
                    winner = "Nakov";
                    winningRound = i;
                    break;
                }

                int secondPoints = int.Parse(Console.ReadLine());
                string secondSuccessInfo = Console.ReadLine();

                if (simeonPoints + secondPoints <= 500 && secondSuccessInfo == "success")
                {
                    simeonPoints += secondPoints;
                }
                if (simeonPoints == 500)
                {
                    winner = "Simeon";
                    winningRound = i;
                    break;
                }
            }

            simeonFirst = !simeonFirst;
            nakovFirst = !nakovFirst;
        }
        if (winner == "Simeon")
        {
            Console.WriteLine(winner);
            Console.WriteLine(winningRound);
            Console.WriteLine(nakovPoints);
        }
        else if (winner == "Nakov")
        {
            Console.WriteLine(winner);
            Console.WriteLine(winningRound);
            Console.WriteLine(simeonPoints);
        }
        else if (winner == String.Empty && simeonPoints == nakovPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(simeonPoints);
        }
        else
        {
            if (simeonPoints > nakovPoints)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(simeonPoints - nakovPoints);
            }
            else
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(nakovPoints - simeonPoints);
            }
        }
    }
}

