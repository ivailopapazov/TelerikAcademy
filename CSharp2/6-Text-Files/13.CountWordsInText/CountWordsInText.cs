using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;


class CountWordsInText
{
    // Path constants
    const string WordsFilePath = @"../../words.txt";
    const string TestFilePath = @"../../test.txt";
    const string ResultFilePath = @"../../result.txt";

    static void Main()
    {
        // Take words file conent
        string wordsContent = File.ReadAllText(WordsFilePath);

        // Match words
        MatchCollection wordsMatch = Regex.Matches(wordsContent, @"\w+");

        // Creating list with words
        List<string> words = new List<string>();
        foreach (Match wordMatch in wordsMatch)
        {
            words.Add(wordMatch.ToString());
        }

        // Using dictionary to store every word occurance
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
        foreach (string word in words)
        {
            wordsDictionary.Add(word, 0);
        }
        
        // Get conent of test file
        string testContent = File.ReadAllText(TestFilePath);

        // Count each word occurance
        foreach (string word in words)
        {
            // Matching current word
            Match occurance = Regex.Match(testContent, word);

            // Iterate every occurance of the word
            while (occurance.Success)
            {
                // Increment word count in dictionary
                wordsDictionary[word]++;
                // Move to next occurance
                occurance = occurance.NextMatch();
            }
        }

        // Write into result file
        try
        {
            using (StreamWriter result = new StreamWriter(ResultFilePath))
            {
                // Iterate over ordered dictionary
                foreach (KeyValuePair<string, int> kvp in wordsDictionary.OrderByDescending(word => word.Value))
                {
                    result.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
                }
            }
        }
        catch (Exception)
        {
            
            throw;
        }


        // Print result from result file
        Console.WriteLine(File.ReadAllText(ResultFilePath));
    }
}
