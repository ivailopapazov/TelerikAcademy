using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        // User input
        Console.Write("Enter text: ");
        string haystack = Console.ReadLine();
        Console.Write("Enter keyword: ");
        string needle = Console.ReadLine();

        // Variables
        List<string> result = new List<string>();

        // Get all sentences
        string[] sentences = haystack.Split('.');

        // Iterate sentences
        foreach (string sentence in sentences)
        {
            // If sentence contains keyword
            if (Regex.IsMatch(sentence, @"\bin\b"))
            {
                // Add trimmed sentence to result list
                result.Add(sentence.Trim());
            }
        }

        // Print result
        foreach (string sentence in result)
        {
            Console.WriteLine(sentence);
        }
    }
}
