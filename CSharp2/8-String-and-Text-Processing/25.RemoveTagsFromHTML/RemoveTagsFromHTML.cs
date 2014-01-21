using System;
using System.Text.RegularExpressions;

class RemoveTagsFromHTML
{
    static void Main()
    {
        // User input
        Console.Write("Enter single line HTML: ");
        string html = Console.ReadLine();

        // Regex match
        MatchCollection htmlContent = Regex.Matches(html, @"(?<=^|>)[^><]+?(?=<|$)");

        // Print result
        Console.WriteLine(new string('-', 20));
        foreach (Match match in htmlContent)
        {
            Console.WriteLine(match);
        }
    }
}