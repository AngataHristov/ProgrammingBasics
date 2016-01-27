// Problem 4.	Print a Deck of 52 Cards
// Write a program that generates and prints all possible cards from a standard deck of 52 cards(without the jokers).
// The cards should be printed using the classical notation(like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A.
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
// Use 2 nested for-loops and a switch-case statement.

using System;

class Cards
{
    static void Main()
    {
        Console.WriteLine("All cards from standart deck are:");
        Console.WriteLine();

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2:
                        Console.Write("2".PadLeft(2));
                        break;
                    case 3:
                        Console.Write("3".PadLeft(2));
                        break;
                    case 4:
                        Console.Write("4".PadLeft(2));
                        break;
                    case 5:
                        Console.Write("5".PadLeft(2));
                        break;
                    case 6:
                        Console.Write("6".PadLeft(2));
                        break;
                    case 7:
                        Console.Write("7".PadLeft(2));
                        break;
                    case 8:
                        Console.Write("8".PadLeft(2));
                        break;
                    case 9:
                        Console.Write("9".PadLeft(2));
                        break;
                    case 10:
                        Console.Write("10".PadLeft(2));
                        break;
                    case 11:
                        Console.Write("J".PadLeft(2));
                        break;
                    case 12:
                        Console.Write("Q".PadLeft(2));
                        break;
                    case 13:
                        Console.Write("K".PadLeft(2));
                        break;
                    case 14:
                        Console.Write("A".PadLeft(2));
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                switch (j)
                {
                    case 1:
                        Console.Write("{0} ", (char)5);
                        break;
                    case 2:
                        Console.Write("{0} ", (char)4);
                        break;
                    case 3:
                        Console.Write("{0} ", (char)3);
                        break;
                    case 4:
                        Console.Write("{0} ", (char)6);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
