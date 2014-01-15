using System;
using System.IO;

class ConcatinatingTwoTextFiles
{
    // File path constants
    const string FilePath1 = @"../../file1.txt";
    const string FilePath2 = @"../../file2.txt";
    const string FilePath3 = @"../../file3.txt";

    static void Main()
    {
        // Create StreamReader object for file1 and file2
        StreamReader file1 = new StreamReader(FilePath1);
        StreamReader file2 = new StreamReader(FilePath2);

        // Read the content of file1 and file2
        string file1Text = file1.ReadToEnd();
        string file2Text = file2.ReadToEnd();

        // Close file1 and file2 streams
        file1.Close();
        file2.Close();

        // Create StreamWriter object for file3
        StreamWriter file3 = new StreamWriter(FilePath3);

        // Write content of file1 into file3 with line terminator at the and
        file3.WriteLine(file1Text);
        file3.WriteLine(file2Text);

        // Close StreamWriter object
        file3.Close();

        // Create StreamReader object
        StreamReader readFile3 = new StreamReader(FilePath3);

        // Print file3 content
        Console.Write(readFile3.ReadToEnd());
    }
}
