using System;

class FindLettersInArray
{
    static void Main()
    {
        // User Input
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();

        // Variable Declaration
        char letter = 'a';
        char[] alphabet = new char[26];

        // Creating alphabet array
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = letter;
            letter++;
        }

        // Use lowercase only
        word = word.ToLower();

        // Searching word letters indexes
        for (int i = 0; i < word.Length; i++)
        {
            int index = Array.BinarySearch(alphabet, word[i]);
            Console.WriteLine("{0} has index of {1}", word[i], index + " ");
        }
    }
}
