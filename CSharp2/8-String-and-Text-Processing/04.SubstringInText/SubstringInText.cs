using System;

class SubstringInText
{
    static void Main()
    {
        // User input
        Console.Write("Enter the text: ");
        string haystack = Console.ReadLine().ToLower();
        Console.Write("Enter the word: ");
        string needle = Console.ReadLine().ToLower();

        // Variables
        int index = 0;
        int count = 0;

        // Iterate each occurance of needle
        while (true)
        {
            // Get index of next occurance
            index = haystack.IndexOf(needle, index);
            // Break if there are no more occurances of needle
            if (index < 0)
            {
                break;
            }
            // Move to the end of the occurance
            index += needle.Length;
            // Count occurances
            count++;
        }

        // Print result
        Console.WriteLine(count);
    }
}
