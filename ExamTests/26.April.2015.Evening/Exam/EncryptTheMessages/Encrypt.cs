using System;
using System.Collections.Generic;

class Encrypt
{
    static void Main()
    {
        Dictionary<char, char> specialSymbols = new Dictionary<char, char>
        {
            {' ', '+'},
            {',', '%'},
            {'.', '&'},
            {'?', '#'},
            {'!', '$'}
        };
        List<string> encryptedMessages = new List<string>();

        string command = Console.ReadLine();

        while (command.ToLower() != "start")
        {
            Console.ReadLine();
        }
        command = Console.ReadLine();

        while (command.ToLower() != "end")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }
            char[] symbols = command.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                char currentSymbol = symbols[i];
                if (specialSymbols.ContainsKey(currentSymbol))
                {
                    symbols[i] = specialSymbols[currentSymbol];
                }
                else if ((currentSymbol >= 'a' && currentSymbol <= 'm') || (currentSymbol >= 'A' && currentSymbol <= 'M'))
                {
                    symbols[i] = (char)(currentSymbol + 13);
                }
                else if (('n' <= currentSymbol && currentSymbol <= 'z') || ('N' <= currentSymbol && currentSymbol <= 'Z'))
                {
                    symbols[i] = (char)(currentSymbol - 13);
                }
            }
            Array.Reverse(symbols);
            encryptedMessages.Add(new string(symbols));
            command = Console.ReadLine();
        }
        if (encryptedMessages.Count == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", encryptedMessages.Count);

            foreach (var decryptedMessage in encryptedMessages)
            {
                Console.WriteLine(decryptedMessage);
            }
        }
    }
}
