// Problem 9.	Play with Int, Double and String
// Write a program that, depending on the user’s choice, inputs an int,
// double or string variable.If the variable is int or double, the program
// increases it by one. If the variable is a string, the program appends "*" at
// the end.Print the result at the console. Use switch statement.

using System;

class IntDoubleStr
{
    static void Main()
    {
        Console.WriteLine("Enter \"1\" for \"int\", \"2\" for \"double\" and \"3\" for \"string\": ");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
            case "2":
                Console.WriteLine("Enter a number: ");
                double number = double.Parse(Console.ReadLine());
                double result = number + 1;
                Console.WriteLine(result);
                break;
            case "3":
                Console.WriteLine("Enter a text: ");
                string text = Console.ReadLine();
                Console.WriteLine(text + new string('*', 1));
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}

