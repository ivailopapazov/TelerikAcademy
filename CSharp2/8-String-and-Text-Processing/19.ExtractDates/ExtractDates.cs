using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        // User input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Match dates
        MatchCollection dates = Regex.Matches(text, @"[0-3][0-9]\.[01][0-9]\.[0-9]{4}");

        // Print result
        foreach (Match date in dates)
        {
            // Parse bulgarian date format
            DateTime parsedDate = DateTime.Parse(date.ToString(), new CultureInfo("bg-BG"), DateTimeStyles.None);
            // Print as canadian date format 
            Console.WriteLine("{0}", parsedDate.ToString(new CultureInfo("en-CA")));
        }
    }
}