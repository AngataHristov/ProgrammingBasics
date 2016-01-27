// Problem 9.	Extract URLs from Text
// Write a program that extracts and prints all URLs from given text.URL can be in only two formats:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        Regex linkParser = new Regex(@"(?:https?://|www.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        foreach (var link in linkParser.Matches(text))
        {
            Console.WriteLine(link);
        }
    }
}
