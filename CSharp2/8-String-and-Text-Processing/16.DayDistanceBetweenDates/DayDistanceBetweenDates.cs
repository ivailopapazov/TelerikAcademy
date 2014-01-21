using System;
using System.Globalization;

class DayDistanceBetweenDates
{
    static void Main()
    {
        // User input
        Console.WriteLine("Enter first date (day.month.year): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("bg-BG"));
        Console.WriteLine("Enter second date (day.month.year): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("bg-BG"));

        // Get time distance
        TimeSpan distance = secondDate - firstDate;

        // Print day distance
        Console.WriteLine("Distance: {0} days", distance.Days);
    }
}