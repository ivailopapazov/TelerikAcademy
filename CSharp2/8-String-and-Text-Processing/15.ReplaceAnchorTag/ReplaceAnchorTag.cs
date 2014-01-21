using System;
using System.Collections.Generic;
using System.Text;

class ReplaceAnchorTag
{
    static void Main()
    {
        // User input
        Console.WriteLine("Enter HTML: ");
        string html = Console.ReadLine();

        // Variables
        string oldOpenTag = "<a href=\"";
        string oldCloseTag = "</a>";
        string newOpenTag = "[URL=";
        string newCloseTag = "[/URL]";

        // Indexes of the '>' chars from the old opening tags
        List<int> indexes = new List<int>();
        int index = -1;

        // Find indexes of the end of the open anchor tag
        while ((index = html.IndexOf(oldOpenTag, index + 1)) > 0)
        {
            indexes.Add(html.IndexOf("\">", index + 1));
        }

        // Result string builder
        StringBuilder builder = new StringBuilder(html);

        // Replace end of the open anchor tag
        for (int i = indexes.Count - 1; i >= 0; i--)
        {
            builder.Replace("\">", "]", indexes[i], 2);
        }

        // Replace open and close anchor tags
        builder.Replace(oldOpenTag, newOpenTag);
        builder.Replace(oldCloseTag, newCloseTag);

        // Print result
        Console.WriteLine(builder);
    }
}