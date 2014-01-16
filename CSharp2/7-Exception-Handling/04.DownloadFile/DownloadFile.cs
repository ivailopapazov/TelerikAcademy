using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        // User input
        Console.Write("Enter download link: ");
        string url = Console.ReadLine();

        // Create WebClient object
        WebClient link = new WebClient();
        
        // Try download
        try
        {
            // Get file extension
            string ext = url.Substring(url.LastIndexOf('.'));

            // Download file
            link.DownloadFile(url, @"../../download" + ext);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid download URL");
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (WebException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (NotSupportedException exc)
        {
            Console.WriteLine(exc.Message);
        }
        finally
        {
            // Free web resource
            link.Dispose();
        }
    }
}