using System;
using System.IO;

class CompareTwoFiles
{
    // File path constants
    const string FirstFilePath = @"../../first.txt";
    const string SecondFilePath = @"../../second.txt";

    static void Main()
    {
        // Variable Declaration
        int sameLines = 0;
        int differentLines = 0;

        // Using Streamreader objects
        using (StreamReader file1 = new StreamReader(FirstFilePath))
        using (StreamReader file2 = new StreamReader(SecondFilePath))
        {
            // Get first lines
            string line1 = file1.ReadLine();
            string line2 = file2.ReadLine();

            // Compare line by line
            while (line1 != null)
            {
                // If lines are equal
                if (line1.Equals(line2))
                {
                    sameLines++;
                }
                else
                {
                    differentLines++;
                }

                // Read next lines
                line1 = file1.ReadLine();
                line2 = file2.ReadLine();
            }
        }

        // Print result
        Console.WriteLine("Same lines: {0}", sameLines);
        Console.WriteLine("Different lines: {0}", differentLines);
    }
}
