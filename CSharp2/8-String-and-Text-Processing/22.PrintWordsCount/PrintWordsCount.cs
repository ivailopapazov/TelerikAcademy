using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PrintWordsCount
{
    static void Main()
    {
        // User input
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        // Variables
        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        // Split words
        string[] words = text.Split(' ');

        // Iterate words
        foreach (string word in words)
        {
            if (wordsCount.ContainsKey(word))
            {
                // If word is in dictionary increment value
                wordsCount[word]++;
            }
            else
            {
                // Add word if it's not in dictionary 
                wordsCount.Add(word, 1);
            }
        }

        // Print result
        foreach (KeyValuePair<string, int> word in wordsCount)
        {
            Console.WriteLine("[{0}] - {1}", word.Key, word.Value);
        }
    }
}
