using System;
using System.Globalization;

class PrintDateTime
{
    static void Main()
    {
        // Set culture to bulgarian
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        // Datetime format example 21.02.2014 19:31:35
        string dateTimeFormat = "dd.MM.yyyy HH:mm:ss";

        // Get datetime
        Console.Write("Enter datetime ({0}): ", dateTimeFormat);
        DateTime dateTime = new DateTime();
        if (DateTime.TryParseExact(Console.ReadLine(), dateTimeFormat, CultureInfo.DefaultThreadCurrentCulture, DateTimeStyles.None, out dateTime))
        {
            // Add 6h and 30 min
            dateTime = dateTime.AddHours(6).AddMinutes(30);

            // Print datetime
            Console.WriteLine("{0}", dateTime.ToString("bg-BG"));
        }
        else
        {
            Console.WriteLine("Invalid format!");
        }


    }
}
