using System;

class PaddingString
{
    static void Main()
    {
        // User Input
        Console.Write("Enter a string with length < 20: ");
        string text = Console.ReadLine();

        if (text.Length > 20)
        {
            // Get substring with length 20
            text = text.Substring(0, 20);
        }
        else
        {
            // Padding string with asterisk
            text = text.PadRight(20, '*');
        }

        // Print result
        Console.WriteLine(text);
    }
}
