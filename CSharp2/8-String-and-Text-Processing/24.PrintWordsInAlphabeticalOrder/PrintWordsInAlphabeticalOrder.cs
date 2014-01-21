using System;
using System.Collections.Generic;

class PrintWordsInAlphabeticalOrder
{
    static void Main()
    {
        // User input
        Console.Write("Enter words (space separated): ");
        string[] words = Console.ReadLine().Split(' ');

        // Order words alphabetically
        Array.Sort(words, StringComparer.OrdinalIgnoreCase);

        // Print ordered array
        Array.ForEach(words, word => Console.WriteLine(word));
    }
}
