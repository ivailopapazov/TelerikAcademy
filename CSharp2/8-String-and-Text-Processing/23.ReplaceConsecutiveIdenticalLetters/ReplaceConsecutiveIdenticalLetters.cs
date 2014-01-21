using System;
using System.Text;

class ReplaceConsecutiveIdenticalLetters
{
    static void Main()
    {
        // User input
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        // Variables
        StringBuilder result = new StringBuilder();
        result.Append(text[0]);

        // Iterate each char
        for (int i = 1; i < text.Length; i++)
        {
            // If current char is different than previous, append to result
            if (text[i] != text[i - 1])
            {
                result.Append(text[i]);
            }
        }

        // Print result
        Console.WriteLine(result);
    }
}
