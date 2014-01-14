using System;

class CheckLeapYear
{
    static void Main()
    {
        // User input
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Check for leap year
        bool isLeap = DateTime.IsLeapYear(year);

        // Print result
        Console.WriteLine("Year {0} is leap: {1}", year, isLeap);
    }
}
