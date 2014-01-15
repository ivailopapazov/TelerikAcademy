using System;

class PrintDayOfWeak
{
    static void Main()
    {
        // Get today's day of weak
        DayOfWeek todaysDay = DateTime.Today.DayOfWeek;

        // Print result
        Console.WriteLine(todaysDay);
    }
}
