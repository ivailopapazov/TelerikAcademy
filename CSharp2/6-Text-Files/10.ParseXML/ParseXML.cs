using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ParseXML
{
    // Path constant
    const string FilePath = @"../../input.xml";
    static void Main()
    {
        // Variable declarations
        StringBuilder words = new StringBuilder();
        string word = string.Empty;

        // Get xml content
        string content = File.ReadAllText(FilePath);

        // Parse xml conent
        for (int i = 0; i < content.Length; i++)
        {
            // Beginning of tag
            if (content[i] == '<')
            {
                // If there was a word before the tag
                if (word.Length != 0)
                {
                    words.AppendLine(word.Trim());
                }
                // Move index to the end of the tag
                i = content.IndexOf('>', i);
                // Clear current word
                word = string.Empty;
            }
            // Between tags
            else
            {
                // Add characters to form a word
                word += content[i];
            }
        }

        // Print result
        Console.WriteLine(words);
    }
}