using System;

class ForbiddenWords
{
    static void Main()
    {
        // User input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.Write("Enter forbidden words (comma separated): ");
        string[] words = Console.ReadLine().Split(','); 

        // Iterate words
        foreach (string word in words)
        {
            // Replace with asterisks
            text = text.Replace(word, new string('*', word.Length));
        }

        // Print result
        Console.WriteLine(text);
    }
}