using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    // Constant
    const string FilePath = @"../../hamlet.txt";

    static void Main()
    {
        // Odd lines container
        StringBuilder oddLines = new StringBuilder();

        // Open stream
        using (StreamReader file = new StreamReader(FilePath))
        {
            // Read first line
            string line = file.ReadLine();

            // Line Counter
            int lineCounter = 1;

            // Read whole file
            while (line != null)
            {
                // If line is odd
                if (lineCounter % 2 == 1)
                {
                    oddLines.AppendLine(line);
                }

                // Increment counter
                lineCounter++;

                // Read next line
                line = file.ReadLine();
            }
        }

        // Write oddlines to file
        using (StreamWriter file = new StreamWriter(FilePath))
        {
            file.Write(oddLines.ToString());
        }

        // Print file
        using (StreamReader file = new StreamReader(FilePath))
        {
            Console.WriteLine(file.ReadToEnd());
        }
    }
}
