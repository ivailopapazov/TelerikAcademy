using System;
using System.Collections.Generic;

class ExtractPalindromes
{
    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        // User input
        Console.WriteLine("Enter text: ");
        string[] words = Console.ReadLine().Split(' ');

        // Variables
        List<string> palindromes = new List<string>();

        // Check words
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        // Print result
        palindromes.ForEach(word => Console.WriteLine(word));

    }
}
