using System;
using System.IO;

class InsertNumberBeforeLines
{
    // File path constants
    const string InputFilePath = @"../../Hamlet.txt";
    const string OutputFilePath = @"../../output.txt";

    static void Main()
    {
        // Create objects
        StreamReader inputFile = new StreamReader(InputFilePath);
        StreamWriter outputFile = new StreamWriter(OutputFilePath);

        // Get first input file line
        string line = inputFile.ReadLine();

        // Line counter
        int lineCounter = 1;

        // Read until the end of the input file
        while (line != null)
        {
            // Write line with number to output
            outputFile.WriteLine("{0} - {1}", lineCounter, line);

            // Increment line counter
            lineCounter++;

            // Read new line
            line = inputFile.ReadLine();
        }

        // Close Streams
        inputFile.Close();
        outputFile.Close();

        // Print output file
        using (StreamReader readOutputFile = new StreamReader(OutputFilePath))
        {
            Console.WriteLine(readOutputFile.ReadToEnd());
        }
    }
}
