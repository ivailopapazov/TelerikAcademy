using System;
using System.Text;

class ConvertToUnicodeLiterals
{
    static string GetUnicode(string input)
    {
        // Variables
        StringBuilder unicode = new StringBuilder();

        // Convert characters
        foreach (char letter in input)
        {
            // Get char unicode literal
            string literal = string.Format("\\u{0:X4}", (int)letter);
            // Add to container
            unicode.Append(literal);
        }

        // Return
        return unicode.ToString();
    }
    static void Main()
    {
        // User input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Convert to unicode literals
        string result = GetUnicode(text);

        // Print result
        Console.WriteLine(result);

    }
}
