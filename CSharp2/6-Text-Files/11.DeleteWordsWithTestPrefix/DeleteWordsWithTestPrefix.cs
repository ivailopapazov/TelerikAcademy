using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsWithTestPrefix
{
    // File path constant
    const string FilePath = @"../../file.txt";

    static void Main()
    {
        // Get file content
        string textContainer = File.ReadAllText(FilePath);

        // Replace 
        string outputText = Regex.Replace(textContainer, @"\btest[a-zA-Z0-9_]+\b", "");

        // Write into file
        File.WriteAllText(FilePath, outputText);

        // Print output text
        Console.WriteLine(outputText);
    }
}
