using System;
using System.IO;
using System.Text.RegularExpressions;

class StringReplaceWholeWords
{
    // Constants
    const string InputFilePath = @"../../input.txt";
    const string OutputFilePath = @"../../output.txt";

    static void Main()
    {
        // Open streams
        using (StreamReader input = new StreamReader(InputFilePath))
        using (StreamWriter output = new StreamWriter(OutputFilePath))
        {
            // Read first line
            string line = input.ReadLine();

            while (line != null)
            {
                // Search & replace whole word only
                line = Regex.Replace(line, @"\bstart\b", "finish", RegexOptions.IgnoreCase);

                // Write line into output
                output.WriteLine(line);

                // Read next line
                line = input.ReadLine();
            }
        }

        // Print output file
        using (StreamReader output = new StreamReader(OutputFilePath))
        {
            Console.WriteLine(output.ReadToEnd());
        }
    }
}