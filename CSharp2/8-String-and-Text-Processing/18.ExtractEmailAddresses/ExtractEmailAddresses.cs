using System;
using System.Text.RegularExpressions;

class ExtractEmailAddresses
{
    static void Main()
    {
        // User input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Match dates
        Match email = Regex.Match(text, @"([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})");

        // Print result
        while (email.Success)
        {
            Console.WriteLine(email);
            email = email.NextMatch();
        }
    }
}
