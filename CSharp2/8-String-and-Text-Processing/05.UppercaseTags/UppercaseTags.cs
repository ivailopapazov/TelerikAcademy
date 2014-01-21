using System;

class UppercaseTags
{
    static void Main()
    {
        // User input
        Console.Write("Enter the text: ");
        string haystack = Console.ReadLine();

        // Variablses
        string openTag = "<upcase>";
        string closeTag = "</upcase>";
        int index = 0;
        int length = 0;

        // Iterate each open tag
        while (true)
        {
            // Find index
            index = haystack.IndexOf(openTag, index);

            // If no more tags
            if (index == -1)
            {
                break;
            }

            // Move index
            index += openTag.Length;

            // Find length
            length = haystack.IndexOf(closeTag, index) - index;
            
            // Get text between tags
            string inTags = haystack.Substring(index, length);

            // Replace text
            haystack = haystack.Replace(inTags, inTags.ToUpper());

            // Remove tags
            haystack = haystack.Replace(openTag, "");
            haystack = haystack.Replace(closeTag, "");
        }

        // Print result
        Console.WriteLine(haystack);
    }
}
