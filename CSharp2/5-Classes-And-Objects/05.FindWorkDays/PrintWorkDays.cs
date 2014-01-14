using System;

public static class OfficialHolidays
{
    // Official holidays
    static DateTime[] holidays = new DateTime[] 
    {
        new DateTime(2014, 1, 27),
        new DateTime(2014, 1, 29),
        new DateTime(2014, 2, 3)
    };

    public static bool IsHoliday(DateTime date)
    {
        foreach (var holiday in holidays)
        {
            // If date is holiday
            if (holiday == date)
            {
                return true;
            }
        }

        // If date is not holiday
        return false;
    }
}
class PrintWorkDays
{
    static int FindWorkDays(DateTime endDate)
    {
        int workDays = 0;

        // Check for each date from todays date to endDate including
        for (DateTime i = DateTime.Now; i <= endDate; i = i.AddDays(1))
        {
            // Check if weekend
            if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
            {
                continue;
            }
            // Check if holiday
            else if (OfficialHolidays.IsHoliday(i))
            {
                continue;
            }
            // Workday
            else 
            {
                workDays++;
            }
        }
        return workDays;
    }
    static void Main()
    {
        // User input
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter a month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter a day: ");
        int day = int.Parse(Console.ReadLine());

        // Variable declaration
        DateTime endDate = new DateTime(year, month, day);
        
        // Find workdays
        int workDays = FindWorkDays(endDate);

        // Print result
        Console.WriteLine(workDays);
    }
}
