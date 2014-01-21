using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PrintLettersCount
{
    static void Main()
    {
        // User input
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        // Variables
        Dictionary<char, int> letters = new Dictionary<char, int>();

        // Remove white spaces
        text = Regex.Replace(text, @"\s", "");

        // Iterate characters
        for (int i = 0; i < text.Length; i++)
        {
            if (letters.ContainsKey(text[i]))
            {
                // If character is in dictionary increment value
                letters[text[i]]++;
            }
            else
            {
                // Add character if it's not in dictionary 
                letters.Add(text[i], 1);
            }
        }

        // Print result
        foreach (KeyValuePair<char, int> letter in letters)
        {
            Console.WriteLine("[{0}] - {1}", letter.Key, letter.Value);
        }
    }
}
