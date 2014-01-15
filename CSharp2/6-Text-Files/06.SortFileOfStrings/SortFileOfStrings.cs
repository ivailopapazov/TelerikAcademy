using System;
using System.Collections.Generic;
using System.IO;

class SortFileOfStrings
{   
    // File path constants
    const string InputFilePath = @"../../input.txt";
    const string OutputFilePath = @"../../output.txt";

    static void Main()
    {
        // List with names
        List<string> names = new List<string>();

        // Read file with names
        using (StreamReader input = new StreamReader(InputFilePath))
        {
            // Read first name
            string name = input.ReadLine();

            // Read all names
            while (name != null)
            {
                // Add to list
                names.Add(name);

                // Read next name
                name = input.ReadLine();
            }
        }

        // Sort list
        names.Sort();

        // Write to output file
        using (StreamWriter output = new StreamWriter(OutputFilePath))
        {
            foreach (var name in names)
            {
                output.WriteLine(name);
            }
        }

        // Print output file
        using (StreamReader output = new StreamReader(OutputFilePath))
        {
            Console.WriteLine(output.ReadToEnd());
        }
    }
}
