using System;
using System.IO;

class StringReplace
{   
    // Constants
    const string InputFilePath = @"../../input.txt";
    const string OutputFilePath = @"../../output.txt";
    const string SearchWord = "start";
    const string ReplaceWord = "finish";

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
                // Search & replace 
                line = line.Replace(SearchWord, ReplaceWord);

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
