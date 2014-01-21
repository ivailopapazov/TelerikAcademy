using System;
using System.Text;
using System.Text.RegularExpressions;

class ReverseWordsInSentence
{
    static string MovePunctuation(string word)
    {
        // Get last char
        char lastChar = word[word.Length - 1];

        // Check punctuation
        if (char.IsPunctuation(lastChar))
        {
            return lastChar + word.Substring(0, word.Length - 1);
        }
        else
        {
            return word;
        }

    }
    static void Main()
    {
        // User input
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        // Split text by spaces
        string[] split = text.Split(' ');

        // Reverse words in text
        Array.Reverse(split);

        // Variables
        StringBuilder result = new StringBuilder();

        foreach (string word in split)
        {
            // Move punctuation
            string editedWord = MovePunctuation(word);

            // Append to result text
            result.Append(editedWord);
            result.Append(" ");
        }

        // Print Result
        Console.WriteLine(result);
    }
}