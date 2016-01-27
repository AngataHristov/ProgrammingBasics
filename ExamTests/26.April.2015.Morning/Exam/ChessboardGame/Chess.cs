using System;
using System.Collections.Generic;

class Chess
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int rows = size;
        int cols = size;
        char[,] chessboard = new char[rows, cols];
        int index = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (index < input.Length)
                {
                    chessboard[row, col] = input[index];
                    index++;
                }
                if (index == input.Length)
                {
                    chessboard[row, col] = input[input.Length - 1];
                }
                if (index > input.Length)
                {
                    chessboard[row, col] = '0';
                }
            }
        }
        int blackTeamScore = new int();
        int whiteTeamScore = new int();
        List<char> blackTeam = new List<char>();
        List<char> whiteTeam = new List<char>();

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if ((col + row) % 2 == 0)
                {
                    if (char.IsUpper(chessboard[row, col]))
                    {
                        whiteTeam.Add(chessboard[row, col]);
                    }
                    else
                    {
                        blackTeam.Add(chessboard[row, col]);
                    }
                }
                else
                {
                    if (char.IsUpper(chessboard[row, col]))
                    {
                        blackTeam.Add(chessboard[row, col]);
                    }
                    else
                    {
                        whiteTeam.Add(chessboard[row, col]);
                    }
                }
            }
        }
        for (int i = 0; i < blackTeam.Count; i++)
        {
            if (char.IsLetterOrDigit(blackTeam[i]))
            {
                blackTeamScore = blackTeamScore + (int)blackTeam[i];
            }
            else
            {
                blackTeamScore += 0;
            }
        }
        for (int i = 0; i < whiteTeam.Count; i++)
        {
            if (char.IsLetterOrDigit(whiteTeam[i]))
            {
                whiteTeamScore = whiteTeamScore + (int)whiteTeam[i];
            }
            else
            {
                whiteTeamScore += 0;
            }
        }
        // for (int i = 0; i < blackTeam.Count; i++)
        // {
        //     Console.Write("{0} ", (int)blackTeam[i]);
        // }
        // Console.WriteLine();
        // for (int i = 0; i < whiteTeam.Count; i++)
        // {
        //     Console.Write("{0} ", (int)whiteTeam[i]);
        // }
        if (blackTeamScore > whiteTeamScore)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackTeamScore - whiteTeamScore);
        }
        else if (blackTeamScore == whiteTeamScore)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteTeamScore - blackTeamScore);
        }
        else
        {
            Console.WriteLine("Equal result: {0}", blackTeamScore);
        }
    }
}
