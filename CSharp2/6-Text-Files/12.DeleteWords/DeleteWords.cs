using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWords
{
    // Path constants
    const string WordsPath = @"../../words.txt";
    const string TextPath = @"../../text.txt";

    static void Main()
    {
        // Get words file content
        string wordsContent = File.ReadAllText(WordsPath);

        // Search for words in string
        MatchCollection wordMatches = Regex.Matches(wordsContent, @"\w+");

        // Get text file content
        string textContent = File.ReadAllText(TextPath);
        
        // Remove words from text
        foreach (Match wordMatch in wordMatches)
        {
            // Replace word with empty string
            textContent = Regex.Replace(textContent, wordMatch.ToString(), string.Empty);
        }

        // Write modified text to file
        try
        {
            using (StreamWriter output = new StreamWriter(TextPath))
            {
                output.Write(textContent);
            }
        }
        catch (Exception)
        {
            
            throw;
        }
        finally
        {
            // Print modified text to console
            Console.WriteLine(textContent);
        }
    }
}
