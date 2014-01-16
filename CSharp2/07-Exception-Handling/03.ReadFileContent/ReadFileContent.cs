using System;
using System.IO;

class ReadFileContent
{
    static void Main()
    {
        // File conent variable
        string content = string.Empty;

        // User input
        Console.Write("Enter full path: ");
        string path = Console.ReadLine();

        try
        {
            // Get file content
            content = File.ReadAllText(path);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (DirectoryNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (PathTooLongException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (UnauthorizedAccessException exc)
        {
            Console.WriteLine(exc.Message);
        }

        // Print conent
        Console.WriteLine(content);
    }
}
