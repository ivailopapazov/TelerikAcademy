using System;
using System.Collections.Generic;
using System.IO;

class SearchInDictionary
{
    static void Main()
    {
        // User input
        Console.Write("Enter words number: ");
        int count = int.Parse(Console.ReadLine());
        string[] dictionaryLines = new string[count];
        Console.WriteLine("Enter dictionary:");
        for (int i = 0; i < count; i++)
        {
            dictionaryLines[i] = Console.ReadLine();
        }
        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        
        // Variables
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // Parse dictionary lines
        for (int i = 0; i < dictionaryLines.Length; i++)
        {
            // Parse line into word and description
            string[] parts = dictionaryLines[i].Split(new string[] { " - " }, 2, StringSplitOptions.None);

            // Add to dictionary
            dictionary.Add(parts[0], parts[1]);
        }

        // Print result
        Console.WriteLine("Word meaning: {0}", dictionary[word]);
    }
}
