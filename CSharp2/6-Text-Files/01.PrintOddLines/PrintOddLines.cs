using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        // Using StreamReader object
        using (StreamReader file = new StreamReader(@"../../Hamlet.txt"))
        {
            // Read first line
            string line = file.ReadLine();

            // Line counter
            int lineCounter = 1;

            // Read each line
            while (line != null)
            {
                // If line is odd
                if (lineCounter % 2 == 1)
                {
                    Console.WriteLine(line);
                }

                // Read next line
                line = file.ReadLine();

                // Increment line counter
                lineCounter++;
            }
        }
    }
}
