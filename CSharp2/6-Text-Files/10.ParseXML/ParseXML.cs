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
        char currentChar = new char();
        StringBuilder container = new StringBuilder();

        // Get xml content
        string content = File.ReadAllText(FilePath);

        for (int i = 0; i < content.Length; i++)
        {
            // Get current char
            currentChar = content[i];

            // Move index if xml tag begins
            if (currentChar == '<')
            {
                i = content.IndexOf('>', i);
            }
            else
            {
                container.Append(currentChar);
            }
        }

        Console.WriteLine(container);
    }
}